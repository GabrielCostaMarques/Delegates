using Delegates.Func.Entities;

using System.Linq;

namespace Delegates.Func
{
    class FuncUser
    {
        public void FuncShow()
        {


            List<ProductFunc> list1 = new List<ProductFunc>();
            list1.Add(new ProductFunc("Tv", 900.00));
            list1.Add(new ProductFunc("Mouse", 50.00));
            list1.Add(new ProductFunc("Tablet", 350.50));
            list1.Add(new ProductFunc("HD Case", 80.90));

            
            //modo lambda inline
            List<string> result = list1.Select(p => p.Name.ToUpper()).ToList();


            //modo lambda

            Func<ProductFunc, string> func = p => p.Name.ToUpper();

            //modo funcional
            List<string> result1 = list1.Select(func).ToList();
            List<string> result2 = list1.Select(NameUpper).ToList();

            foreach (string item in result)
            {
                Console.WriteLine(item);
            }
        }

        static string NameUpper(ProductFunc p)
        {
            return p.Name.ToUpper();
        }



    }
}
