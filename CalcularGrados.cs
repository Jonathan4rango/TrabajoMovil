using System;
using System.Collections.Generic;
using System.Text;

namespace MOTORSOFT_PROJECT
{
    internal class CalcularGrados
    {
        CalcularGrados()
        {
            double result;

            result = Convert.ToDouble(Console.ReadLine());

           
            Console.WriteLine(ConvertirGrados(result));
        }

        double ConvertirGrados(double grados)
        {

    

            return (grados*1.8+32);



        }
    }
}
