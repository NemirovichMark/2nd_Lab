using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SoloLearn
{
	class Program
	{
	    static double abs(double a){
	        if(a<0) return -a;
	        return a;
	    }
		static void Main(string[] args)
		{
		    double x,y;
		    Console.Write("Type the value of X: ");
		    if(!double.TryParse(Console.ReadLine(),out x)) return;
		    Console.Write("Type the value of Y: ");
		    if(!double.TryParse(Console.ReadLine(),out y)) return;
		    Console.Write("It is ");
		    if(y>=0&&y+abs(x)>1)  Console.Write("not ");
		    Console.WriteLine("in the triangle");
		}
	}
}
