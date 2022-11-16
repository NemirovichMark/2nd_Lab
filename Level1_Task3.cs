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
		    double a,b,c;
		    Console.Write("Introduce the value of a: ");
		    if(!double.TryParse(Console.ReadLine(),out a)) return;
		    Console.Write("Introduce the value of b: ");
		    if(!double.TryParse(Console.ReadLine(),out b)) return;
		    if(a>0){
		        if(a>b) c=a;
		        else c=b;
		    }
		    else{
		        if(a<b) c=a;
		        else c=b;
		    }
		    Console.WriteLine($"c={c}");
		}
	}
}
