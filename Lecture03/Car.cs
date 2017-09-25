namespace Lecture03
{
    public struct Car
    {
        public Car(string colour, string brand)
        {
            Colour = colour;
            Brand = brand;
        }

        public string Colour { get; set; }

        public string Brand { get; set; }

        public override string ToString()
        {
            return $"This is {Brand} car. Its coloured in {Colour}";
        }

    }
}
