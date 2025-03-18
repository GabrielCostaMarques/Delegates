using Course.Services;
using Delegates.MultiCastingDelegates;

namespace Delegates.MultiCastingDelegates
{
    delegate void BinaryNumericOperantion(double n1, double n2);
    internal class MultiCastingDelegatesUser
    {
        public void MultiCastingDelegatesShow()
        {
            double a = 10;
            double b = 55;

            BinaryNumericOperantion op = MultiCastingDelegatesServices.ShowSum;

            //multicasting, mostrando a soma e o máximo
            op += MultiCastingDelegatesServices.ShowMax;

            op.Invoke(b, a);
        }
    }
}
