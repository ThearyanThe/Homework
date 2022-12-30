using System;
namespace program
{
    class length
    {
        private int x1;
        private int y1;
        private int x2;
        private int y2;
        public int XX1
        {
            get { return x1; }
            set { x1 = value; }
        }
        public int YY1
        {
            get { return y1; }
            set { y1 = value; }
        }
        public int XX2
        {
            get { return x2; }
            set { x2 = value; }
        }
        public int YY2
        {
            get { return y2; }
            set { y2 = value; }
        }

        public void cons() { }//کلاس مخرب

        public void cons(int X1, int X2, int Y1, int Y2)
        {
            if (X1 < 0 || X2 < 0 || Y1 < 0 || Y2 < 0)
            {
                Console.WriteLine("ERROR");
            }
            else
            {
                x1 = X1;
                y1 = Y1;
                x2 = X2;
                y2 = Y2;
            }
            


        }//کلاس سازنده
        public void calc()
        {
            double x=Math.Pow((x2-x1),2);
            double y=Math.Pow((y2-y1),2);
            double res=Math.Sqrt(x+y);
            Console.WriteLine("lenght="+res);
        }//محاسبه طول


    }//End class unit1
    class result
    {
        public static void Main()
        {

            length newlenght = new length();
            Console.WriteLine("enter the x1:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("enter the y1:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the x2:");
            int num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the y2:");
            int num4 = Convert.ToInt32(Console.ReadLine());


            newlenght.cons(num1,num2,num3,num4);
            newlenght.calc();




        }
    }
}