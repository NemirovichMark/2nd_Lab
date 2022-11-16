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
		    Console.Write("Enter N: ");
		    int n,b=0,g=0;
		    double sum=0,boys=0,girls=0,height;
		    string choice;
		    if(!int.TryParse(Console.ReadLine(),out n))
    			return;
		    for(int i=0; i<n; i++){
    		    Console.Write($"Enter {i+1} students height: ");
    			if(!double.TryParse(Console.ReadLine(),out height))
        		    return;
        		Console.Write("It is a boy(B) or girl(G): ");
        		choice = Console.ReadLine();
        		switch(choice){
        		    case "B":
        		        boys+=height;
        		        b++;
        		        break;
        		    case "G":
        		        girls+=height;
        		        g++;
        		        break;
        		}
		    }
		    Console.Write($"Average boys height: {boys/b}\nAverage girls height: {girls/g}");
		}
	}
}
