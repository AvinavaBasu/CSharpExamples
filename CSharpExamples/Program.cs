using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExamples
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            //GetAvg();
            RectPlotCal rectCal= new RectPlotCal();
            rectCal.GetPlotPrice(1, 2);
            Console.ReadKey();
        }

        public static void GetAvg()
        {
            int sum = 0;
            Console.WriteLine("Enter the count of numbers you want in the arrary");
            var count = int.Parse(Console.ReadLine());
            int[] arr = new int[count];
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Enter the number for " +i + "th position" );
                arr[i]=int.Parse(Console.ReadLine());
                sum += arr[i];
            }
            int avg = sum / count;
            Console.WriteLine("The average is {0}",avg);
        }

        public interface IRectPlot
        {
           void GetPlotPrice(int l, int b);
        }

        public class RectPlotCal : IRectPlot
        {
            int l = 10;
            int b = 20;
            int price=0;

            //public RectPlotCal(int l,int b)
            //{
            //    //this.price = price;
            //    this.l = l;
            //    this.b = b;
            //}

            public void GetPlotPrice(int l, int b)
            {
                this.price = l * b;
                Console.WriteLine("The price is {0}",price);
            }
        }
    }
}
