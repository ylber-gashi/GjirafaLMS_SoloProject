using System;

namespace GjirafaLMS.Helpers
{
    public class EventHelper
    {
        public static DateTime CalculateDate(DateTime startDate, int duration, string durationType)
        {
            if(durationType.Equals("Hours"))
            {
                DateTime endDate = startDate.AddHours(duration);
                return endDate;
            }else if(durationType.Equals("Minutes"))
            {
                DateTime endDate = startDate.AddMinutes(duration);
                return endDate;
            }else if(durationType.Equals("Days"))
            {
                DateTime endDate = startDate.AddDays(duration);
                return endDate;
            }

            return startDate;
        }
    }
}