using System;
using System.Drawing;

namespace StaticConstructorSample
{
    public static class UserPreference
    {
        public static Color BackColor { get; }

        static UserPreference()
        {
            DateTime now = DateTime.Now;

            if (now.DayOfWeek == DayOfWeek.Saturday || now.DayOfWeek == DayOfWeek.Sunday)
            {
                BackColor = Color.Green;
            }
            else
            {
                BackColor = Color.Red;
            }
        }
    }
}