namespace ToolboxH1
{
    internal class Conditions
    {
        public static void SwitchCase1()
        {
            //var key = 

            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.NumPad1:
                case ConsoleKey.D1:
                    Console.WriteLine("You pressed 1");
                    break;
                case ConsoleKey.D2:
                    break;
                case ConsoleKey.D3:
                    break;
                default:
                    break;
            }
        }

        public static void SwitchCase2()
        {
            int i = 45;

            switch (i)
            {
                case < 30:
                    //RED, LOW HEALTH
                    break;
                case < 60:
                    //YELLOW, MEDIUM HEALTH
                    break;
                case < 100:
                    //GREEN, GOOD HEALTH
                    break;
                default:
                    //Full health. All is good.
                    break;

            }
        }

        public static void IfConditions()
        {
            int? i = 50;

            if (i < 30)
            {
                //RED, LOW HEALTH
            }
            else if (i < 60)
            {
                //YELLOW, MEDIUM HEALTH
            }
            //etc..

            if (i > 20 && i <60) Console.WriteLine("Do something...");

            if (i != null && (i < 20 || i > 60)) Console.WriteLine("Do something...");
        }
    }
}
