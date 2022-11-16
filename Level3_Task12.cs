using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sololearn
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            double r,S=0;
            string choice;
            Console.Write("Enter n: ");
            if(!int.TryParse(Console.ReadLine(),out n))
                return;
            for(int i=0; i<n; i++){
                Console.Write("Enter R: ");
                if(!double.TryParse(Console.ReadLine(),out r))
                    return;
                Console.Write("What do you want to do?\n-Find S of square(S)\n-Find S of circle(C)\n-Find S of triangle(T)\nYour choice: ");
                choice=Console.ReadLine();
                switch(choice){
                    case "S":
                        S=r*r;
                        break;
                    case "C":
                        S=Math.PI*r*r;
                        break;
                    case "T":
                        S=r*r*Math.Sqrt(3)/4;
                        break;
                }
                Console.WriteLine($"The S equals: {S}");
            }
        }
    }
}
