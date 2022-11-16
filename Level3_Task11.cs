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
            Console.Write("Enter n: ");
            if(!int.TryParse(Console.ReadLine(),out n))
                return;
            if(n==0) return;
            int lohi=0;
            double average=0,meat;
            bool f=false;
            for(int i=0; i<n; i++){
                for(int j=1; j<5; j++){
                    Console.Write($"Enter {j} exam of the {i+1} student: ");
                    if(!double.TryParse(Console.ReadLine(),out meat))
                        return;
                    average+=meat;
                    if(meat<3) f=true;
                }
                if(f) lohi++;
                f=false;
            }
            average/=(n*4);
            Console.Write($"Disapproved: {lohi}\nAverage: {average}");
        }
    }
}
