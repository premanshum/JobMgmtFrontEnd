using System;
using System.Globalization;

namespace JobManagementWeb.Utility.Extensions
{
    public static class StringExtension
	{
        /// <summary>
        /// Return a date with format other wise returns an empty string
        /// </summary>
        /// <param name="strDate"></param>
        /// <returns></returns>
        public static string TryParseDate(this string strDate)
        {
            //https://stackoverflow.com/questions/3556144/how-to-create-a-net-datetime-from-iso-8601-format
            string[] formats = { 
                // Basic formats
                "yyyyMMddTHHmmsszzz",
                "yyyyMMddTHHmmsszz",
                "yyyyMMddTHHmmssZ",
                "yyyyMMddTHHmmss",
                "yyyyMMdd",
                // Extended formats
                "yyyy-MM-ddTHH:mm:sszzz",
                "yyyy-MM-ddTHH:mm:sszz",
                "yyyy-MM-ddTHH:mm:ssZ",
                "yyyy-MM-ddTHH:mm:ss",
                "yyyy-MM-dd",
                // All of the above with reduced accuracy
                "yyyyMMddTHHmmzzz",
                "yyyyMMddTHHmmzz",
                "yyyyMMddTHHmmZ",
                "yyyyMMddTHHmm",
                "yyyy-MM-ddTHH:mmzzz",
                "yyyy-MM-ddTHH:mmzz",
                "yyyy-MM-ddTHH:mmZ",
                "yyyy-MM-ddTHH:mm",
                // Accuracy reduced to hours
                "yyyyMMddTHHzzz",
                "yyyyMMddTHHzz",
                "yyyyMMddTHHZ",
                "yyyyMMddTHH",
                "yyyy-MM-ddTHHzzz",
                "yyyy-MM-ddTHHzz",
                "yyyy-MM-ddTHHZ",
                "yyyy-MM-ddTHH",
                "dd/MM/yyyy",
                "MM/dd/yyyy",
                "dd-MM-yyyy",
                "MM-dd-yyyy",
                "dd MMM, YYYY",
                "MM/dd/yyyy HH:mm:ss"
                };

            if (string.IsNullOrWhiteSpace(strDate))
            {
                return string.Empty;
            }
            else
            {
                try
                {
                    return DateTime.ParseExact(strDate, formats, CultureInfo.InvariantCulture, DateTimeStyles.None)
                        .ToString(ConfigValues.DateTimeFormatConfig);
                }
                catch (Exception ex)
                {
                    return string.Empty;
                }
            }
        }

    }
}
