namespace CqrsClient
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Task.Delay(5000).GetAwaiter().GetResult();
            Task.Run(async () =>
            {
                try
                {
                    var client = new HttpClient()
                    {
                        BaseAddress = new Uri("https://localhost:7126")
                    };

                    var cts = new CancellationTokenSource(5000);
                    var data2 = client.GetAsync("api/Product", cts.Token);

                    await data2;
                    var i = 0;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }).GetAwaiter().GetResult();
        }
    }
}
