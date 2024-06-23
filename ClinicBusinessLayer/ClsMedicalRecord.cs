using ClinicDALayer;
using System.Data;
using static ClinicDALayer.ClsClinicContract.Tables;
using static ClinicDALayer.ClsClinicContract.MedicalRecord;

namespace ClinicBusinessLayer
{
    public class ClsMedicalRecord
    {

        
        // Refence  to the Appointment Mode wither the user add or update.
        public enum EnMode { AddNew = 0, Update = 1 };
        public EnMode Mode = EnMode.AddNew;


        public int RecordID { get; set; }
        public string Description { get; set; }
        public string Diagnosis { get; set; }
        public string Note { get; set; }

        public int insertedID;

        // Defualt Constructor.
        public ClsMedicalRecord()
        {
            Description = string.Empty;
            Diagnosis = string.Empty;
            Note = string.Empty;

            Mode = EnMode.AddNew;
        }


        // Private Constructor used to Add a Record to Database.
        private ClsMedicalRecord(int RecordID, string Description, string Diagnosis, string Note)
        {
            this.RecordID = RecordID;
            this.Description = Description;
            this.Diagnosis = Diagnosis;
            this.Note = Note;

            Mode = EnMode.Update;
        }

        private bool AddNew()
        {
            return ClsClinicDatabase.AddNewMedicalRecordToDB(ref insertedID, Description, Diagnosis, Note);
        }
        public bool Update()
        {
            return ClsClinicDatabase.UpdateMedicalRecord(RecordID, Description, Diagnosis, Note);
        }
        public static bool Delete(int id)
        {
            return ClsClinicDatabase.DeleteByID(id, MEDICAL_RECORDS, MEDICAL_RECORD_COLUMN_PK);
        }
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
                        
                    else return false;

                case EnMode.Update:
                    return Update();
            }

            return false;
        }
        public static ClsMedicalRecord Find(int id)
        {
            string des = string.Empty, dio = string.Empty, note = string.Empty;
            if (ClsClinicDatabase.GetMedicalRecordByID
                (id, ref des, ref dio, ref note))
                return new ClsMedicalRecord(id, des, dio, note);

            else return null;
        }
        public static int GetLastID()
        {
            return ClsClinicDatabase.GetLastID(MEDICAL_RECORD_COLUMN_PK, MEDICAL_RECORDS);
        }
        public static DataTable GetAllRecords()
        {
            return ClsClinicDatabase.GetAll(MEDICAL_RECORDS);
        }
        public static bool IsExists(int id)
        {
            return ClsClinicDatabase.IsExists(id, MEDICAL_RECORDS, MEDICAL_RECORD_COLUMN_PK);
        }
    }
}