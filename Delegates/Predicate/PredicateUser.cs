using CourseCSharp3.Delegates.Entities;

namespace Delegates.Predicate
{
    class ActionUser
    {
        public void PredicateShow()
        {


            List<Product> list = new List<Product>();
            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            //predicate, função
            list.RemoveAll(p => p.Price >= 100);

            foreach (var item in list)
            {
                Console.WriteLine("Predicate: "+item);
            }



        }
    }
}
