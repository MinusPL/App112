using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using App112.Droid;

[assembly: Dependency(typeof(AndroidServiceInfo))]
namespace App112.Droid
{
    public class AndroidServiceInfo : IDeviceServiceInfo
    {
        public string ConvertToDeviceShortDateFormat(DateTime inputDateTime)
        {
            var dateFormat = Android.Text.Format.DateFormat.GetDateFormat(Android.App.Application.Context);
            var epochDateTime = ConvertDateTimeToUnixTime(inputDateTime, true);

            if (epochDateTime == null)
            {
                return string.Empty;
            }

            using (var javaDate = new Java.Util.Date((long)epochDateTime))
            {
                return dateFormat.Format(javaDate);
            }
        }

        public string ConvertToDeviceTimeFormat(DateTime inputDateTime)
        {
            var timeFormat = Android.Text.Format.DateFormat.GetTimeFormat(Android.App.Application.Context);
            var epochDateTime = ConvertDateTimeToUnixTime(inputDateTime, true);

            if (epochDateTime == null)
            {
                return string.Empty;
            }

            using (var javaDate = new Java.Util.Date((long)epochDateTime))
            {
                return timeFormat.Format(javaDate);
            }
        }

        private static readonly DateTime EpochDateTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
        public static long? ConvertDateTimeToUnixTime(DateTime? date, bool isDatarequiredInMilliSeconds = false, DateTimeKind dateTimeKind = DateTimeKind.Local) => date.HasValue == false
                    ? (long?)null
                    : Convert.ToInt64((DateTime.SpecifyKind(date.Value, dateTimeKind).ToUniversalTime() - EpochDateTime).TotalSeconds) * (isDatarequiredInMilliSeconds ? 1000 : 1);
    }
}