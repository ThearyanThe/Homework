using System;
namespace program
{
    class Time
    {
        private int Hour;
        private int Minutes;
        private int Seconds;
        public int HOUR
        {
            get { return Hour; }
            set { Hour = value; }
        }
        public int MINUTES
        {
            get { return Minutes; }
            set { Minutes = value; }
        }
        public int SECONDS
        {
            get { return Seconds; }
            set { Seconds = value; }
        }
        public void cons() { }//کلاس مخرب

        public void cons(int HOUR, int MINUTES, int SECONDS)
        {
            if (MINUTES < 0 || MINUTES > 60)
            {
                Console.WriteLine("minutes must 0 to 60");
            }
            else if (HOUR < 0 || HOUR > 24)
            {
                Console.WriteLine("hour must 0 to 24");
            }
            else if (SECONDS < 0 || SECONDS > 60)
            {
                Console.WriteLine("seconds must 0 to 60");
            }
            else
            {
                Hour = HOUR;
                Minutes = MINUTES;
                Seconds = SECONDS;
            }
        }//کلاس سازنده
        public void turn()
        {
            if (Hour > 0 && Hour <= 12)
            {
                Console.WriteLine("time is :" + Hour + ":" + Minutes + ":" + Seconds + "AM");


            }
            else if (Hour > 12 && Hour <= 24)
            {
                Console.WriteLine("time is :" + (Hour - 12) + ":" + Minutes + ":" + Seconds + "PM");

            }
        }//تبدیل ساعت 


    }//End class Time
    class result
    {
        public static void Main()
        {

            Time newtime = new Time();
            Console.WriteLine("enter hour 0 to 24:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter minutes: 0 to 60");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter seconds: 0 to 60");
            int num3 = Convert.ToInt32(Console.ReadLine());

            newtime.cons(num1, num2, num3);
            newtime.turn();




        }
    }
}