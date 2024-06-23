namespace ClinicDALayer
{
    public static class ClsClinicContract
    {


        /* Inner class that defines the tables names */
        public static class Tables
        {
            public const string PERSONS = "PERSONS";
            public const string DEPARTMENTS = "DEPARTMENTS";
            public const string PATIENTS = "PATIENTS";
            public const string EMPLOYEES = "EMPLOYEES";
            public const string USERS = "USERS";
            public const string PHONES = "PHONES";
            public const string APPOINTMENTS = "APPOINTMENTS";
            public const string MEDICAL_RECORDS = "MEDICAL_RECORDS";
            public const string PAYMENTS = "PAYMENTS";
            public const string PAYMENT_METHODS = "PAYMENT_METHODS";
            public const string PRESCRIPTIONS = "PRESCRIPTION";
            public const string MEDICATIONS = "MEDICATIONS";
        }


        /* Inner class that defines the (PERSONS) table contents */
        public static class Person
        {
            public const string PERSON_COLUMN_PK = "PersonID";
            public const string PERSON_COLUMN_FIRST_NAME = "FirstName";
            public const string PERSON_COLUMN_MID_NAME = "MidName";
            public const string PERSON_COLUMN_LAST_NAME = "LastName";
            public const string PERSON_COLUMN_DATE = "BirthDay";
            public const string PERSON_COLUMN_EMAIL = "Email";
            public const string PERSON_COLUMN_GENDER = "Gender";
            public const string PERSON_COLUMN_ADDRESS = "Address";
        }


        /* Inner class that defines the (USERS) table contents */
        public static class Users
        {
            public const string USERS_COLUMN_PK = "UserID";
            public const string USERS_COLUMN_EMPLOYEE_ID = "EmployeeID";
            public const string USERS_COLUMN_USERNAME = "Username";
            public const string USERS_COLUMN_PASSWORD = "Password";
            public const string USERS_COLUMN_IS_ACTIVE = "IsActive";
            public const string USERS_COLUMN_PERMISSION = "Permission";

        }


        /* Inner class that defines the (PATIENTS) table contents */
        public static class Patient
        {
            public const string PATIENT_COLUMN_PK = "PatientID";
            public const string PATIENT_COLUMN_FK = "PersonID";
        }


        /* Inner class that defines the (DOCTORS) table contents */
        public static class Employee
        {
            public const string EMPLOYEE_COLUMN_PK = "EmployeeID";
            public const string EMPLOYEE_COLUMN_PERSON_ID = "PersonID";
            public const string EMPLOYEE_COLUMN_DEP_ID = "DepartmentID";
        }


        /* Inner class that defines the (DEPARTMENTS) table contents */
        public static class Department
        {
            public const string DEP_COLUMN_PK = "DepartmentID";
            public const string DEP_COLUMN_NAME = "DepartmentName";
            public const string DEP_COLUMN_SPECIALIZATION = "Specialization";
        }


        /* Inner class that defines the (PHONES) table contents */
        public static class Phone
        {
            public const string PHONE_COLUMN_PK = "PhoneID";
            public const string PHONE_COLUMN_FK = "PersonID";
            public const string PHONE_COLUMN_NUMBER = "Number";
        }



        /* Inner class that defines the (APPOINTMENT) table contents */
        public static class Appointment
        {
            public const string APPOINTMENT_COLUMN_PK = "AppointmentID";
            public const string APPOINTMENT_COLUMN_DOCTOR_ID = "DoctorID";
            public const string APPOINTMENT_COLUMN_PATIENT_ID = "PatientID"; 
            public const string APPOINTMENT_COLUMN_PAYMENT_ID = "PaymentID";
            public const string APPOINTMENT_COLUMN_RECORD_ID = "RecordID";
            public const string APPOINTMENT_COLUMN_STATUS = "Status";
            public const string APPOINTMENT_COLUMN_DATE = "Date";

            public static string APPOINTMENT_INFO_QUERY = $@"SELECT
                            {APPOINTMENT_COLUMN_PK},
                            Patient = 
                            {Tables.PERSONS}.{Person.PERSON_COLUMN_FIRST_NAME} + ' ' +
                            {Tables.PERSONS}.{Person.PERSON_COLUMN_MID_NAME} + ' ' +
                            {Tables.PERSONS}.{Person.PERSON_COLUMN_LAST_NAME},
                            {Tables.PERSONS}.{Person.PERSON_COLUMN_GENDER},
                            Age = DATEDIFF(YEAR, {Tables.PERSONS}.{Person.PERSON_COLUMN_DATE}, GETDATE()),
                            {Tables.APPOINTMENTS}.{APPOINTMENT_COLUMN_STATUS},
                            {Tables.APPOINTMENTS}.{APPOINTMENT_COLUMN_DATE}
                            FROM {Tables.APPOINTMENTS}
                            JOIN {Tables.PATIENTS}
                            ON {Tables.APPOINTMENTS}.{APPOINTMENT_COLUMN_PATIENT_ID} = {Tables.PATIENTS}.{Patient.PATIENT_COLUMN_PK}
                            JOIN {Tables.PERSONS}
                            ON {Tables.PATIENTS}.{Patient.PATIENT_COLUMN_FK} = {Tables.PERSONS}.{Person.PERSON_COLUMN_PK}";

        }



        /* Inner class that defines the (MEDICAL_RECORD) table contents */
        public static class MedicalRecord
        {
            public const string MEDICAL_RECORD_COLUMN_PK = "RecordID";
            public const string MEDICAL_RECORD_DESCRIPTION = "Description";
            public const string MEDICAL_RECORD_DIAGNOSIS = "Diagnosis";
            public const string MEDICAL_RECORD_NOTE = "Note";
        }



        /* Inner class that defines the (PAYMENT) table contents */
        public static class Payment
        {
            public const string PAYMENT_COLUMN_PK = "PaymentID";
            public const string PAYMENT_COLUMN_PAITENT_ID = "PatientID";
            public const string PAYMENT_COLUMN_METHOD_ID = "MethodID";
            public const string PAYMENT_COLUMN_DATE = "Date";
            public const string PAYMENT_COLUMN_AMOUNT = "AmountPaid";
            public const string PAYMENT_COLUMN_NOTE = "Note";
            public const string PAYMENT_COLUMN_REFERENCE_NO = "ReferenceNo";
        }



        /* Inner class that defines the (PAYMENT_METHODS) table contents */
        public static class PaymentMethod
        {
            public const string PAYMENT_METHOD_COLUMN_PK = "MethodID";
            public const string PAYMENT_METHOD_COLUMN_METHOD = "Method";
        }



        /* Inner class that defines the (PRESCRIPTION) table contents */
        public static class Prescription
        {
            public const string PRESCRIPTION_COLUMN_PK = "PrescriptionID";
            public const string PRESCRIPTION_COLUMN_FK = "RecordID";
        }


        /* Inner class that defines the (MEDICATIONS) table contents */
        public static class Medication
        {
            public const string MEDICATION_COLUMN_PK = "MedicationID";
            public const string MEDICATION_COLUMN_FK = "PrescriptionID";
            public const string MEDICATION_NAME = "MedicationName";
            public const string MEDICATION_FREQ = "Freq";
            public const string MEDICATION_DOSAGE = "Dosage";
            public const string MEDICATION_S_DATE = "StartDate";
            public const string MEDICATION_E_DATE = "EndDate";


        }
    }
}