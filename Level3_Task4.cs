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
			#region Level 2 Task 4
int n,c=0;
Console.Write("Enter n: ");
if(!int.TryParse(Console.ReadLine(),out n))
    return;
Console.Write("Enter r1 and r2: ");
double x,y,r1,r2;
if(!int.TryParse(Console.ReadLine(),out r1))
    return;
if(!int.TryParse(Console.ReadLine(),out r2))
    return;
for(int i=0;i<n;i++){
    Console.Write($"Enter x and y of the {i} point: ");
    if(!int.TryParse(Console.ReadLine(),out x))
        return;
    if(!int.TryParse(Console.ReadLine(),out y))
        return;
    if(x*x+y*y>=r1*r1 && x*x+y*y<=r2*r2) c++;
}
Console.Write($"There are {c} points in the ring");
#endregion
		}
	}
}
