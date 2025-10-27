using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RECOMANAGESYS
{
    public partial class forgotpassfrm : Form
    {
        private const int MinimumPasswordLength = 8;
        public forgotpassfrm()
        {
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.Dpi;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void forgotpassfrm_Load(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            string username = txtUsername.Text.Trim();
            string token = txtToken.Text.Trim();
            string newPassword = newpass.Text.Trim();

            try
            {
                int? userId = ValidateResetToken(username, token);
                if (userId == null)
                {
                    MessageBox.Show("Invalid username or token, or the token has expired.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                ResetUserPassword((int)userId, newPassword);
                MarkTokenAsUsed(token);

                MessageBox.Show("Password has been reset successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Please enter your username.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtToken.Text))
            {
                MessageBox.Show("Please enter the reset token from your email.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtToken.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(newpass.Text))
            {
                MessageBox.Show("Please enter a new password.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                newpass.Focus();
                return false;
            }

            if (newpass.Text.Length < MinimumPasswordLength)
            {
                MessageBox.Show($"Password must be at least {MinimumPasswordLength} characters long.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                newpass.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(confirmpass.Text))
            {
                MessageBox.Show("Please confirm your password.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                confirmpass.Focus();
                return false;
            }

            if (newpass.Text != confirmpass.Text)
            {
                MessageBox.Show("Passwords do not match.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                confirmpass.Focus();
                return false;
            }

            return true;
        }

        private int? ValidateResetToken(string username, string token)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();


                string query = @"
                        SELECT t.UserId, u.IsActive
                        FROM PasswordResetTokens t
                        INNER JOIN Users u ON u.UserId = t.UserId
                        WHERE u.Username = @Username 
                          AND t.Token = @Token 
                          AND t.IsUsed = 0 
                          AND t.Expiry > GETUTCDATE()";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Token", token);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (!reader.Read())
                            return null;

                        int userId = Convert.ToInt32(reader["UserId"]);
                        bool isActive = reader["IsActive"] != DBNull.Value
                            ? Convert.ToBoolean(reader["IsActive"])
                            : true;

                        if (!isActive)
                        {
                            MessageBox.Show("This account has been deactivated. Please contact an administrator to reactivate your account.",
                                "Account Inactive", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return null;
                        }

                        return userId;
                    }
                }
            }
        }
        private void ResetUserPassword(int userId, string newPassword)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (SqlTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {
                        string hashedPassword = BCrypt.Net.BCrypt.HashPassword(newPassword);

                        string updateQuery = "UPDATE Users SET PasswordHash = @Password WHERE UserId = @UserId";
                        using (SqlCommand cmd = new SqlCommand(updateQuery, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@Password", hashedPassword);
                            cmd.Parameters.AddWithValue("@UserId", userId);
                            cmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }
        private void MarkTokenAsUsed(string token)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "UPDATE PasswordResetTokens SET IsUsed = 1 WHERE Token = @Token";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Token", token);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}








