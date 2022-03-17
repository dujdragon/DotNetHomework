using System;

namespace Homework4_P2
{
    class Program
    {
        public delegate void AlarmClockDlg(int[] TimeNow, int[] TimeSet);
        public static event AlarmClockDlg AlarmClockEvent;
        static void Main(string[] args)
        {
            int[] TimeSet = new int[3] { 10, 30, 59 };
            int[] TimeNow = new int[3] { 0, 0, 0 };
            AlarmClockEvent += Alarm;
            AlarmClockEvent += Tick;

            while (true)
            {
                TimeNow[2]++;
                TimeNow[1] += TimeNow[2] / 60;
                TimeNow[0] += TimeNow[1] / 60;

                TimeNow[2] %= 60;
                TimeNow[1] %= 60;
                TimeNow[0] %= 24;

                AlarmClockEvent(TimeNow, TimeSet);
            }

        }

        public static void Tick(int[] TimeNow, int[] TimeSet)
        {
            if (!Equal(TimeNow, TimeSet))
                Console.WriteLine($"Now {TimeNow[0]} : {TimeNow[1]} : {TimeNow[2]}");
            else 
                Console.ReadKey();
        }

        public static void Alarm(int[] TimeNow, int[] TimeSet)
        {
            if (Equal(TimeNow, TimeSet))
                Console.WriteLine($"闹钟响了！已经到 {TimeNow[0]} : {TimeNow[1]} : {TimeNow[2]}");
        }

        public static bool Equal(int[] TimeNow, int[] TimeSet)
        {
            bool res = true;
            for (int i = 0; i < 3; i ++ )
                res &= TimeNow[i] == TimeSet[i]; 
            return res;
        }
    }
}
