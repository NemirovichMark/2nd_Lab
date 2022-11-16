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
            double A=0,B=0,S=0,p=0;
            string choice;
            bool f=false;
            Console.Write("Enter n: ");
            if(!int.TryParse(Console.ReadLine(),out n))
                return;
            for(int i=0; i<n; i++){
                f=false;
                Console.Write("Enter A: ");
                if(!double.TryParse(Console.ReadLine(),out A))
                    return;
                Console.Write("Enter B: ");
                if(!double.TryParse(Console.ReadLine(),out B))
                    return;
                A=abs(A);
                B=abs(B);
                f=(A+B<=A)||(A+A<=B);
                Console.Write("What do you want to do?\n-Find S of rectangle(1)\n-Find S of ring(2)\n-Find S of triangle(3)\nYour choice: ");
                choice=Console.ReadLine();
                switch(choice){
                    case "1":
                        S=A*B;
                        break;
                    case "2":
                        S=abs(Math.PI*A*A-Math.PI*B*B);
                        break;
                    case "3":
                        if(f){
                            Console.WriteLine("There is no triangle with these sides");
                            S=0;
                        }
                        else{
                            p=(A+A+B)/2;
                            S=Math.Sqrt(p*(p-A)*(p-A)*(p-B));
                        }
                        break;
                }
                Console.WriteLine($"The S equals: {S}");
            }
        }
        static double abs(double n){
            return n>0?n:-n;
        }
    }
}
