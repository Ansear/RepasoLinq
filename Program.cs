using Demo01.Clases;
internal class Program
{
    private static void Main(string[] args)
    {
        Linq01 demoLinq01 = new Linq01();
        // demoLinq01.PrintData();

        Linq02 demoLinq02 = new Linq02();
        // var l = demoLinq02.OrderName();
        // l.ForEach(l => Console.WriteLine(l.Name));

        demoLinq02.InnerJoin();
    }
}