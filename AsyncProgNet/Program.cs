using System;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {

            displayProdcutsAsync().GetAwaiter().GetResult();


            

            /* System.Console.WriteLine("------------------Single Thread----------------------");

                     string projectRoot = System.IO.Path.GetFullPath(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", ".."));
                     string filePath = System.IO.Path.Combine(projectRoot, "repo", "example.txt");

                     try
                     {

                         SimulateDelay().GetAwaiter().GetResult();

                         ReadFileAsync(filePath).GetAwaiter().GetResult();

                     }
                     catch (Exception ex)
                     {
                         System.Console.WriteLine(ex);


                     }

                     //multiple task
                     System.Console.WriteLine("------------------Multi Thread----------------------");

                     try
                     {

                         Task.WaitAll(SimulateDelay(), ReadFileAsync(filePath));

                     }
                     catch (Exception ex)
                     {
                         System.Console.WriteLine(ex);


                     }*/


        }

        public static async Task SimulateDelay()
        {
            System.Console.WriteLine("Start simulate delay");

            await Task.Delay(2000);
            System.Console.WriteLine("Operation completed after a delay");
        }

        public static async Task ReadFileAsync(string filePath)
        {

            System.Console.WriteLine("Start Reading file");
            await Task.Delay(3000);

            using (StreamReader reader = new StreamReader(filePath))
            {
                string content = await reader.ReadToEndAsync();
                System.Console.WriteLine(content);

            }

            System.Console.WriteLine("Reading Operation completed after a delay");

        }

        public static async Task<List<Product>> getProductsAsync()
        {
            System.Console.WriteLine("Getting products");



            List<Product> products = new List<Product>();

            for (int i = 0; i < 11; i++)
            {
                await Task.Delay(1000);
                Product product = new Product(
                        "" + i,
                        i * 33 + 25,
                        "Product number " + i
                    );
                products.Add(product);
                System.Console.WriteLine("NEW Product added\nData:" + product.ToString() + "\n----------------------------");
            }


            return products;
        }

        public static async Task displayProdcutsAsync()
        { 
            System.Console.WriteLine("------------------ Get Async Products ------------------");
            List<Product> products = new List<Product>();


            try
            {

                products = await getProductsAsync();


            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex);

            }

            if (products.Any())
            {
                System.Console.WriteLine("--------------------------- Products catched ---------------------------\n");
                foreach (Product p in products)
                {
                    System.Console.WriteLine("" + p.ToString() + "\n---------------------------");
                }
                return;
            }
            System.Console.WriteLine("Products empty error");


            
        }
       
    }
}