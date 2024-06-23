using System;
using System.Data;
using ClinicDALayer;
using static ClinicDALayer.ClsClinicContract.Tables;
using static ClinicDALayer.ClsClinicContract.Appointment;
using System.Collections.Generic;

namespace ClinicBusinessLayer
{
    public class ClsAppointment
    {
        // Refers to the Appointment Mode to Track the correct operation that will perform.
        public enum EnMode { AddNew = 0, Update = 1 };
        public EnMode Mode = EnMode.AddNew;


        // Referce to the Appointment status.
        public enum EnStatus { Pending = 0, Confirmed = 1, Completed = 2, Canceled = 3, Rescheduled = 4, NoShow = 5 };
        public EnStatus Status = EnStatus.Pending;


        // Getters And Setters.
        public int AppointmentID { get; set; }
        public int PateintID { get; set; }
        public int DoctorID { get; set; }
        public DateTime DateAndTime { get; set; }
        public int PaymentID { get; set; }
        public int RecordID { get; set; }
        public string AppointmentStatus { get; set; }


        // Defualt Constructor.
        public ClsAppointment()
        {
            AppointmentID = 0;
            PateintID = 0;
            DoctorID = 0;
            DateAndTime = DateTime.Now;
            PaymentID = 0;
            RecordID = 0;
            AppointmentStatus = EnStatus.Pending.ToString();

            Mode = EnMode.AddNew;
        }


        // Private Constructor used to add an Appointment to Database.
        private ClsAppointment
            (int AppointmentID, int DoctorID, int PateintID, int PaymentID, int RecordID, string AppointmentStatus, DateTime DateAndTime)
        {
            this.AppointmentID = AppointmentID;
            this.PateintID = PateintID;
            this.DoctorID = DoctorID;
            this.DateAndTime = DateAndTime;
            this.PaymentID = PaymentID;
            this.RecordID = RecordID;
            this.AppointmentStatus = AppointmentStatus;

            Mode = EnMode.Update;
        }


        private bool AddNew()
        {
            return ClsClinicDatabase.AddNewAppointmentToDB
                (DoctorID, PateintID, PaymentID, RecordID, AppointmentStatus, DateAndTime);
        }

        public static ClsAppointment Find(int id)
        {

            int doctorID = 0, pateintID = 0, paymentID = 0, recordID = 0;
            string appointmentStatus = string.Empty;
            DateTime dateAndTime = DateTime.MinValue;

            if (ClsClinicDatabase.GetAppointmentByID
                (
                id,
            ref doctorID, ref pateintID, ref paymentID,
            ref recordID, ref appointmentStatus, ref dateAndTime
                ))
                return new ClsAppointment(id, doctorID, pateintID, paymentID, recordID, appointmentStatus, dateAndTime);

            else return new ClsAppointment();
        }

        public bool Update()
        {
            return ClsClinicDatabase.UpdateAppointment
                (
                AppointmentID, PateintID, DoctorID, DateAndTime, PaymentID, RecordID, AppointmentStatus
                );
        }

        public static bool IsExists(int id)
        {
            return ClsClinicDatabase.IsExists(id, APPOINTMENTS, APPOINTMENT_COLUMN_PK);
        }

        public static DataTable GetAllAppointment()
        {
            return ClsClinicDatabase.GetAllAppointemnts();
        }

        public static DataTable GetAppointmentByStutasAndDate(List<string> status, DateTime date)
        {
            return ClsClinicDatabase.GetAppointmentByStatusAndDate(status, date);
        }

        public static DataTable GetAppointmentBetween(DateTime from, DateTime to)
        {
            return ClsClinicDatabase.GetAppointmentBetweenDate(from, to);
        }

        public bool Save()
        {

            switch(Mode)
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

        public static bool Delete(int id)
        {
            return ClsClinicDatabase.DeleteByID(id, APPOINTMENTS, APPOINTMENT_COLUMN_PK);
        }

        public bool IsEmpty() => AppointmentID == 0;
    }
}