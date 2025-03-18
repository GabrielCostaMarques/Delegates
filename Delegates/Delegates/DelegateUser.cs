using CourseCSharp3.Delegates.Entities;

namespace CourseCSharp3.Delegates
{
    internal class DelegateUser
    {
        public void DelegateShow()
        {
            List<Product> list = [];

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Notebook", 1200.00));
            list.Add(new Product("Tablet", 450.00));


            //fazendo com lambda, sem ter que declarar uma função
            //Comparison<Product> comp=(p1,p2)=>p1.Name.ToLower().CompareTo(p2.Name.ToLower());

            ////////////////////////
            

            //usando lambda inline
            list.Sort((p1, p2) => p1.Name.ToLower().CompareTo(p2.Name.ToLower()));

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }



        //Delegate sendo criado, pode ser referenciado como list.Sort(CompareProducts)

        //static int CompareProducts(Product p1, Product p2)
        //{
        //    return p1.Name.ToLower().CompareTo(p2.Name.ToLower());
        //}
    }
}
