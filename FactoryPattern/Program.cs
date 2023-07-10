namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi, how are you today?");
            Console.ReadLine();
            Console.WriteLine("How can I help you?");
            Console.ReadLine();
            Console.WriteLine("We have preorders on some games if you are interested like Silent Hill 2 Remake, " +
                "Residen Evil X, and New Super Mario Odisey xtreme if you are interested");
            Console.ReadLine();
            Console.WriteLine("also we have new collectibles like the New Tomb raider Figure or the Game Of Thrones Chess Set" +
                "also the Picachu plush that talks and copy's sentenses");    
            string userInput = Console.ReadLine();

            IVideoGameStore instance = BillyTheVideoGameStore.BuySomething(userInput);
            instance.GameOfTheYear();
        }
    }
}
