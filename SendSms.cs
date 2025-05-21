using System;

public class SendSms : ISmsAlert

{
	pubic void SendSms(string to, string message)
	{
		Console.WriteLine($"send message to {to}");
	}
}
