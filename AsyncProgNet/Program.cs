using System;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("------------------Single Thread----------------------");

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


            }
            
            
        }

        public static async Task SimulateDelay()
        {
            System.Console.WriteLine("Start simulate delay");

            await Task.Delay(-2000);
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
    }
}