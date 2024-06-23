namespace ClinicBusinessLayer
{
    public enum EnStatus
    {
        All = 1,
        ToDay = 2,
        Pending = 4,
        Confirmed = 8,
        Completed = 16,
        Canceled = 32,
        Rescheduled = 64,
        NoShow = 128,
        ByInOperator = 256,
    }
}
