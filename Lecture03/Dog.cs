namespace Lecture03
{
    using static System.Console;

    public class Dog
    {
        public Dog(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public void Bury<T>(T thing) where T : IBuryable
        {
            WriteLine($"{Name} has burried in the back yard {thing}");
        }
    }
}
