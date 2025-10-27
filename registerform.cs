using Microsoft.VisualBasic.ApplicationServices;
using RECOMANAGESYS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static RECOMANAGESYS.loginform;


namespace RECOMANAGESYS
{
    public partial class registerform : Form
    {
        private const int MinimumPasswordLength = 8;
        private const int ContactNumberLength = 11;
        private byte[] profilePictureData;

        public event EventHandler RegistrationSuccess;

        public registerform()
        {
            InitializeComponent();
            txtPass.TextChanged += (s, e) => ValidatePasswordRules(txtPass.Text); this.AutoScaleMode = AutoScaleMode.Dpi;
            txtContactnum.KeyPress += new KeyPressEventHandler(txtContactnum_KeyPress);
            InitializeNewControls();
        }

        private void InitializeNewControls()
        {
            if (DTPProfile != null)
                DTPProfile.Value = DateTime.Now;

            if (pbProfilePic != null)
            {
                pbProfilePic.SizeMode = PictureBoxSizeMode.Zoom;
                pbProfilePic.BorderStyle = BorderStyle.FixedSingle;
            }
        }
        private void registerform_Load(object sender, EventArgs e)
        {

            LoadAvailableRoles();
        }
        private void LoadAvailableRoles()
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = @"
                SELECT r.RoleId, r.RoleName
                FROM TBL_Roles r
                LEFT JOIN Users u ON r.RoleId = u.RoleId AND u.IsActive = 1
                WHERE (u.UserID IS NULL OR r.RoleName = 'Member')";

                    if (!CurrentUser.Role.Equals("Developer", StringComparison.OrdinalIgnoreCase))
                    {
                        query += " AND r.RoleName <> 'Developer'";
                    }
                    query += " ORDER BY r.RoleName";

