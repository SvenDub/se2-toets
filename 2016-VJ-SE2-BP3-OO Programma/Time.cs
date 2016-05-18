using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2016_VJ_SE2_BP3_OO_Programma
{
    /// <summary>
    /// Possible days of the week, or unspecified. This enum can be cast
    /// to an integer with the Convert.ToInt32 method.
    /// </summary>
    public enum Days
    {
        Monday = 0,
        Tuesday = 1,
        Wednesday = 2,
        Thursday = 3,
        Friday = 4,
        Saturday = 5,
        Sunday = 6,
        Unspecified = 7
    }

    /// <summary>
    /// Class that models a simple day and time layout. It combines a day of
    /// the week with an hour and minute, providing some simple comparisons
    /// between then.
    /// </summary>
    public class Time
    {
        public class InvalidTimeOperationException : Exception
        {
            public InvalidTimeOperationException(string message)
                :base(message)
            { }
        }

        /// <summary>
        /// Gets or sets the day component of the time structure.
        /// </summary>
        public Days Day { get; set; }

        /// <summary>
        /// Gets or sets the hour component of the time structure.
        /// </summary>
        public int Hour
        {
            get { return this.hour; }
            set
            {
                if (0 <= value && value < 24)
                {
                    this.hour = value;
                }
            }
        }
        private int hour;

        /// <summary>
        /// Gets or sets the minute component of the time structure.
        /// </summary>
        public int Minute
        {
            get { return this.minute; }
            set
            {
                if (0 <= value && value < 60)
                {
                    this.minute = value;
                }
            }
        }
        private int minute;

        /// <summary>
        /// Get a time-only representation of this instance, excluding the day
        /// part. If you want to have the day prefixed, use ToString().
        /// </summary>
        public string TimeString
        {
            get
            {
                return String.Format("{0:00}:{1:00}", this.hour, this.minute);
            }
        }

        /// <summary>
        /// Gets the current time of day.
        /// </summary>
        public static Time Now
        {
            get
            {
                DateTime now = DateTime.Now;
                return new Time((Days)(((int)now.DayOfWeek + 6) % 7),
                                now.Hour, now.Minute);
            }
        }

        /// <summary>
        /// Gets the total number of minutes represented by the current
        /// Time instance, calculated from midnight.
        /// </summary>
        public int TotalMinutes
        {
            get
            {
                return this.Hour * 60 + this.Minute;
            }
        }

        /// <summary>
        /// Construct a new Time instance.
        /// </summary>
        /// <param name="day">The day of the week.</param>
        /// <param name="hour">The hour of day.</param>
        /// <param name="minute">The minute of the hour.</param>
        public Time(Days day, int hour, int minute)
        {
            this.Day = day;
            this.Hour = hour;
            this.Minute = minute;
        }

        /// <summary>
        /// Construct a new Time instance by parsing a string. The string
        /// should consist of three segments, separated by a colon. For
        /// example: "Monday:08:00" or "08:00".
        /// </summary>
        public Time(string time)
        {
            string[] parts = time.Trim().Split(':');

            if (parts.Length == 3)
            {
                this.Day = this.ParseDay(parts[0]);
                parts = parts.Skip(1).ToArray();
            }
            else
            {
                this.Day = Days.Unspecified;
            }

            this.Hour = Convert.ToInt32(parts[0]);
            this.Minute = Convert.ToInt32(parts[1]);
        }

        /// <summary>
        /// Construct a new Time instance by parsing the day parameter to an enum.
        /// </summary>
        public Time(string day, int hour, int minute)
            : this(hour, minute)
        {
            this.Day = this.ParseDay(day);
        }
        /// <summary>
        /// Construct a new Time instance, allowing values from a numeric
        /// up-down to be used directly (decimals).
        /// </summary>
        public Time(string day, decimal hour, decimal minute)
            : this(day, Convert.ToInt32(hour), Convert.ToInt32(minute))
        { }
        /// <summary>
        /// Construct a new Time instance with an unspecified day.
        /// </summary>
        public Time(int hour, int minute)
            : this(Days.Unspecified, hour, minute)
        { }
        /// <summary>
        /// Construct a new Time instance with an unspecified day, allowing
        /// values from a numeric up-down to be used directly (decimals).
        /// </summary>
        public Time(decimal hour, decimal minute)
            : this(Days.Unspecified, Convert.ToInt32(hour), Convert.ToInt32(minute))
        { }
        /// <summary>
        /// Construct a new Time instance with an unspecified day, midnight.
        /// </summary>
        public Time()
            :this(Days.Unspecified, 0, 0)
        { }

        public override string ToString()
        {
            if (this.Day == Days.Unspecified)
            {
                return String.Format("{0:00}:{1:00}", this.hour, this.minute);
            }
            return String.Format("{2} {0:00}:{1:00}", this.hour, this.minute, this.Day);
        }

        public static bool operator <(Time a, Time b)
        {
            if (a == null || b == null)
            {
                return false;
            }

            if (a.Day != b.Day)
            {
                throw new InvalidTimeOperationException(
                    "Can only compare times when the dates are equal.");
            }

            return a.Day < b.Day || a.TotalMinutes < b.TotalMinutes;
        }
        public static bool operator >(Time a, Time b)
        {
            return !(a < b);
        }
        public static bool operator ==(Time a, Time b)
        {
            // Allow null comparison
            if (a as object == null && b as object == null)
            {
                return true;
            }

            if (a as object == null || b as object == null)
            {
                return false;
            }

            if (a.Day != b.Day)
            {
                throw new InvalidTimeOperationException(
                    "Can only compare times when the dates are equal.");
            }

            return a.TotalMinutes == b.TotalMinutes;
        }
        public static bool operator !=(Time a, Time b)
        {
            return !(a == b);
        }
        public static bool operator <=(Time a, Time b)
        {
            return a < b || a == b;
        }
        public static bool operator >=(Time a, Time b)
        {
            return a > b || a == b;
        }
        public static Time operator +(Time a, Time b)
        {
            if (a.Day != b.Day)
            {
                throw new InvalidTimeOperationException(
                    "Can only add times when the dates are equal");
            }

            int difference = a.TotalMinutes + b.TotalMinutes;
            return new Time((difference / 60) % 24, difference % 60);
        }
        public static Time operator -(Time a, Time b)
        {
            if (a.Day != b.Day)
            {
                throw new InvalidTimeOperationException(
                    "Can only subtract times when the dates are equal");
            }

            int difference = a.TotalMinutes - b.TotalMinutes;
            return new Time((difference / 60) % 24, difference % 60);
        }

        public override bool Equals(object obj)
        {
            if (obj is Time)
            {
                return this == obj as Time;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return Convert.ToInt32(this.Day) * 1440 + this.TotalMinutes;
        }

        private Days ParseDay(string day)
        {
            Days result = Days.Unspecified;
            Enum.TryParse<Days>(day, out result);
            return result;
        }
    }
}
