using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RECOMANAGESYS
{
    public partial class ForgotPasswordRequestFrm : Form
    {
        public ForgotPasswordRequestFrm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void ForgotPasswordRequestFrm_Load(object sender, EventArgs e)
        {

        }

        private void btnSendResetLink_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string email = txtEmail.Text.Trim();

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please enter your username.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
                return;
            }

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please enter your registered email.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }

            try
            {
                RequestPasswordReset(username, email);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RequestPasswordReset(string username, string email)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();

                string query = @"SELECT UserId, IsActive 
                        FROM Users 
                        WHERE Username = @Username AND LoginEmail = @LoginEmail";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@LoginEmail", email);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            MessageBox.Show("Invalid username or email. Please check your details.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        int userId = Convert.ToInt32(reader["UserId"]);
                        bool isActive = reader["IsActive"] != DBNull.Value
                            ? Convert.ToBoolean(reader["IsActive"])
                            : true;

                        if (!isActive)
                        {
                            MessageBox.Show("This account has been deactivated. Please contact an administrator to reactivate your account.",
                                "Account Inactive", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        reader.Close();

                        string token = GenerateResetToken(8);
                        DateTime expiry = DateTime.UtcNow.AddMinutes(15);

                        string insert = @"INSERT INTO PasswordResetTokens (UserId, Token, Expiry, IsUsed)
                                  VALUES (@UserId, @Token, @Expiry, 0)";
                        using (SqlCommand insertCmd = new SqlCommand(insert, conn))
                        {
                            insertCmd.Parameters.AddWithValue("@UserId", userId);
                            insertCmd.Parameters.AddWithValue("@Token", token);
                            insertCmd.Parameters.AddWithValue("@Expiry", expiry);
                            insertCmd.ExecuteNonQuery();
                        }

                        SendResetEmail(email, token);

                        MessageBox.Show("A reset code has been sent to your registered email.",
                            "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Hide();
                        forgotpassfrm resetForm = new forgotpassfrm();
                        resetForm.StartPosition = FormStartPosition.CenterScreen;
                        resetForm.ShowDialog();
                        this.Close();
                    }
                }
            }
        }

        private string GenerateResetToken(int length = 10)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        private void SendResetEmail(string recipientEmail, string token)
        {
            string subject = "Password Reset Request";
            string body =
                $"Hello,\n\nWe received a request to reset your password.\n\n" +
                $"Here is your reset token:\n\n{token}\n\n" +
                $"Use this token in the app within 15 minutes to reset your password.\n\n" +
                $"If you didn’t request this, you can safely ignore this email.\n\n" +
                $"— RMS Dev Support Team";

            using (SmtpClient client = new SmtpClient("smtp.gmail.com", 587))
            {
                // Use  Gmail and App Password (never your real Gmail password)
                client.Credentials = new NetworkCredential("henrydaniex@gmail.com", "rhya cwvt rswq bymo");
                client.EnableSsl = true;

                using (MailMessage mail = new MailMessage())
                {

                    mail.From = new MailAddress("henrydaniex@gmail.com", "RMS Dev");

                    mail.To.Add(recipientEmail);
                    mail.Subject = subject;
                    mail.Body = body;
                    mail.IsBodyHtml = false;

                    client.Send(mail);
                }
            }
        }

    }
}
