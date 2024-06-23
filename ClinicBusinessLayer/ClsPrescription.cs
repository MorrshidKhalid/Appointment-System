using System.Data;
using ClinicDALayer;
using static ClinicDALayer.ClsClinicContract.Tables;
using static ClinicDALayer.ClsClinicContract.Prescription;

namespace ClinicBusinessLayer
{
    public class ClsPrescription
    {
        public int PrescriptionID { get; set; }
        public int RecordID { get; set; }
        public int InsertedID = 0;


        public enum EnMode { AddNew = 0, Update = 1 };
        public EnMode Mode = EnMode.AddNew;


        // Defual Constructor.
        public ClsPrescription()
        {
            PrescriptionID = 0;
            RecordID = 0;

            Mode = EnMode.AddNew;
        }


        // Private Constructor used to add a new Prescription to DB.
        private ClsPrescription(int PrescriptionID, int RecordID)
        {
            this.PrescriptionID = PrescriptionID;
            this.RecordID = RecordID;

            Mode = EnMode.Update;
        }

        private bool AddNew() => ClsClinicDatabase.AddNewPrescriptionToDB(RecordID, ref InsertedID);
        public bool Update()
        {
            return false;
            //return ClsClinicDatabase.UpdatePrescription
            //    (PrescriptionID, RecordID, MedicationName, Freq, Dosage, StartDate, EndDate);
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

        public static ClsPrescription Find(int id)
        {
            int prescriptionID = 0;
            if (ClsClinicDatabase.GetPrescriptionByFK(ref prescriptionID, id))
                return new ClsPrescription(prescriptionID, id);

            else return null;
        }

        public static bool Delete(int id) => ClsClinicDatabase.DeleteByID(id, PRESCRIPTIONS, PRESCRIPTION_COLUMN_PK);
        public static DataTable GetAllPrescription() => ClsClinicDatabase.GetAll(PRESCRIPTIONS);
    }
}