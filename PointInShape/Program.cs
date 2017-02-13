using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInShape
{
    class Program
    {
        static void Main(string[] args)
        {

            float inputX1 = float.Parse(Console.ReadLine());
            float inputY1 = float.Parse(Console.ReadLine());
            float inputX2 = float.Parse(Console.ReadLine());
            float inputY2 = float.Parse(Console.ReadLine());
            float inputPointX = float.Parse(Console.ReadLine());
            float inputPointY = float.Parse(Console.ReadLine());
            if (inputPointX >= inputX1 && inputPointX <= inputX2 &&inputPointY >= inputY1&&inputPointY<=inputY2)
            {
                Console.WriteLine("Inside");   
            }
            else
            {
                Console.WriteLine("Outside");
            }
        }
    }
}
