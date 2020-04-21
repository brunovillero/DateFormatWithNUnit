using System;
using System.Globalization;

namespace Library
{
    public class DateFormat
    {
        public static String ChangeFormat(String year, String format)
        {
            if(ValidateDate(year))
            {
                if(format == "aaaa-mm-dd")
                {
                    return year.Substring(6) + "-" + year.Substring(3, 2) + "-" + year.Substring(0, 2);
                }
                else if(format == "DD-MM-YYYY")
                {
                    return year.Substring(0, 2) + "-" + year.Substring(3, 2) + "-" + year.Substring(6);
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }

        public static Boolean ValidateDate(String dateInput)
        {   
            DateTime newDate;

            bool parsedDate = DateTime.TryParseExact(
                dateInput,
                "dd/mm/yyyy",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out newDate
            );

            return parsedDate;
        }
    }
}
