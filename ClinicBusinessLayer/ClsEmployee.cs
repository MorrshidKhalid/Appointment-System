using System;
using System.Data;
using ClinicDALayer;
using static ClinicDALayer.ClsClinicContract.Tables;
using static ClinicDALayer.ClsClinicContract.Employee;
using static ClinicDALayer.ClsClinicContract.Person;

namespace ClinicBusinessLayer
{
    public class ClsEmployee : ClsPerson
    {
        public int EmployeeID { get; set; }
        public int PersonID { get; set; }
        public int DepartmentID { get; set; }

        // Defualt Constructor.
        public ClsEmployee() : base() { }

        // Private Constructor used to get (Doctor) ID (PK).
        private ClsEmployee(int EmployeeID)
        {
            this.EmployeeID = EmployeeID;
        }

        // Private Constructor used to add (Doctor) Object to Database.
        private ClsEmployee
            (
            int EmployeeID, int PersonID,
            string firstName, string midName, string lastName,
            DateTime dateOfBirth, char gender, string email, string address,
            int DepartmentID
            ) : base(PersonID, firstName, midName, lastName, dateOfBirth, email, gender, address)
        {
            this.EmployeeID = EmployeeID;
            this.DepartmentID = DepartmentID;
        }


        protected override bool AddNew()
        {

            // Add a New Person First and Get It's ID.
            PersonID = ClsClinicDatabase.AddNewPersonToDB
                (
                FirstName, MidName, LastName,
                DateOfBirth, Email, Gender, Address
                );

            return ClsClinicDatabase.AddNewEmployeeToDB(PersonID, DepartmentID);
        }

        public static ClsEmployee Find(int id)
        {
            // Set Initial Employee values.
            int PersonPK = 0, dep_ID = 0; ;
            string firstName = string.Empty,
                   midName = string.Empty,
                   lastName = string.Empty,
                   email = string.Empty,
                   address = string.Empty;
                   
            DateTime dateOfBirth = DateTime.Now;
            char gender = ' ';

            
            // Search in Database.
            if (ClsClinicDatabase.GetEmployeeByID
                (
                id, ref PersonPK,
                ref firstName, ref midName, ref lastName,
                ref dateOfBirth, ref email, ref gender, ref address,
                ref dep_ID
                ))
                return 
                    new ClsEmployee(id, PersonPK, firstName, midName, lastName, dateOfBirth, gender, email, address, dep_ID);

            else return null;
        }

        public static ClsEmployee Find(string name)
        {
            int id = 0;
            if (ClsClinicDatabase.GetEmployeeByName(ref id, name))
                return new ClsEmployee(id);

            else return null;
        }

        protected override bool Update()
        {
            return ClsClinicDatabase.UpdateEmployee
                (
                PersonID,
                FirstName, MidName, LastName,
                DateOfBirth, Email, Gender, Address, 
                DepartmentID, EmployeeID
                );
        }

        public bool Delete()
        {
            return
                ClsClinicDatabase.DeleteByID(EmployeeID, EMPLOYEES, EMPLOYEE_COLUMN_PK) && // Must Delete The child first.
                ClsClinicDatabase.DeleteByID(PersonID, PERSONS, PERSON_COLUMN_PK);    //  Delete The Psrent.
        }

        public override bool Save()
        {
            switch (Mode)
            {
                case EnMode.AddNew:
                    if (AddNew())
                    {
                        Mode = EnMode.Update;
                        return true;
                    }
                    else return false;

                case EnMode.Update:
                    return Update();
            }

            return false;
        }

        public static DataTable GetAllEmployees()
        {
            return ClsClinicDatabase.SelectAllEmployees();
        }

        public static DataTable GelAllDoctors()
        {
            return ClsClinicDatabase.SelectAllDoctors();
        }

        public static bool IsExists(int id)
        {
            return ClsClinicDatabase.IsExists(id, EMPLOYEES, EMPLOYEE_COLUMN_PK);
        }
    }
}
