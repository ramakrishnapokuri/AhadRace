using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AheadRace.Models
{
    /// <summary>
    /// The Julian Day Number (JDN) is the integer assigned to a 
    /// whole solar day in the Julian day count starting from noon Universal time,
    /// </summary>
    public static class JulianDayNumber
    {
        /// <summary>
        /// ToJulian Splits the date string to date,month and year part
        /// </summary>
        /// <param name="dmy">date string</param>
        /// <returns>Julian Number</returns>
        public static long ToJulian(string dmy)
        {
            var split = dmy.Split('/');
            return ToJulian(int.Parse(split[2]), int.Parse(split[1]), int.Parse(split[0]));
        }

        /// <summary>
        /// Conver the date in year,month,day to Julian Number
        /// </summary>
        /// <param name="year">Year of Date part</param>
        /// <param name="month">Month of Date part</param>
        /// <param name="day">Day of Date part</param>
        /// <returns>Julian Number</returns>
        public static long ToJulian(int year, int month, int day)
        {
            if (month < 3)
            {
                month = month + 12;
                year = year - 1;
            }

            return day + (153 * month - 457) / 5 + 365 * year + (year / 4) - (year / 100) + (year / 400) + 1721119;
        }
    }
}