                    using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        cmbRole.DataSource = dt;
                        cmbRole.DisplayMember = "RoleName";
                        cmbRole.ValueMember = "RoleId";
                        cmbRole.SelectedIndex = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading roles: {ex.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnregister_Click(object sender, EventArgs e)
        {
            if (!ValidateRegistrationInputs())
                return;

            try
            {
                RegisterNewUser();
                MessageBox.Show("Registration successful! User has been added to the system.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                RegistrationSuccess?.Invoke(this, EventArgs.Empty);

                ClearForm();
                this.Hide();
            }
            catch (InvalidOperationException ioe)
            {
                MessageBox.Show(ioe.Message, "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Registration Error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private bool ValidateRegistrationInputs()
        {
            // Username
            string username = txtUsername.Text.Trim();
            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Username is required and cannot be just spaces.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return false;
            }
            if (!Regex.IsMatch(username, @"^[a-zA-Z0-9_]+$"))
            {
                MessageBox.Show("Username must contain only letters, numbers, and underscores.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return false;
            }
            if (UsernameExists(username))
            {
                MessageBox.Show("Username already exists. Please choose a different one.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return false;
            }

            // Passwords
            string pass = txtPass.Text;
            string confirm = txtConfirmpass.Text;

            if (string.IsNullOrWhiteSpace(pass))
            {
                MessageBox.Show("Password is required and cannot be just spaces.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPass.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(confirm))
            {
                MessageBox.Show("Please confirm your password. It cannot be blank or just spaces.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirmpass.Focus();
                return false;
            }

            if (!Regex.IsMatch(pass, @"[a-zA-Z]") ||
                !Regex.IsMatch(pass, @"[A-Z]") ||
                !Regex.IsMatch(pass, @"[0-9]") ||
                pass.Length < MinimumPasswordLength)
            {
                MessageBox.Show("Password does not meet complexity requirements:\n" +
                    "• At least one letter\n" +
                    "• At least one uppercase letter\n" +
                    "• At least one number\n" +
                    $"• At least {MinimumPasswordLength} characters",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPass.Focus();
                return false;
            }
            if (pass != confirm)
            {
                MessageBox.Show("Passwords do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirmpass.Focus();
                return false;
            }

            // Names
            if (string.IsNullOrWhiteSpace(txtFname.Text))
            {
                MessageBox.Show("First name is required and cannot be just spaces.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFname.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtLname.Text))
            {
                MessageBox.Show("Last name is required and cannot be just spaces.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLname.Focus();
                return false;
            }

            // Emails
            string email = txtEmail.Text.Trim();
            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Personal email is required and cannot be just spaces.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }
            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Please enter a valid personal email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }

            string loginEmail = LoginEmailtxt.Text.Trim();
            if (string.IsNullOrWhiteSpace(loginEmail))
            {
                MessageBox.Show("HOA email is required and cannot be just spaces.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LoginEmailtxt.Focus();
                return false;
            }
            if (!Regex.IsMatch(loginEmail, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Please enter a valid HOA email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LoginEmailtxt.Focus();
                return false;
            }

            // Contact number
            string contact = txtContactnum.Text.Trim();
            if (string.IsNullOrWhiteSpace(contact))
            {
                MessageBox.Show("Contact number is required and cannot be just spaces.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContactnum.Focus();
                return false;
            }
            if (!Regex.IsMatch(contact, @"^\d{" + ContactNumberLength + "}$"))
            {
                MessageBox.Show($"Contact number must be exactly {ContactNumberLength} digits.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContactnum.Focus();
                return false;
            }

            // *** NEW: Address Validation ***
            string address = txtAddress.Text.Trim();
            if (string.IsNullOrWhiteSpace(address))
            {
                MessageBox.Show("Address is required and cannot be just spaces.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAddress.Focus();
                return false;
            }

            if (address.Length > 255)
            {
                MessageBox.Show("Address is too long (maximum 255 characters).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAddress.Focus();
                return false;
            }
            // *** END: Address Validation ***


            // Role
            if (cmbRole.SelectedIndex == -1 || cmbRole.SelectedValue == null)
            {
                MessageBox.Show("Please select a role for this user.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbRole.DroppedDown = true;
                return false;
            }

            // MemberSince / Date
            if (DTPProfile != null)
            {
                DateTime dt = DTPProfile.Value;
                if (dt > DateTime.Now.AddMonths(1))
                {
                    MessageBox.Show("Member since date is invalid.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    DTPProfile.Focus();
                    return false;
                }
            }

            //Profile picture validations
            if (profilePictureData == null)
            {
                MessageBox.Show("Profile picture is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                if (profilePictureData.Length > 5 * 1024 * 1024)
                {
                    MessageBox.Show("Selected profile picture is too large (max 5MB).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                bool looksLikeImage = false;
                if (profilePictureData.Length >= 4)
                {
                    // JPEG
                    if (profilePictureData[0] == 0xFF && profilePictureData[1] == 0xD8) looksLikeImage = true;
                    // PNG
                    if (profilePictureData[0] == 0x89 && profilePictureData[1] == 0x50 && profilePictureData[2] == 0x4E && profilePictureData[3] == 0x47) looksLikeImage = true;
                    // GIF 'GIF8'
                    if (profilePictureData[0] == 'G' && profilePictureData[1] == 'I') looksLikeImage = true;
                }
                if (!looksLikeImage)
                {
                    MessageBox.Show("Selected profile picture is not a supported image.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            return true;
        }




        private bool UsernameExists(string username)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Users WHERE Username = @username AND (IsActive = 1 OR IsActive IS NULL)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        private void RegisterNewUser()
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();

                string query = @"
            INSERT INTO Users 
            (Username, PasswordHash, Firstname, Lastname, MiddleName, RoleId, 
             CompleteAddress, ContactNumber, EmailAddress, LoginEmail, MemberSince, 
             ProfilePicture, IsActive) 
            VALUES 
            (@username, @password_hash, @firstName, @lastName, @middleName, 
             @roleId, @address, @contactNumber, @email, @LoginEmail, @memberSince, 
              @profilePicture, @isActive)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text.Trim());
                    cmd.Parameters.AddWithValue("@password_hash", BCrypt.Net.BCrypt.HashPassword(txtPass.Text));
                    cmd.Parameters.AddWithValue("@firstName", txtFname.Text.Trim());
                    cmd.Parameters.AddWithValue("@lastName", txtLname.Text.Trim());
                    cmd.Parameters.Add("@middleName", SqlDbType.NVarChar).Value =
                        string.IsNullOrWhiteSpace(txtMname.Text) ? (object)DBNull.Value : txtMname.Text.Trim();

                    if (cmbRole.SelectedValue == null || !int.TryParse(cmbRole.SelectedValue.ToString(), out int roleId))
                    {
                        throw new InvalidOperationException("Selected role is invalid. Please choose a role.");
                    }
                    cmd.Parameters.AddWithValue("@roleId", roleId);

                    // *** UPDATED: Removed DBNull check since address is now required ***
                    cmd.Parameters.AddWithValue("@address", txtAddress.Text.Trim());
                    // *** END UPDATE ***

                    cmd.Parameters.AddWithValue("@contactNumber", txtContactnum.Text.Trim());
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                    cmd.Parameters.AddWithValue("@LoginEmail", LoginEmailtxt.Text.Trim());

                    cmd.Parameters.AddWithValue("@memberSince", DTPProfile?.Value ?? DateTime.Now);

                    cmd.Parameters.Add("@profilePicture", SqlDbType.VarBinary).Value =
                        (object)profilePictureData ?? DBNull.Value;

                    cmd.Parameters.AddWithValue("@isActive", true);

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (SqlException sqlex)
                    {
                        if (sqlex.Number == 2627 || sqlex.Number == 2601)
                        {
                            throw new InvalidOperationException("A user with the same username already exists. Please choose a different username.");
                        }
                        else
                        {
                            throw new InvalidOperationException("Database error during registration: " + sqlex.Message);
                        }
                    }
                }
            }
        }


        private void addpicbtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                ofd.Title = "Select Profile Picture";
                ofd.Multiselect = false;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        FileInfo fileInfo = new FileInfo(ofd.FileName);
                        if (fileInfo.Length > 5 * 1024 * 1024)
                        {
                            MessageBox.Show("Image file size must be less than 5MB.", "File Too Large", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            profilePictureData = null;
                            return;
                        }

                        string ext = fileInfo.Extension.ToLowerInvariant();
                        if (ext != ".jpg" && ext != ".jpeg" && ext != ".png" && ext != ".bmp" && ext != ".gif")
                        {
                            MessageBox.Show("Unsupported image format. Use JPG, PNG, BMP, or GIF.", "Invalid Format", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            profilePictureData = null;
                            return;
                        }

                        using (var originalImage = Image.FromFile(ofd.FileName))
                        {
                            var resized = ResizeImage(originalImage, 150, 150);

                            if (pbProfilePic != null)
                            {
                                pbProfilePic.Image?.Dispose();
                                pbProfilePic.Image = new Bitmap(resized);
                            }

                            using (var ms = new MemoryStream())
                            {
                                resized.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                                profilePictureData = ms.ToArray();
                            }

                            resized.Dispose();
                        }
                    }
                    catch (OutOfMemoryException)
                    {
                        MessageBox.Show("Selected file is not a valid image.", "Invalid Image", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        profilePictureData = null;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        profilePictureData = null;
                    }
                }
            }
        }


        private Image ResizeImage(Image image, int width, int height)
        {
            var resized = new Bitmap(width, height);
            using (var graphics = Graphics.FromImage(resized))
            {
                graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                graphics.DrawImage(image, 0, 0, width, height);
            }
            return resized;
        }

        private void ClearForm()
        {
            txtUsername.Clear();
            txtPass.Clear();
            txtConfirmpass.Clear();
            txtFname.Clear();
            txtLname.Clear();
            txtMname.Clear();
            txtEmail.Clear();
            LoginEmailtxt.Clear();
            txtContactnum.Clear();
            txtAddress.Clear();

            if (DTPProfile != null)
                DTPProfile.Value = DateTime.Now;

            if (pbProfilePic != null)
            {
                pbProfilePic.Image?.Dispose();
                pbProfilePic.Image = null;
            }

            profilePictureData = null;
            cmbRole.SelectedIndex = -1;

            txtUsername.Focus();
        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to clear all fields?", "Confirm Clear",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ClearForm();
                this.Close();
            }
        }

        private void label5_Click(object sender, EventArgs e) { }
        private void DTPProfile_ValueChanged(object sender, EventArgs e) { }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
        private void ValidatePasswordRules(string password)
        {
            bool hasLetter = Regex.IsMatch(password, @"[a-zA-Z]");
            bool hasUpper = Regex.IsMatch(password, @"[A-Z]");
            bool hasNumber = Regex.IsMatch(password, @"[0-9]");
            bool hasLength = password.Length >= MinimumPasswordLength;

            UpdateRuleLabel(lblRuleLetter, hasLetter, "At least one letter");
            UpdateRuleLabel(lblRuleUpper, hasUpper, "At least one capital letter");
            UpdateRuleLabel(lblRuleNumber, hasNumber, "At least one number");
            UpdateRuleLabel(lblRuleLength, hasLength, $"Be at least {MinimumPasswordLength} characters");
        }
        private void UpdateRuleLabel(Label label, bool isValid, string description)
        {
            if (isValid)
            {
                label.Text = $"✓ {description}";
                label.ForeColor = Color.Green;
            }
            else
            {
                label.Text = $"✗ {description}";
                label.ForeColor = Color.Red;
            }
        }
        private void txtContactnum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

        private void lblRuleLength_Click(object sender, EventArgs e)
        {

        }
    }
}
/*
--ROLES
CREATE TABLE TBL_Roles (
    RoleId INT PRIMARY KEY IDENTITY(1,1),
    RoleName NVARCHAR(50) NOT NULL UNIQUE
);

--PERMISSIONS
CREATE TABLE TBL_Permissions (
    PermissionId INT PRIMARY KEY IDENTITY(1,1),
    PermissionName NVARCHAR(100) NOT NULL UNIQUE
);

--ROLE - PERMISSIONS JUNCTION
CREATE TABLE TBL_RolePermissions (
    RoleId INT NOT NULL,
    PermissionId INT NOT NULL,
    PRIMARY KEY (RoleId, PermissionId),
    FOREIGN KEY (RoleId) REFERENCES TBL_Roles(RoleId),
    FOREIGN KEY (PermissionId) REFERENCES TBL_Permissions(PermissionId)
);

--USERS
CREATE TABLE Users (
    UserID INT PRIMARY KEY IDENTITY(1,1),
    Username NVARCHAR(50) NOT NULL UNIQUE,
    PasswordHash NVARCHAR(255) NOT NULL,
    Firstname NVARCHAR(50) NOT NULL,
    Lastname NVARCHAR(50) NOT NULL,
    MiddleName NVARCHAR(50) NULL,
    RoleId INT NOT NULL,
    CompleteAddress NVARCHAR(255) NULL,
    ContactNumber NVARCHAR(20) NULL,
    EmailAddress NVARCHAR(100) NULL,
    MemberSince DATE NULL,
    ProfilePicture VARBINARY(MAX) NULL,
    CreatedDate DATETIME DEFAULT GETDATE(),
    IsActive BIT DEFAULT 1,
    FailedLoginAttempts INT DEFAULT 0,  
    IsLocked BIT DEFAULT 0,  
    IsEmailVerified BIT DEFAULT 0 ,
    LoginEmail  NVARCHAR(100) NULL,
    LastLoginTime DATETIME NULL,
    LastLogoutTime DATETIME NULL,
    FOREIGN KEY (RoleId) REFERENCES TBL_Roles(RoleId)
);

--DEFAULT ROLES(including Developer)
INSERT INTO TBL_Roles (RoleName) VALUES
('President'),
('Vice President'),
('Secretary'),
('Treasurer'),
('Auditor'),
('PRO'),
('Member'),
('Developer');

--DEFAULT PERMISSIONS
INSERT INTO TBL_Permissions (PermissionName) VALUES
('CanRegisterAccount'),
('CanAccessProfiles'),
('CanAccessVisitorLog'),
('CanAccessMonthlyDues'),
('CanAccessScheduling'),
('CanAccessAnnouncements'),
('CanAccessDocuments'),
('CanEditMonthlyDues'),
('CanPostAnnouncements');

--PERMISSIONS ASSIGNMENT
-- President(all permissions)
INSERT INTO TBL_RolePermissions (RoleId, PermissionId)
SELECT (SELECT RoleId FROM TBL_Roles WHERE RoleName = 'President'), PermissionId 
FROM TBL_Permissions;

--Vice President(all permissions)
INSERT INTO TBL_RolePermissions (RoleId, PermissionId)
SELECT (SELECT RoleId FROM TBL_Roles WHERE RoleName = 'Vice President'), PermissionId 
FROM TBL_Permissions;

--Secretary(all permissions)
INSERT INTO TBL_RolePermissions (RoleId, PermissionId)
SELECT (SELECT RoleId FROM TBL_Roles WHERE RoleName = 'Secretary'), PermissionId 
FROM TBL_Permissions;

--Treasurer(subset)
INSERT INTO TBL_RolePermissions (RoleId, PermissionId)
SELECT (SELECT RoleId FROM TBL_Roles WHERE RoleName = 'Treasurer'), PermissionId 
FROM TBL_Permissions 
WHERE PermissionName IN (
    'CanAccessMonthlyDues',
    'CanEditMonthlyDues',
    'CanAccessScheduling',
    'CanAccessAnnouncements'
);

--Auditor(subset)
INSERT INTO TBL_RolePermissions (RoleId, PermissionId)
SELECT (SELECT RoleId FROM TBL_Roles WHERE RoleName = 'Auditor'), PermissionId 
FROM TBL_Permissions 
WHERE PermissionName IN (
    'CanAccessMonthlyDues',
    'CanEditMonthlyDues',
    'CanAccessAnnouncements'
);

--PRO(subset)
INSERT INTO TBL_RolePermissions (RoleId, PermissionId)
SELECT (SELECT RoleId FROM TBL_Roles WHERE RoleName = 'PRO'), PermissionId 
FROM TBL_Permissions 
WHERE PermissionName IN (
    'CanAccessVisitorLog',
    'CanAccessScheduling',
    'CanAccessAnnouncements',
    'CanPostAnnouncements'
);

--Developer(ALL permissions)
INSERT INTO TBL_RolePermissions (RoleId, PermissionId)
SELECT (SELECT RoleId FROM TBL_Roles WHERE RoleName = 'Developer'), PermissionId 
FROM TBL_Permissions;

--DEV ACCOUNT(plain password for your C# bypass) tied to Developer role
INSERT INTO Users
(Username, PasswordHash, Firstname, Lastname, RoleId, IsActive)
VALUES
('dev account', 'developer', 'Dev', 'Account',
 (SELECT RoleId FROM TBL_Roles WHERE RoleName = 'Developer'), 1) ;

--HOMEOWNERS
CREATE TABLE Homeowners (
    HomeownerId INT PRIMARY KEY IDENTITY(1,1),
    FullName NVARCHAR(100) NOT NULL,
    Address NVARCHAR(255) NOT NULL,
    ContactNumber VARCHAR(20),
    Status NVARCHAR(20) NOT NULL DEFAULT 'Active'
);

-- Create Announcements with expiration date
CREATE TABLE Announcements (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Title NVARCHAR(200) NOT NULL,
    Message NVARCHAR(MAX) NOT NULL,
    DatePosted DATETIME DEFAULT GETDATE(),
    ExpirationDate DATETIME NULL,
    IsImportant BIT DEFAULT 0
);
GO

-- Stored procedure to delete expired announcements
CREATE OR ALTER PROCEDURE DeleteExpiredAnnouncements
AS
BEGIN
    DELETE FROM Announcements
    WHERE ExpirationDate IS NOT NULL AND ExpirationDate < GETDATE();
END;
GO

--VISITORS LOG
CREATE TABLE TBL_VisitorsLog(
    VisitorID INT PRIMARY KEY IDENTITY(1, 1),
    VisitorName VARCHAR(100) NOT NULL,
    ContactNumber VARCHAR(20),
    Date DATETIME NOT NULL DEFAULT GETDATE(),
    VisitPurpose VARCHAR(200),
    TimeIn DATETIME NOT NULL,
    TimeOut DATETIME NULL
);

-- Docu repo SQL storage
CREATE TABLE DesktopItems (
    ItemId INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    IsFolder BIT NOT NULL,
    ParentId INT NULL,
    IconType NVARCHAR(50) NULL,
    FilePath NVARCHAR(500) NULL,
    CreatedAt DATETIME DEFAULT GETDATE(),   
    ModifiedAt DATETIME DEFAULT GETDATE(),   
    FOREIGN KEY (ParentId) REFERENCES DesktopItems(ItemId)
);

CREATE TABLE Events (
    EventId INT IDENTITY(1,1) PRIMARY KEY,
    EventName NVARCHAR(255) NOT NULL,
    EventDate DATE NOT NULL,
    Venue NVARCHAR(255) NOT NULL,
    EventTime TIME NOT NULL,
    StartDateTime DATETIME NULL,
    EndDateTime DATETIME NULL,
    ApprovedBy NVARCHAR(100) NULL
);

CREATE TABLE GarbageCollectionSchedules (
    ScheduleID INT PRIMARY KEY IDENTITY(1,1),
    TruckCompany NVARCHAR(100) NOT NULL,
    CollectionDay NVARCHAR(50) NOT NULL,
    CollectionTime TIME NOT NULL,
    Status BIT NOT NULL DEFAULT 1, 
    CreatedDate DATETIME DEFAULT GETDATE(),
    LastModified DATETIME DEFAULT GETDATE()
);

CREATE TABLE Residents (
    ResidentID INT IDENTITY(1,1) PRIMARY KEY,    
    HomeownerID INT NOT NULL,                     
    FirstName NVARCHAR(50) NOT NULL,
    MiddleName NVARCHAR(50),
    LastName NVARCHAR(50) NOT NULL,
    HomeAddress NVARCHAR(255) NOT NULL,
    ContactNumber NVARCHAR(15) NOT NULL,
    EmailAddress NVARCHAR(100),
    EmergencyContactPerson NVARCHAR(100),
    EmergencyContactNumber NVARCHAR(15),
    ResidencyType NVARCHAR(50) NOT NULL CHECK (ResidencyType IN ('Owner', 'Tenant', 'Caretaker')),
    IsActive BIT DEFAULT 1,
    InactiveDate DATE NULL,
    DateRegistered DATETIME DEFAULT GETDATE(),
    INDEX IX_Residents_HomeownerID (HomeownerID),
    INDEX IX_Residents_ResidencyType (ResidencyType),
    INDEX IX_Residents_IsActive (IsActive)
);

CREATE TABLE TBL_Units (
    UnitID INT IDENTITY(1,1) PRIMARY KEY,
    UnitNumber NVARCHAR(20) NOT NULL,
    Block NVARCHAR(10) NOT NULL,
    UnitType NVARCHAR(50) NOT NULL CHECK (UnitType IN ('Town house', 'Single Attach', 'Single Detach', 'Apartment')),
    TotalRooms INT NULL,
    AvailableRooms INT NULL,
    IsOccupied BIT NOT NULL DEFAULT 0,
    DateCreated DATETIME DEFAULT GETDATE(),
    CONSTRAINT UQ_UnitNumber_Block UNIQUE (UnitNumber, Block),
    CONSTRAINT CK_Rooms CHECK (AvailableRooms IS NULL OR TotalRooms IS NULL OR AvailableRooms <= TotalRooms),
    CONSTRAINT CK_Apartment_Rooms CHECK (
        (UnitType = 'Apartment' AND TotalRooms IS NOT NULL AND AvailableRooms IS NOT NULL) OR
        (UnitType != 'Apartment' AND TotalRooms IS NULL AND AvailableRooms IS NULL)
    ),
    INDEX IX_Units_Type (UnitType),
    INDEX IX_Units_Occupied (IsOccupied)
);

--- new HomeownerUnits table

CREATE TABLE HomeownerUnits (
    HomeownerUnitID INT IDENTITY(1,1) PRIMARY KEY,
    ResidentID INT NOT NULL,
    UnitID INT NOT NULL,
    DateOfOwnership DATETIME NULL,
    DateOfOwnershipEnd DATETIME NULL,
    ApprovedByUserID INT NULL,
    IsCurrent BIT DEFAULT 1,
    DateCreated DATETIME DEFAULT GETDATE(),
    CONSTRAINT FK_HomeownerUnits_Resident FOREIGN KEY (ResidentID) REFERENCES Residents(ResidentID),
    CONSTRAINT FK_HomeownerUnits_Unit FOREIGN KEY (UnitID) REFERENCES TBL_Units(UnitID),
    CONSTRAINT FK_HomeownerUnits_User FOREIGN KEY (ApprovedByUserID) REFERENCES Users(UserID),
    
    -- Flawed constraint 'UQ_Active_Resident_Unit' was removed.
    -- Laggy index 'IX_HomeownerUnits_Current' was removed.

    INDEX IX_HomeownerUnits_Resident (ResidentID),
    INDEX IX_HomeownerUnits_Unit (UnitID)
);
GO
CREATE UNIQUE INDEX UQ_Active_Resident_Unit
ON HomeownerUnits(ResidentID, UnitID)
WHERE IsCurrent = 1;
GO

-- MonthlyDues table
CREATE TABLE MonthlyDues(
    DueId INT IDENTITY(1,1) PRIMARY KEY,
    ResidentID INT NOT NULL,
    UnitID INT NOT NULL,
    PaymentDate DATE NOT NULL,
    AmountPaid DECIMAL(10,2) NOT NULL,
    DueRate DECIMAL(10,2) NOT NULL,
    MonthCovered VARCHAR(20) NOT NULL,
    Remarks NVARCHAR(255) NULL,
    PaidByResidencyType NVARCHAR(50) NULL,
    PaidByResidentName NVARCHAR(150) NULL,
    DateRecorded DATETIME DEFAULT GETDATE(),
    ProcessedByUserID INT NULL,
    CONSTRAINT FK_MonthlyDues_Resident FOREIGN KEY (ResidentID) REFERENCES Residents(ResidentID),
    CONSTRAINT FK_MonthlyDues_Unit FOREIGN KEY (UnitID) REFERENCES TBL_Units(UnitID),
    CONSTRAINT FK_MonthlyDues_User FOREIGN KEY (ProcessedByUserID) REFERENCES Users(UserID),

    INDEX IX_MonthlyDues_Resident (ResidentID),
    INDEX IX_MonthlyDues_Unit (UnitID),
    INDEX IX_MonthlyDues_Month (MonthCovered),
    INDEX IX_MonthlyDues_Date (PaymentDate)
);

CREATE TABLE PasswordResetTokens (
    TokenId UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
    UserId INT NOT NULL,
    Token NVARCHAR(100) NOT NULL,
    Expiry DATETIME NOT NULL,
    IsUsed BIT DEFAULT 0,
    FOREIGN KEY (UserId) REFERENCES Users(UserId)
);

CREATE TABLE UserActivityLog (
    LogID INT IDENTITY(1,1) PRIMARY KEY,
    UserID INT NOT NULL,
    Username NVARCHAR(100) NOT NULL,
    RoleName NVARCHAR(50) NOT NULL,
    ActivityType NVARCHAR(20) NOT NULL,
    ActivityTime DATETIME NOT NULL DEFAULT GETDATE()
); 

-- UPDATED SQL --
*/
