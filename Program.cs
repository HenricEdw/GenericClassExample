using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsShowThisFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericClass<string> myGenericInstance = new GenericClass<string>();

            //Nu kan vi tilldela strängar till m_Data via
            //Data-propertyn. Vi har type safety
            myGenericInstance.Data = "Detta är en sträng";

            var genericClassInt = new GenericClass<int>();

            //Här blir nu m_data en int pga generics och vi har type safety igen
            genericClassInt.Data = 3;

            //Type safety göra attvi vet i design time vad det är för typ vi jobbar med. 
            //Strinfg eller int i det här fallet.
            //Kan även vara komplexa typer 
        }
    }
}
