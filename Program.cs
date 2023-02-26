namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {            

            var service = new Service(new AgrigatedLogger( new FileLogger(), new ConsoleLogger())); 

            var dic = new Dictionary<string, string>();
                        
            service.DoSome();


        }

    }
}