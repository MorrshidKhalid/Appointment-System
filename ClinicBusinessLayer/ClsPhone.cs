using ClinicDALayer;
using static ClinicDALayer.ClsClinicContract.Tables;
using static ClinicDALayer.ClsClinicContract.Phone;
using System.Data;

namespace ClinicBusinessLayer
{
    public class ClsPhone
    {
        
        public enum EnMode { AddNew = 0, Update = 1 };
        public EnMode Mode = EnMode.AddNew;

        // All Getters and Setters.
        public int PhoneID { get; }
        public int PersonID { get; set; }
        public string PhoneNumber { get; set; }


        // Defualt Constructor.
        public ClsPhone()
        {
            this.PersonID = 0;
            this.PhoneNumber = string.Empty;

            Mode = EnMode.AddNew;
        }

        // Private Constructor used to add (Phone) Object to Database.
        private ClsPhone(int PhoneID, int PersonID, string PhoneNumber)
        {
            this.PhoneID = PhoneID;
            this.PersonID = PersonID;
            this.PhoneNumber = PhoneNumber;

            Mode = EnMode.Update;
        }

        
        private bool AddNew()
        {
            return ClsClinicDatabase.AddNewPhoneToDB(this.PersonID, this.PhoneNumber);
        }

        public bool Update()
        {
            return ClsClinicDatabase.UpdatePhone(this.PhoneID, this.PersonID, this.PhoneNumber);
        }

        public static ClsPhone Find(int id)
        {
            // Initial value for Phone Object
            int personID = 0;
            string phoneNumber = string.Empty;

            if (ClsClinicDatabase.GetPhoneByID(id, ref personID, ref phoneNumber))
                return new ClsPhone(id, personID, phoneNumber);

            else return null;
        }

        public static DataTable GetPhones(int id)
        {
            return ClsClinicDatabase.SelectAllPersonPhones(id);
        }
        public bool Save()
        {
            switch (Mode)
            {
                case EnMode.AddNew:
                    if (AddNew())
                    {
                        Mode = EnMode.Update; // Refresh the mode.
                        return true;
                    }
                    else return false;

                case EnMode.Update:
                    return Update();
            }

            return false;
        }
        
        public static bool Delete(int id)
        {
            return ClsClinicDatabase.DeleteByID(id, PHONES, PHONE_COLUMN_PK);
        }

    }
}