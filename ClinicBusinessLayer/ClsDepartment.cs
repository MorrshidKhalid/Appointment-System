using System;
using System.Data;
using ClinicDALayer;

namespace ClinicBusinessLayer
{
    public class ClsDepartment
    {

        public int DepartmentID { get; set; }
        public string DepName { get; set; }
        public string Specialization { get; set; }


        // Refers to the Department Mode to Track the correct operation that will perform.
        public enum EnMode { AddNew = 0, Update = 1 };
        public EnMode Mode = EnMode.AddNew;


        // Defualt Constructor.
        public ClsDepartment()
        {
            DepartmentID = 0;
            DepName = string.Empty;
            Specialization = string.Empty;

            Mode = EnMode.AddNew;
        }

        // Private Constructor used to Det Department ID.
        private ClsDepartment(int DepartmentID)
        {
            this.DepartmentID = DepartmentID;
            Mode = EnMode.Update;
        }


        // Private Constructor used to add a Department to Database.
        private ClsDepartment(int DepartmentID, string DepName, string Specialization)
        {
            this.DepartmentID = DepartmentID;
            this.DepName = DepName;
            this.Specialization = Specialization;

            Mode = EnMode.Update;
        }

        public static DataTable GetAllDepartments()
        {
            return ClsClinicDatabase.SelectAllDepartments();
        }

        public static ClsDepartment Find(int id)
        {
            string dep = string.Empty, spe = string.Empty;
            if (ClsClinicDatabase.GetDepartmentByID(id, ref dep, ref spe))
                return new ClsDepartment(id, dep, spe);

            else return null;
        }

        public static ClsDepartment Find(string depName, string specialization)
        {
            int id = 0;
            if (ClsClinicDatabase.GetDepIDByNameAndSpecialization
                (ref id, depName, specialization))
                return new ClsDepartment(id);

            else return null;
        }

        private bool AddNew() => ClsClinicDatabase.AddNewDepartmentToDB(DepName, Specialization);

        private bool Update() => ClsClinicDatabase.UpdateDepartment(DepartmentID, DepName, Specialization);

        public bool Delete() => ClsClinicDatabase.DeleteDepartment(DepartmentID);
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
    }
}
