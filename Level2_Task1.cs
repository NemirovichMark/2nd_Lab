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
		    #region Level 2 Task 1
		    Console.WriteLine("Enter N: ");
		    int n;
		    double sum;
		    if(!int.TryParse(Console.ReadLine(),out n))
    			return;
		    double studet_height;
		    for(int i=0; i<n; i++){
    		        Console.Write($"Enter {i} students height: ");
    			if(!int.TryParse(Console.ReadLine(),out student_height));
        		    return;
    			sum+=student_height;
		    }
		    Console.Write($"Average students height is {sum/n}");
		    #endregion 
		}
	}
}
