using Godot;

namespace MMP.Godot.Extensions.Helper
{
    public static class TimeHelper
    {
        public static ulong GetSystemTimeMsec()
        {
            double unixTime = Time.GetUnixTimeFromSystem();
            ulong unixTimeLong = (ulong)(unixTime * 1000.0);
            //return (int)((unixTime - unixTimeInt) * 1000.0);
            return unixTimeLong;
        }
    }
}
