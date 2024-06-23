using System.Data;
using ClinicDALayer;
using static ClinicDALayer.ClsClinicContract.Tables;
using static ClinicDALayer.ClsClinicContract.PaymentMethod;

namespace ClinicBusinessLayer
{
    public class ClsPaymentMethod
    {
        public int PM_ID { get; set; }
        public string PaymentMethod { get; set; }

        public enum EnMode { AddNew = 0, Update = 1 };
        public EnMode Mode = EnMode.AddNew;


        // Defualt Constructor.
        public ClsPaymentMethod()
        {
            PM_ID = 0;
            PaymentMethod = string.Empty;

            Mode = EnMode.AddNew;
        }

        public ClsPaymentMethod(int PM_ID)
        {
            this.PM_ID = PM_ID;
            Mode = EnMode.Update;
        }


        // Private Constructor used to add a Method to DB.
        private ClsPaymentMethod(int PM_ID, string PaymentMethod)
        {
            this.PM_ID = PM_ID;
            this.PaymentMethod = PaymentMethod;

            Mode = EnMode.Update;
        }


        // CURD Opirations.
        private bool AddNew()
        {
            return ClsClinicDatabase.AddNewPaymentMethodToDB(PaymentMethod);
        }
        public bool Update()
        {
            return ClsClinicDatabase.UpdatePaymentMethod(PM_ID, PaymentMethod);
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
        public static ClsPaymentMethod Find(int id)
        {
            string method = string.Empty;

            if (ClsClinicDatabase.GetPaymentMethodByID(id, ref method))
                return new ClsPaymentMethod(id, method);

            else return null;
        }


        public static ClsPaymentMethod Find(string method)
        {
            int id = 0;
            if (ClsClinicDatabase.GetPaymentMethodIDByName(ref id, method))
                return new ClsPaymentMethod(id);

            else return new ClsPaymentMethod();
        }
        public static bool Delete(int id)
        {
            return ClsClinicDatabase.DeleteByID(id, PAYMENT_METHODS, PAYMENT_METHOD_COLUMN_PK);
        }
        public static DataTable GetAllPaymentMethods()
        {
            return ClsClinicDatabase.GetAll(PAYMENT_METHODS);
        }
    }
}
