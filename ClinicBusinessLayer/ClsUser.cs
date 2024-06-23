using System.Data;
using ClinicDALayer;

namespace ClinicBusinessLayer
{
    public class ClsUser
    {
        public int UserID { get; set; }
        public int EmployeeID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public int Permission { get; set; }


        public enum EnMode { AddNew = 0, Update = 1 };
        public EnMode Mode = EnMode.AddNew;


        // Defualt Constructor.
        public ClsUser() : base()
        {
            UserID = 0;
            EmployeeID = 0;
            UserName = string.Empty;
            Password = string.Empty;
            IsActive = false;
            Permission = 0;

            Mode = EnMode.AddNew;
        }


        // Private Constructo used to add user to Database.
        private ClsUser
            (
            int UserID, int EmployeeID, string UserName, string Password, bool IsActive, int Permission
            )
        {
            this.UserID = UserID;
            this.EmployeeID = EmployeeID;
            this.UserName = UserName;
            this.Password = Password;
            this.IsActive = IsActive;
            this.Permission = Permission;

            Mode = EnMode.Update;
        }

        
        public static ClsUser Find(int id)
        {
            int employeeID = 0, permission = 0;
            string userName = string.Empty, password = string.Empty;
            bool isActive = false;

            if (ClsClinicDatabase.GetUserByID
                (id, ref employeeID,ref userName, ref password, ref isActive, ref permission))
                return new ClsUser(id, employeeID, userName, password, isActive, permission);

            else return null;
        }

        public static ClsUser Find(string user, string pass)
        {
            int userID = 0, employeeID = 0, permission = 0;
            bool isActive = false;

            if (ClsClinicDatabase.GetUserByUserAndPassword(ref userID, ref employeeID, user, pass, ref isActive, ref permission))
                return new ClsUser(userID, employeeID, user, pass, isActive, permission);

            else return null;
        }

        public static DataTable AllUsers() => ClsClinicDatabase.GetAllUsers();

        private bool AddNew() => ClsClinicDatabase.AddNewUserToDB(EmployeeID, UserName, Password, IsActive, Permission);

        private bool Update() => ClsClinicDatabase.UpdateUserInfo(UserID, UserName, Password, Permission, IsActive);

        public bool DeleteUser() => ClsClinicDatabase.DeleteUserByID(UserID);

        public bool Save()
        {
            switch (Mode)
            {
                case EnMode.AddNew:
                    if (AddNew())
                    {
                        Mode = EnMode.Update;
                        return true;
                    }

                    return false;

                case EnMode.Update:
                    return Update();
            }

            return false;
        }

        public bool IsUserHasPermission(int option)
        {
            if (Permission == -1)
                return true;

            return (Permission & option) == option;
        }
    }   
}