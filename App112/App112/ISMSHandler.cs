using System;

namespace App112 {
	/// <summary>
	/// Abstract interface for SMS messaging support
	/// </summary>
	public interface ISMSHandler {
		/// <summary>
		/// Sends a SMS message
		/// </summary>
		/// <exception cref="ArgumentException">Thrown when any of the parameters is null/empty</exception>
		/// <param name="destination">Where the message comes from</param>
		/// <param name="source">Where the message is sent to</param>
		/// <param name="text">Message body</param>
		void SendSMS(string destination, string source, string text);
	}
}