using System;

namespace Eigo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Out.WriteLine("(^_^)？ ");
            for (;;)
            {
                string line = Console.In.ReadLine();

                switch (line.Trim())
                {
                    case "bye": return;
                    default:
                        Console.Out.WriteLine("> " + line);
                        Console.Out.WriteLine("(^_^)ファット？ ");
                        break;
                }
            }
        }
    }
}
