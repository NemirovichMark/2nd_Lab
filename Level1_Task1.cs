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
		    double[] x = new double[]{0,1.5,1,3}, y = new double[]{2,0.7,1,0};
		    double r=2;
		    for(int i=0; i<4; i++){
		        Console.Write($"({x[i]},{y[i]})");
		        if(abs(x[i]*x[i]+y[i]*y[i]-r*r)>0.001) Console.WriteLine("doesn't lie on the circle");
		        else Console.WriteLine("lies on the circle");
		    }
		}
	}
}
