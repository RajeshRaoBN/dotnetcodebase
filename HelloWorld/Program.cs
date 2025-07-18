
namespace Demo
{
    class Data
    { 
        public void Rajesh()
        {
            Console.WriteLine("Hello Rajesh");
        }
        internal void Narayana()
        {
            Console.WriteLine("Hello Narayana");
        }
        private void Rao()
        {
            Console.WriteLine("Hello Rao");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Data data = new Data();
            data.Rajesh();
            data.Narayana();
            // data.Rao(); // This will cause a compile-time error since Rao is private

            Console.WriteLine("Hello, World!");
            Console.WriteLine("Welcome to dotnet programming");

            Console.WriteLine("Enter your name     ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
        }
    }
}