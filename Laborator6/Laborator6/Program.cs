using System;

namespace Laborator6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ntpClient = new NtpClient();
            var timeZoneConverter = new TimeZoneConverter();

            while (true)
            {
                try
                {
                    Console.Write("Introduceti zona geografica (ex: GMT+2): ");
                    string zona = Console.ReadLine();

                    var utcTime = ntpClient.GetNetworkTime();
                    var localTime = timeZoneConverter.ConvertToTimeZone(utcTime, zona);

                    Console.WriteLine($"Ora exacta pentru zona {zona} este: {localTime}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Eroare: {ex.Message}");
                }

                if (Console.ReadLine()?.Trim().ToLower() != "exit")
                    break;
            }
        }
    }
}
