using System;
using System.Data;
using ClinicDALayer;
using static ClinicDALayer.ClsClinicContract.Tables;
using static ClinicDALayer.ClsClinicContract.Patient;
using static ClinicDALayer.ClsClinicContract.Person;

namespace ClinicBusinessLayer
{

    public class ClsPatient : ClsPerson
    {

        public int PatientID { get; set; }

        

        // Defual Constractor.
        public ClsPatient() : base() 
        {
            PatientID = 0;
        }


        // Private Constructor used to get (Pateint) ID (PK).
        private ClsPatient(int PatientID)
        {
            this.PatientID = PatientID;
        }


        // Private Constructor used to add (Pateint) Object to Database.
        private ClsPatient
            (
            int id, int personPK,
            string firstName, string midName, string lastName,
            DateTime dateOfBirth, char gender, string email, string address
            ) : base(personPK, firstName, midName, lastName, dateOfBirth, email, gender, address) 
        {
            PatientID = id;
        }

        protected override bool AddNew()
        {
            // Add Person First And Get it's ID.
            int personID = ClsClinicDatabase.AddNewPersonToDB
                (
                FirstName, MidName, LastName,
                DateOfBirth, Email, Gender, Address
                );

            return ClsClinicDatabase.AddNewPateintToDB(personID);
        }

        public bool Delete()
        {
            return 
                ClsClinicDatabase.DeleteByID(PatientID, PATIENTS, PATIENT_COLUMN_PK) && // Must Delete The child first.
                ClsClinicDatabase.DeleteByID(ID, PERSONS, PERSON_COLUMN_PK);    //  Delete The Person.
        }

        protected override bool Update()
        {
            return ClsClinicDatabase.UpdatePatient
                (
                ID,
                FirstName, MidName, LastName,
                DateOfBirth, Email, Gender, Address
                );
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

                    return false;

                case EnMode.Update:
                    return Update();
            }

            return false;
        }

        public static ClsPatient Find(int patientPK)
        {
            
            int PersonPK = 0;
            string firstName = string.Empty,
                   midName = string.Empty,
                   lastName = string.Empty,
                   email = string.Empty, 
                   address = string.Empty;
            DateTime dateOfBirth = DateTime.Now;
            char gender = ' ';


            // Search in Database.
            if (ClsClinicDatabase.GetPatientByID
                (patientPK, ref PersonPK, ref firstName, ref midName, ref lastName,
                ref dateOfBirth, ref email, ref gender, ref address))
                return new ClsPatient
                    (patientPK, PersonPK, firstName, midName, lastName, dateOfBirth, gender, email, address);

            else return new ClsPatient();
        }

        public static ClsPatient Find(string name)
        {
            int id = 0;
            if (ClsClinicDatabase.GetPatientByName(ref id, name))
                return new ClsPatient(id);
            
            else return null;
        }

        public static DataTable GetAllPateints()
        {
            return ClsClinicDatabase.SelectAllPateints();
        }

        public DataTable GetPatientAppointments()
        {
            return ClsClinicDatabase.GetPatienAppointment(PatientID);
        }

        public bool IsExists() => PatientID > 0;

        public static DataTable GetAccountStatement(int id)
        {
            return ClsClinicDatabase.GetPateintAccountStatement(id);
        }

    }
}