using System;

namespace TestTime
{
    class Program
    {
        static void Main(string[] args)
        {   
            SystemTime localTime = new SystemTime();
            Win32.GetLocalTime(out localTime);

            SystemTime systemTime = new SystemTime();
            Win32.GetSystemTime(out systemTime);

            DateTime currentDate = DateTime.Now;


            Console.WriteLine($".NET. Current date: {currentDate}");
            Console.WriteLine($".NET. UTC date: {currentDate.ToUniversalTime()}");
           
            Console.WriteLine($"Win32. Local time: {localTime.Log()}");
            Console.WriteLine($"Win32. System time: {systemTime.Log()}");

            Console.WriteLine($"Local TimeZone. ID: {TimeZoneInfo.Local.Id} Name: {TimeZoneInfo.Local.StandardName} Offset: {TimeZoneInfo.Local.BaseUtcOffset}");
            Console.WriteLine($"Is DST: {TimeZoneInfo.Local.IsDaylightSavingTime(currentDate)}");

/*
            //int hour = 0;
           // if(args.Length > 0) 
           // {
           //     Int32.TryParse(args[0], out hour);
           // }

           // DateTime currentDate = DateTime.Now;

            //DateTime userSetDate = 
            //    new DateTime(
                    currentDate.Year,
                    currentDate.Month,
                    currentDate.Day,
                    hour,
                    currentDate.Minute,
                    0);
            var diff = TimeZoneInfo.Local.GetUtcOffset(userSetDate);
            DateTime UTCDate = userSetDate - diff;

            SystemTime sysTime =
                    new SystemTime()
                    {
                        Day = (ushort)UTCDate.Day,
                        Month = (ushort)UTCDate.Month,
                        Year = (ushort)UTCDate.Year,
                        Hour = (ushort)UTCDate.Hour,
                        Minute = (ushort)UTCDate.Minute,
                    };

            SystemTime localTime = new SystemTime();
            Win32.GetLocalTime(out localTime);

            SystemTime systemTime = new SystemTime();
            Win32.GetSystemTime(out systemTime);

            Console.WriteLine($"Current date: {currentDate}");
            Console.WriteLine($"User date: {userSetDate}");
            Console.WriteLine($"UTC date: {UTCDate}");
            Console.WriteLine($"Local time: {localTime.Log()}");
            Console.WriteLine($"System time: {systemTime.Log()}");

            Console.WriteLine($"Local TimeZone: {TimeZoneInfo.Local.Id} {TimeZoneInfo.Local.StandardName}");
            Console.WriteLine($"Is DST: {TimeZoneInfo.Local.IsDaylightSavingTime(currentDate)}");

            if (Win32.SetSystemTime(ref sysTime)) 
            {
                Console.WriteLine("System time was set");
            }
            else
            {
                Console.WriteLine($"Failed to set system time on local computer. Error (Win32): {System.Runtime.InteropServices.Marshal.GetLastWin32Error()}");                   
            }

            try { TimeZoneInfo.ClearCachedData(); } catch (Exception ex) { Console.WriteLine($"Failed to clear cached timezone data. Ex: {ex.Message}"); }

            DateTime updatedDate = DateTime.Now;
            localTime = new SystemTime();
            Win32.GetLocalTime(out localTime);

            systemTime = new SystemTime();
            Win32.GetSystemTime(out systemTime);

            Console.WriteLine($"Current date: {updatedDate}");
            Console.WriteLine($"Local time: {localTime.Log()}");
            Console.WriteLine($"System time: {systemTime.Log()}");

            SystemTime sysTimeLocal =
                    new SystemTime()
                    {
                        Day = (ushort)userSetDate.Day,
                        Month = (ushort)userSetDate.Month,
                        Year = (ushort)userSetDate.Year,
                        Hour = (ushort)userSetDate.Hour,
                        Minute = (ushort)userSetDate.Minute,
                    };

            
            The system uses UTC internally. Therefore, when you call SetLocalTime,
            the system uses the current time zone information to perform the 
            conversion, including the daylight saving time setting. Note that the
            system uses the daylight saving time setting of the current time, not
            the new time you are setting. Therefore, to ensure the correct result,
            call SetLocalTime a second time, now that the first call has updated
            the daylight saving time setting.
            

            if (Win32.SetLocalTime(ref sysTimeLocal)) 
            {
                Console.WriteLine("Local time was set");
            }
            else
            {
                Console.WriteLine($"Failed to set local time on local computer. Error (Win32): {System.Runtime.InteropServices.Marshal.GetLastWin32Error()}");                   
            }

            if (Win32.SetLocalTime(ref sysTimeLocal)) 
            {
                Console.WriteLine("Local time was set 2");
            }
            else
            {
                Console.WriteLine($"Failed to set local time 2 on local computer. Error (Win32): {System.Runtime.InteropServices.Marshal.GetLastWin32Error()}");                   
            }

            try { TimeZoneInfo.ClearCachedData(); } catch (Exception ex) { Console.WriteLine($"Failed to clear cached timezone data. Ex: {ex.Message}"); }

            updatedDate = DateTime.Now;
            localTime = new SystemTime();
            Win32.GetLocalTime(out localTime);

            systemTime = new SystemTime();
            Win32.GetSystemTime(out systemTime);

            Console.WriteLine($"Current date: {updatedDate}");
            Console.WriteLine($"Local time: {localTime.Log()}");
            Console.WriteLine($"System time: {systemTime.Log()}");
            */
            Console.ReadLine();
        }
    }
}
