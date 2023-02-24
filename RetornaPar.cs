using System;
using System.Collections.Generic;
using System.Text;

namespace MOTORSOFT_PROJECT
{
    internal class RetornaPar
    {


        void llenarArray()
        {
            int cont=0;
            int[] par = new int[50];

            while(cont >= 100)
            {


                if (cont % 2 == 0)
                {
                    par[cont] = cont;
                } 
                cont++;
            }
        }


    }
}
