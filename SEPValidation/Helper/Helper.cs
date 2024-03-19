using System.Security.Cryptography;
using System.Text;

namespace SEPValidation.Helper
{
    public class Helper
    {
        public static string BuildString(params object[] items)
        {
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < items.Length; i++)
            {
                stringBuilder.Append(items[i]);

                if (i < items.Length - 1)
                {
                    stringBuilder.Append(", ");
                }
            }

            return stringBuilder.ToString();
        }

        public static string GetUnixTimeStamp()
        {
            var span = DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc));
            var dbl = span.TotalSeconds;
            var integer = Convert.ToInt32(dbl);
            return integer.ToString();
        }

        public static string GetEncodedKey(string timeStamp, string consid, string salt, bool isUsingMd5HashonSalt)
        {
            if (isUsingMd5HashonSalt) salt = MD5Hash(salt);

            // Initialize the keyed hash object using the secret key as the key
            var hashObject = new HMACSHA256(Encoding.UTF8.GetBytes(salt));

            // Computes the signature by hashing the salt with the secret key as
            var signature = hashObject.ComputeHash(Encoding.UTF8.GetBytes(string.Format("{0}&{1}", consid, timeStamp)));

            // Base 64 Encode
            return Convert.ToBase64String(signature);
        }

        private static string MD5Hash(string text)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            md5.ComputeHash(Encoding.ASCII.GetBytes(text));
            byte[] result = md5.Hash;

            var strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                //change it into 2 hexadecimal digits  
                //for each byte  
                strBuilder.Append(result[i].ToString("x2"));
            }

            return strBuilder.ToString();
        }
    }

    public class DateHelper
    {
        public static DateTime DateTimeNowDate(int year, int month, int day)
        {
            var result = new DateTime(year, month, day);

            return result;
        }

        public static DateTime DateTimeNow()
        {
            var result = DateTime.Now;
            return result;
        }

        public static string DateTimeNow(string format, DateTime dateTime)
        {
            string result = string.IsNullOrEmpty(format) ? dateTime.ToString() : dateTime.ToString(format);

            return result;
        }

        public static string DateTimeIsNull(DateTime? dateTime, DateTime defaultTime, string dateFormat)
        {
            string result = dateTime.HasValue
                ? DateTimeNow(dateFormat, (DateTime)dateTime)
                : DateTimeNow(dateFormat, defaultTime);
            return result;
        }

        public static DateTime DateTimeAddDays(int days)
        {
            var dateTime = DateTime.Now.AddDays(days);
            return dateTime;
        }

        public static DateTime StringToDateTime(string value, DateTime defaultValue)
        {
            DateTime result;

            try
            {
                result = DateTime.Parse(value);
            }
            catch
            {
                result = defaultValue;
            }

            return result;
        }

        public static class DateStringFormat
        {
            private static string shortyearpattern = "yyMMdd";
            private static string longyearpattern = "yyyy-MM-dd HH:mm:ss";
            private static string yearmonthdate = "yyyy-MM-dd";
            private static string date = "dd/MM/yyyy";
            private static string datetime = "dd/MM/yyyy HH:mm";
            private static string datetimesecond = "dd/MM/yyyy HH:mm:ss";
            private static string datelong = "dd MMM yyyy";
            private static string dateshortmonth = "dd-MMM-yyyy";
            private static string longdatepattern = "dd-MMM-yyyy HH:mm:ss";
            private static string datehourminute = "dd/MM/yyyy HH:mm";
            private static string dateshortmonthhourminute = "dd-MMM-yyyy HH:mm";
            private static string hourmin = "HH:mm";
            private static string month = "MMMM";
            private static string daydatemonthyear = "dddd, dd MMMM yyyy";
            public static string Shortyearpattern { get => shortyearpattern; set => shortyearpattern = value; }
            public static string Longyearpattern { get => longyearpattern; set => longyearpattern = value; }
            public static string Date { get => date; set => date = value; }
            public static string Datetime { get => datetime; set => datetime = value; }
            public static string Datetimesecond { get => datetimesecond; set => datetimesecond = value; }
            public static string Datelong { get => datelong; set => datelong = value; }
            public static string Dateshortmonth { get => dateshortmonth; set => dateshortmonth = value; }
            public static string Longdatepattern { get => longdatepattern; set => longdatepattern = value; }
            public static string Datehourminute { get => datehourminute; set => datehourminute = value; }
            public static string Dateshortmonthhourminute { get => dateshortmonthhourminute; set => dateshortmonthhourminute = value; }
            public static string Hourmin { get => hourmin; set => hourmin = value; }
            public static string Month { get => month; set => month = value; }
            public static string Yearmonthdate { get => yearmonthdate; set => yearmonthdate = value; }
            public static string Daydatemonthyear { get => daydatemonthyear; set => daydatemonthyear = value; }
        }
    }

    public static class ItemDefaultValue
    {
        private static int timeout = 10000;
        public static int TimeOut { get => timeout; set => timeout = value; }
    }

    public class Converter
    {
        public static DateTime StringToDateTime(string? value, DateTime dateTime)
        {
            DateTime result;

            try
            {
                result = string.IsNullOrEmpty(value) ? dateTime : DateTime.Parse(value);
            }
            catch (Exception)
            {
                result = dateTime;
            }

            return result;
        }
    }
}
