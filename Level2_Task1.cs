using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SoloLearn
{
	class Program
	{
		static void Main(string[] args)
		{
		    double s=0,x,meat=1;
            if(!double.TryParse(Console.ReadLine(),out x)) return;
            for(int i=1; meat>=0.0001; i++){
                meat=Math.Cos(i*x)/(i*i);
                s+=meat;
            }
            Console.WriteLine($"S = {s}");
		}
	}
}
