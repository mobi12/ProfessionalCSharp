using System;

namespace EnumSample
{
    [Flags] //枚举类型位操作
    public enum DaysOfWeek
    {
        Monday = 0x01,
        Tuesday = 0x02,
        Wednesday = 0x04,
        Thursday = 0x08,
        Friday = 0x10,
        Saturday = 0x20,
        Sunday = 0x40
    }
}