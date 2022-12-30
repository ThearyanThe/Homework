using System;
namespace program
{
    class unit1
    {
        private double Meter;
        public double METER
        {
            get { return Meter; }
            set { Meter = value; }
        }

        public void cons() { }//کلاس مخرب

        public void cons(double METER)
        {


            Meter = METER;


        }//کلاس سازنده
        public void turn()
        {
            Console.WriteLine(Meter+" meter="+Meter*1.0936133+" yard");
        }//تبدیل واحد


    }//End class unit1
    class result
    {
        public static void Main()
        {

            unit1 newunit = new unit1();
            Console.WriteLine("enter the size in meter:");
            double num1 = Convert.ToInt32(Console.ReadLine());


            
            newunit.cons(num1);
            newunit.turn();




        }
    }
}