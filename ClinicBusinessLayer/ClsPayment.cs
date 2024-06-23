using System;
using System.Data;
using ClinicDALayer;
using static ClinicDALayer.ClsClinicContract.Tables;
using static ClinicDALayer.ClsClinicContract.Payment;

namespace ClinicBusinessLayer
{
    public class ClsPayment
    {
        // Refers to the Payment Mode to Track the correct operation that will perform.

        public enum EnMode { AddNew = 0, Update = 1 };
        public EnMode Mode = EnMode.AddNew;

        
        public int PaymentID { get; set; }
        public int PateintID { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal PaymentAmount { get; set; }
        public string Note { get; set; }
        public int MethodID { get; set; }
        public int insertedID;

        // Defualt Constructor.
        public ClsPayment()
        {
            PaymentID = 0;
            PateintID = 0;
            PaymentAmount = 0;
            PaymentDate = DateTime.Now;
            Note = string.Empty;

            Mode = EnMode.AddNew;
        }


        // Private Constructor used to add a Payment to DB.

        private ClsPayment(int PaymentID ,int PateintID, decimal PaymentAmount, DateTime PaymentDate, string Note)
        {
            this.PaymentID = PaymentID;
            this.PateintID = PateintID;
            this.PaymentAmount = PaymentAmount;
            this.PaymentDate = PaymentDate;
            this.Note = Note;

            Mode = EnMode.Update;
        }


        // All CURD Opirations.
        public static int GetLastID()
        {
            return ClsClinicDatabase.GetLastID(PAYMENT_COLUMN_PK, PAYMENTS);
        }
        private bool AddNew()
        {
            return ClsClinicDatabase.AddNewPaymentToDB(ref insertedID, PateintID, MethodID, PaymentDate, PaymentAmount, Note);
        }
        public bool Update()
        {
            return ClsClinicDatabase.UpdatePayment(PateintID, PateintID, PaymentAmount, PaymentDate, Note);
        }
        public static bool Delete(int id)
        {
            return ClsClinicDatabase.DeleteByID(id, PAYMENTS, PAYMENT_COLUMN_PK);
        }
        public static DataTable GetAllPayments()
        {
            return ClsClinicDatabase.GetAll(PAYMENTS);
        }
        public static DataTable GetByDateAndMethod(DateTime from, DateTime to, int methodID) => ClsClinicDatabase.GetPaymentByDateAndMethod(from, to, methodID);
        public static ClsPayment Find(int id)
        {
            int pateintID = 0;
            decimal paymentAmount = 0;
            DateTime paymentDate = DateTime.MinValue;
            string Note = string.Empty;

            if (ClsClinicDatabase.GetPaymentByID(id, ref pateintID, ref paymentAmount, ref paymentDate, ref Note))
                return new ClsPayment(id, pateintID, paymentAmount, paymentDate, Note);

            else return null;
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
        public static bool IsExists(int id)
        {
            return ClsClinicDatabase.IsExists(id, PAYMENTS, PAYMENT_COLUMN_PK);
        }
    }
}
