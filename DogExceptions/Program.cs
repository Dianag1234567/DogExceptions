using System;

namespace DogExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Dog dog = new Dog(-1, "a");
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ApplicationException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
