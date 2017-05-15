using System;
using Android.App;
using Android.Content;
using Android.Telephony;
using Android.Util;
using App112.Droid;
using Java.Lang;
using System.Collections.Generic;

[assembly: Xamarin.Forms.Dependency(typeof(SMSHandler))]
namespace App112.Droid {

	/// <summary>
	/// Platform-specific implementation of SMS messaging
	/// </summary>
	public class SMSHandler : ISMSHandler {

		/// <summary>
		/// Sends a SMS message. Parameters are checked for nulls and empty strings, and throw <exception cref="ArgumentException"></exception>
		/// </summary>
		/// <param name="destination">Where the message comes from</param>
		/// <param name="source">Where the message is sent to</param>
		/// <param name="text"></param>
		public void SendSMS(string destination, string source, string text) {
			ValidateInput(destination, source, text);
			RegisterReceiver();
			try {
				Log.Info("App112", "Sending SMS message...");
				//SmsManager.Default.SendTextMessage(destination, source, text, GetSentIntent(GetContext()), null);
                IList<string> parts = SmsManager.Default.DivideMessage(text);
                SmsManager.Default.SendMultipartTextMessage(destination, source, parts, null, null);
			}
			catch (IllegalArgumentException e) {
				Log.Wtf("App112", "Error sending SMS message: Destination or text are empty" + e.Message);
			}
		}

		/// <summary>
		/// Checks if the input is null/empty (throws <exception cref="ArgumentException"></exception>)
		/// </summary>
		/// <param name="destination"></param>
		/// <param name="source"></param>
		/// <param name="text"></param>
		private static void ValidateInput(string destination, string source, string text)  {
			if (string.IsNullOrEmpty(destination)) throw new ArgumentException("Value cannot be null or empty.", nameof(destination));
			//if (string.IsNullOrEmpty(source)) throw new ArgumentException("Value cannot be null or empty.", nameof(source));
			if (string.IsNullOrEmpty(text)) throw new ArgumentException("Value cannot be null or empty.", nameof(text));
		}

		/// <summary>
		/// Binds a SMSReceiver to retrieve the status of sent message
		/// </summary>
		private static void RegisterReceiver() {
			GetContext().RegisterReceiver(new SMSReceiver(), new IntentFilter("SMS_SENT"));
		}

		/// <summary>
		/// Application.Context replacement
		/// </summary>
		/// <returns>Returns a <see cref="Context"/> of the application</returns>
		private static Context GetContext() {
			return Application.Context;
		}

		/// <summary>
		/// Creates a hook to monitor SMS message status
		/// </summary>
		/// <param name="ctx"><see cref="Context"/>. Use <see cref="GetContext"/> or <see cref="Application.Context"/></param>
		/// <returns>A <see cref="PendingIntent"/> for the sent message</returns>
		private static PendingIntent GetSentIntent(Context ctx) {
			return PendingIntent.GetBroadcast(ctx, 0, new Intent("SMS_SENT"), 0);
		}
	}
}