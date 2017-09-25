
namespace Lecture03
{
    public class Shoe : IBuryable
    {
        public Shoe(string brand)
        {
            Brand = brand;
        }

        public string Brand { get; set; }

        public override string ToString()
        {
            return $"{Brand} shoe";
        }
    }
}
