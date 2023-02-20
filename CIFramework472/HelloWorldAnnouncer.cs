namespace CIFramework472
{
    public class HelloWorldAnnouncer
    {
        public string Greetee { get; private set; }



        public HelloWorldAnnouncer(string greetee)
        {
            Greetee = greetee;
        }



        public string Greet() =>
            string.IsNullOrWhiteSpace(Greetee) ? "Hello, World!" : $"Hello, {Greetee}!";
    }
}