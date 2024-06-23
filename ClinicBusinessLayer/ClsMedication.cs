using System;
using System.Data;
using ClinicDALayer;

namespace ClinicBusinessLayer
{
    public class ClsMedication
    {
        public int MedicationID { get; set; }
        public int PrescriptionID { get; set; }
        public string MedicationName { get; set; }
        public int Freq { get; set; }
        public string Dosage { get; set; }
        public DateTime SDate { get; set; }
        public DateTime EDate { get; set; }


        public enum EnMode { AddNew = 0, Update = 1 };
        public EnMode Mode = EnMode.AddNew;


        // Default Constructor.
        public ClsMedication()
        {
            MedicationID = 0;
            PrescriptionID = 0;
            MedicationName = string.Empty;
            Freq = 0;
            Dosage = string.Empty;
            SDate = DateTime.MinValue;
            EDate = DateTime.MinValue;

            Mode = EnMode.AddNew;
        }


        // Private Constructor Used to Add Medication to Database.
        private ClsMedication
            (int MedicationID, int PrescriptionID, 
            string MedicationName, int Freq, string Dosage,
            DateTime SDate, DateTime EDate)
        {
            this.MedicationID = MedicationID;
            this.PrescriptionID = PrescriptionID;
            this.MedicationName = MedicationName;
            this.Freq = Freq;
            this.Dosage = Dosage;
            this.SDate = SDate;
            this.EDate = EDate;

            Mode = EnMode.Update;
        }

        public static ClsMedication Find(int id)
        {
            return null;
        }

        private bool AddNew()
        {
            return ClsClinicDatabase.AddNewMedication
                (PrescriptionID,MedicationName, Freq, Dosage,SDate, EDate);
        }

        private bool Update()
        {
            return false;
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

        public static DataTable GetMedications(int prescriptionID)
        {
            return ClsClinicDatabase.GetMedicationsByFK(prescriptionID);
        }
    }
}
