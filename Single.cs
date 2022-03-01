using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonClass
{
    internal class Single
    {

        //create private constructor to A singleton class is one which limits the number of objects creation to one.
        private Single() { }


        private static Single instance = new Single();

        public static Single getInsatance() 
            {
            Console.WriteLine("Here is singleton");
            return instance;
           
            }// this Instance is not similar to the instance that created above
    
            }
   
        
       
    
        
    }

