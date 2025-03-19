using CourseCSharp3.Delegates.Entities;
using Delegates.Predicate.Entities;

namespace Delegates.Action
{
    class ActionUser
    {
        public void ActionShow()
        {


            List<ProductAction> list1 = new List<ProductAction>();
            list1.Add(new ProductAction("Tv", 900.00));
            list1.Add(new ProductAction("Mouse", 50.00));
            list1.Add(new ProductAction("Tablet", 350.50));
            list1.Add(new ProductAction("HD Case", 80.90));


            //jeito em lambda
            Action<ProductAction> act = product => { product.Price += product.Price * 0.1; };

            //jeito inline
            list1.ForEach(product => { product.Price += product.Price * 0.1; });

            foreach (var item in list1)
            {
                Console.WriteLine(item);
            }


        }

        //jeito funcional
        static void UpdatePrice(ProductAction product)
        {
            product.Price += product.Price * 0.1;
        }

    }
}
