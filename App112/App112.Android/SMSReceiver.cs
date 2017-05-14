using Android.Content;
using Android.Util;
using Android.Widget;

namespace App112.Droid {

	/// <summary>
	/// Monitors the status of sent SMS messages
	/// </summary>
	public class SMSReceiver : BroadcastReceiver {

		/// <summary>
		/// Handles outgoing message status
		/// </summary>
		/// <param name="context">Application <see cref="Context"/></param>
		/// <param name="intent"></param>
		public override void OnReceive(Context context, Intent intent) {
			//Log.Info("App112", "Broadcast onReceive status: " + this.ResultCode.ToString());
			switch (GetResultCode()) {
				case "Ok": {
					Log.Info("App112", "SMS sent successfully");
//					Toast.MakeText(context, "SMS sent succesfully", ToastLength.Short).Show();
				} break;
				default: {
					Log.Wtf("App112", "SMS send failed (no signal?)");
					Toast.MakeText(context, "SMS send failed (no signal?)", ToastLength.Long).Show();
				} break;
			}
		}

		/// <summary>
		/// Returns a string of the ResultCode
		/// </summary>
		/// <returns>A <see cref="string"/> of the result. "Ok" if everything went well, some random stuff if it didn't</returns>
		private string GetResultCode() {
			return ResultCode.ToString();
		}
	}
}