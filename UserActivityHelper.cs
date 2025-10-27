using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RECOMANAGESYS
{
    internal class UserActivityHelper
    {
        public static void RecordLogin(int userId, string username, string roleName)
        {
            SaveActivity(userId, username, roleName, "Login");
        }

        public static void RecordLogout(int userId, string username, string roleName)
        {
            SaveActivity(userId, username, roleName, "Logout");
        }

        private static void SaveActivity(int userId, string username, string roleName, string activityType)
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string query = @"
                        INSERT INTO UserActivityLog 
                        (UserID, Username, RoleName, ActivityType, ActivityTime)
                        VALUES 
                        (@UserID, @Username, @RoleName, @ActivityType, GETDATE())";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserID", userId);
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@RoleName", roleName);
                        cmd.Parameters.AddWithValue("@ActivityType", activityType);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving {activityType} info: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public static DataTable GetUserLoginLogoutSummary()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string query = @"
                      WITH AccessHistory AS (
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
                            (SELECT * FROM AccessHistory WHERE ActivityType = 'Login') l
                        LEFT JOIN 
                            (SELECT * FROM AccessHistory WHERE ActivityType = 'Logout') lo
                            ON l.UserID = lo.UserID 
                            AND lo.RowNum = l.RowNum + 1
                        ORDER BY l.ActivityTime DESC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving login/logout summary: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dt;
        }
    }
}




