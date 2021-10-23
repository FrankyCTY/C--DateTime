using System;

namespace Time
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTimeOffset now = DateTimeOffset.Now;
            DateTimeOffset utcNow = DateTimeOffset.UtcNow;

            DateTime dtNow = DateTime.Now;
            DateTime dtNowInUTCWithoutTimeZoneInfo = TimeZoneInfo.ConvertTimeToUtc(dtNow);

            TimeZoneInfo localSystemTimeZone = TimeZoneInfo.Local;
            
            
            Console.WriteLine($"Current time (local) in UTC  {now}");
            Console.WriteLine($"Current UTC time {utcNow}");

            Console.WriteLine($"Date time now: {dtNow}");
            Console.WriteLine($"Date time to UTC now: {dtNowInUTCWithoutTimeZoneInfo}");

            Console.WriteLine($"Local system time zone {localSystemTimeZone}");
            Console.WriteLine($"UTC to dateTime now: {TimeZoneInfo.ConvertTimeFromUtc(dtNowInUTCWithoutTimeZoneInfo, localSystemTimeZone)}");
        }
    }
}
