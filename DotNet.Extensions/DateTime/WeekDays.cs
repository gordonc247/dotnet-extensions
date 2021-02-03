using System;

namespace DotNet.Extensions
{
    [Flags]
    public enum WeekDays
    {
        None = 0,
        Sunday = 1,
        Monday = 2,
        Tuesday = 4,
        Wednesday = 8,
        Thursday = 16,
        Friday = 32,
        Saturday = 64,
        WorkDays = Monday | Tuesday | Wednesday | Thursday | Friday,
        All = Sunday | Monday | Tuesday | Wednesday | Thursday | Friday | Saturday
    }
}
