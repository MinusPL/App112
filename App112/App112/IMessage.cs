namespace App112 {
	/// <summary>
	/// Abstract interface for little debug messages
	/// </summary>
	public interface IMessage {
		/// <summary>
		/// Shows a quick debug message
		/// </summary>
		/// <param name="text">Test to show</param>
		void ShowMessage(string text);
	}
}