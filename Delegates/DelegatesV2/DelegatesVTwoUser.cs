using Course.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseCSharp3.DelegatesV2
{

    delegate double BinaryNumericOperation(double n1, double n2);

    internal class DelegatesVTwoUser
    {
        public void DelegatesVTwo()
        {
            double a = 10;
            double b = 20;

            BinaryNumericOperation op = CalculationService.Max;

            //invoke para invocar os paramâmetros da função maxs

            Console.WriteLine(op.Invoke(a, b));


        }
    }
}
