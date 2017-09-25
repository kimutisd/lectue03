namespace Lecture03
{
    using System;
    using static System.Console;

    class Program
    {
        static void Main(string[] args)
        {
            // operator overloading
            // toString override
            Box randomBox = new Box(1, 1);
            Box anotherRandomBox = new Box(2, 2);
            Box combinedBoxes = randomBox + anotherRandomBox;

            WriteLine(randomBox.ToString());
            WriteLine(anotherRandomBox.ToString());
            WriteLine(combinedBoxes.ToString());

            ReadKey();
            WriteLine("------------------------------");

            // struct vs class
            Box box = new Box(3, 3);
            Car car = new Car("Red", "Audi");

            Box secondBox = box;
            Car secondCar = car;

            car.Colour = "Green";
            box.Width = 15;

            WriteLine(box.ToString());
            WriteLine(secondBox.ToString());

            WriteLine(car.ToString());
            WriteLine(secondCar.ToString());

            ReadKey();
            WriteLine("------------------------------");

            // switch
            WriteLine(DateUtilities.ConvertMonthNumberToMonthName(1));
            WriteLine(DateUtilities.ConvertMonthNumberToMonthName(DateTime.Now.Month));
            WriteLine(DateUtilities.ConvertMonthNumberToMonthName(39));

            ReadKey();
            WriteLine("------------------------------");

            // generic method
            Dog dog = new Dog("Bolt");
            dog.Bury(new Bone("Delicious"));
            dog.Bury(new Shoe("Gucci"));
            //dog.Bury(new Cat());

            ReadKey();
            WriteLine("------------------------------");

            // indexed property using generic class

            var names = new SampleCollection<string>();
            for (int i = 0; i < 100; i++)
            {
                names[i] = $"Imaginary name {i}";
            }

            WriteLine(names[2]);
            WriteLine(names[99]);

            ReadKey();
            WriteLine("------------------------------");
        }
    }
}
