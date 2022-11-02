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
			decimal p=1m,L=30000m,n=1;
            for(decimal i=1; p<=L; p*=(i+=3m)) n=i;
            Console.WriteLine("n = {0}",n);
		}
	}
}
