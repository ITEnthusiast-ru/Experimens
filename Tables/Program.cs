namespace Tables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Table newTable = new Table();
            Constructor constructor = new Constructor(newTable);
            constructor.PrintTable();
            
        }

     
    }
}
