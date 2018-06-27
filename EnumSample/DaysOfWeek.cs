using System;

namespace EnumSample
{
    [Flags]
    public enum DaysOfWeek
    {
        Monday = 0x10,
        Tuesday = 0x01,
        Wednesday = 0x02,
        Thursday = 0x03,
        Friday = 0x50,
        Saturday = 0x15,
        Sunday = 0xff
    }
}