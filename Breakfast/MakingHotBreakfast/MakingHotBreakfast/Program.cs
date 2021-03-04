using System;
using System.Threading;
using System.Threading.Tasks;

namespace MakingHotBreakfast
{
    class Program
    {
        public static void prepIngredients()
        {
            Thread.Sleep(2000);
            Console.WriteLine("Preparing Ingredients....");

        }

        public static async Task<bool> MakeCoffee()
        {
            bool result = false;
            Console.WriteLine("Let's make coffee first:");
            await Task.Run(() =>
            {
                Thread.Sleep(2000);
                Console.WriteLine("     Coffee is ready :)");
                result = true;
            });
            return result;
        }

        public static async void CookEggs()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(2000);
                Console.WriteLine("Cooking Eggs");
            });
        }

        public static async void CookBacon()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(2000);
                Console.WriteLine("Cooking Bacon");
            });
        }

        public static async void ToastingBread()
        {
            await Task.Run(() => {
                Thread.Sleep(2000);
                Console.WriteLine("toasting Bread");
            });
        }

        public static async void MakeBreakfast()
        {
            prepIngredients();
            var coffee = await MakeCoffee();
            CookEggs();
            CookBacon();
            ToastingBread();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Let's make a yummy breakfast and make it warm with asynch and await!");
            MakeBreakfast();
            Console.ReadKey();
            Console.WriteLine("Bonne appetit!");
        }
    }
}
