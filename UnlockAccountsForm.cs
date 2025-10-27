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
    public partial class UnlockAccountsForm : Form
    {
        public UnlockAccountsForm()
        {
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.Dpi;

            dgvLockedAccounts.Columns.Clear();
            dgvLockedAccounts.Columns.Add("UserID", "UserID");
            dgvLockedAccounts.Columns.Add("Username", "Username");
            dgvLockedAccounts.Columns.Add("Firstname", "Firstname");
            dgvLockedAccounts.Columns.Add("Lastname", "Lastname");
            dgvLockedAccounts.Columns.Add("RoleName", "Role");
            foreach (DataGridViewColumn col in dgvLockedAccounts.Columns)
            {
                col.ReadOnly = true;
            }

            dgvLockedAccounts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            LoadLockedAccounts();

        }

        private void searchLock_TextChanged(object sender, EventArgs e)
        {
            LoadLockedAccounts(searchLock.Text.Trim());
        }
        private void LoadLockedAccounts(string search = "")
        {
            dgvLockedAccounts.Rows.Clear();

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = @"
                SELECT u.UserID, u.Username, u.Firstname, u.Lastname, r.RoleName
                FROM Users u INNER JOIN TBL_Roles r ON u.RoleId = r.RoleId
                WHERE u.IsLocked = 1 
                AND (u.Username LIKE @search OR u.Firstname LIKE @search OR u.Lastname LIKE @search)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@search", "%" + search + "%");

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dgvLockedAccounts.Rows.Add(
                                reader["UserID"],
                                reader["Username"],
                                reader["First Name"],
                                reader["Last Name"],
                                reader["Role Name"]
                            );
                        }
                    }
                }
            }
        }

        private void btnUnlock_Click(object sender, EventArgs e)
        {
            if (dgvLockedAccounts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a user to unlock.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int userId = Convert.ToInt32(dgvLockedAccounts.SelectedRows[0].Cells["UserID"].Value);

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = @"UPDATE Users 
                         SET IsLocked = 0, FailedLoginAttempts = 0 
                         WHERE UserID = @userId";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("User account unlocked.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadLockedAccounts();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UnlockAccountsForm_Load(object sender, EventArgs e)
        {

        }
        private void LogInHistorybtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = @"
                        WITH HistoryAccess AS (
                            SELECT 
                                UserID,
                                Username,
                                RoleName,
                                ActivityType,
                                ActivityTime,
                                ROW_NUMBER() OVER (PARTITION BY UserID ORDER BY ActivityTime) AS RowNum
                            FROM UserActivityLog
                        )
                        SELECT 
                            l.UserID,
                            l.Username,
                            l.RoleName,
                            FORMAT(l.ActivityTime, 'yyyy-MM-dd hh:mm:ss tt') AS [Login Time],
                            CASE 
                                WHEN lo.ActivityTime IS NOT NULL THEN FORMAT(lo.ActivityTime, 'yyyy-MM-dd hh:mm:ss tt')
                                ELSE 'Still Logged In'
                            END AS [Logout Time]
                        FROM 
                            (SELECT * FROM HistoryAccess WHERE ActivityType = 'Login') l
                        LEFT JOIN 
                            (SELECT * FROM HistoryAccess WHERE ActivityType = 'Logout') lo
                            ON l.UserID = lo.UserID 
                            AND lo.RowNum = l.RowNum + 1
                        ORDER BY l.ActivityTime DESC";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Form historyForm = new Form
                    {
                        Text = "User Login/Logout History",
                        Width = 1100,
                        Height = 600,
                        StartPosition = FormStartPosition.CenterScreen
                    };

                    DataGridView activityDGV = new DataGridView
                    {
                        Dock = DockStyle.Fill,
                        DataSource = dt,
                        ReadOnly = true,
                        AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                        ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing,
                        ColumnHeadersHeight = 45,
                        SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                        AllowUserToAddRows = false,
                        AllowUserToResizeRows = true,
                        AllowUserToResizeColumns = true,
                        DefaultCellStyle = new DataGridViewCellStyle
                        {
                            Font = new Font("Segoe UI", 10F, FontStyle.Regular),
                            Alignment = DataGridViewContentAlignment.MiddleLeft
                        },
                        AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                    };

                    activityDGV.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 144, 255);
                    activityDGV.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                    activityDGV.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                    activityDGV.EnableHeadersVisualStyles = false;

                    activityDGV.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
                    activityDGV.DefaultCellStyle.SelectionBackColor = Color.FromArgb(70, 130, 180);
                    activityDGV.DefaultCellStyle.SelectionForeColor = Color.White;

                    if (activityDGV.Columns["UserID"] != null)
                        activityDGV.Columns["UserID"].Visible = false;

                    historyForm.Controls.Add(activityDGV);
                    historyForm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching login/logout history: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }


}


