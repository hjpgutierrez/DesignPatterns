using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var ctx = new CompressionContext();
            Console.WriteLine("Please enter Fortmat Type : Rar or Zip");
            string fortmatType = Console.ReadLine();
            Console.WriteLine("Fortmat type is : " + fortmatType);
            
            if ("Zip".Equals(fortmatType, StringComparison.InvariantCultureIgnoreCase))
            {
                ctx.SetStrategy(new ZipCompression());
            }
            else if ("Rar".Equals(fortmatType, StringComparison.InvariantCultureIgnoreCase))
            {
                ctx.SetStrategy(new RarCompression());
            }

            ctx.CreateArchive("DotNetDesignPattern");
            Console.Read();
        }
    }
}
