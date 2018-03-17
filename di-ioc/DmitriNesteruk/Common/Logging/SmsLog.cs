using System;

namespace DmitriNesteruk.Common.Logging
{
	public class SmsLog : ILog
	{
		private string phoneNumber;

		public SmsLog(string phoneNumber)
		{
			this.phoneNumber = phoneNumber;
		}

		public void Write(string message)
		{
			Console.WriteLine($"Sms to {phoneNumber} : {message}");
		}

		public void Dispose()
		{
			Console.WriteLine("Sms logger no longer required");
		}
	}
}
