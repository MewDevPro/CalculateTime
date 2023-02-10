using System;

namespace CalculateTime
{
    internal class Controller
    {
        private readonly uint seconds;
        private readonly bool useFullTime = false;

        public Controller(uint seconds, bool useFullTime)
        {
            this.seconds = seconds;
            this.useFullTime = useFullTime;
        }

        public string Converter()
        {
            decimal _days = this.seconds / (3600 * 24);
            uint days = (uint)Math.Floor(_days);
            decimal _hours = this.seconds % (3600 * 24) / 3600;
            uint hours = (uint)Math.Floor(_hours);
            decimal _minutes = this.seconds % (3600 * 24) % 3600 / 60;
            uint minutes = (uint)Math.Floor(_minutes);
            decimal _seconds = this.seconds % (3600 * 24) % 3600 % 60;
            uint seconds = (uint)Math.Floor(_seconds);
            return useFullTime
                ? days + " ngày " + hours + " giờ " + minutes + " phút " + seconds + " giây"
                : days + ":" + hours + ":" + minutes + ":" + seconds;
        }
    }
}
