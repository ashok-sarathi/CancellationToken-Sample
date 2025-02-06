namespace CqrsClient
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var client = new HttpClient()
            {
                BaseAddress = new Uri("https://localhost:7126")
            };

            var data1 = client.GetAsync("api/Product").Result;
            //Task.Delay(10000).Wait();
            //CancellationTokenSource cts = new CancellationTokenSource();
            //cts.CancelAfter(3000);
            //var data2 = await client.GetAsync("api/Product", cts.Token);
            //Console.ReadLine();
        }
    }
}
