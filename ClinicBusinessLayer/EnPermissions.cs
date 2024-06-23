namespace ClinicBusinessLayer
{
    public enum EnPermissions
    {
        Nothing = 0,
        All = -1,
        Appointement = 1,
        AddPatient = 2,
        FindPatient = 4,
        DeletePatient = 8,
        UpdatePatient = 16,
        PatientList = 32,
        PatientAS = 64,
        PatientMR = 128,
        AddEmployee = 256,
        FindEmployee = 512,
        DeleteEmployee = 1024,
        UpdateEmployee = 2048,
        EmployeeList = 4096,
        Department = 8192,
        ManageUsers = 16384,
        Payments = 32768
    };
}