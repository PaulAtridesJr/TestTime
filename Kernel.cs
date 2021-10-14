using System.Runtime.InteropServices;

namespace TestTime 
{
    public static class Win32
    {
        private const string KERNEL32 = "kernel32.dll";
       
        [DllImport(KERNEL32, EntryPoint = "SetSystemTime", SetLastError = true)]
        internal static extern bool SetSystemTime(ref TestTime.SystemTime sysTime);

        [DllImport(KERNEL32, EntryPoint = "SetLocalTime", SetLastError = true)]
        internal static extern bool SetLocalTime(ref TestTime.SystemTime sysTime);

        [DllImport("kernel32", SetLastError = true)]
        internal static extern bool GetSystemTime(out TestTime.SystemTime systemTime);

        [DllImport("kernel32", SetLastError = true)]
        internal static extern bool GetLocalTime(out TestTime.SystemTime systemTime);
    }
}