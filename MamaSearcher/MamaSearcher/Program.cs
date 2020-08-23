using System;

namespace MamaSearcher
{
    class Program
    {
        static void Main(string[] args)
        {
            MamaSearcher mamaSearcher = new MamaSearcher();
            mamaSearcher.Subscribe("abc", ShowPatternInfo);
            mamaSearcher.PerformSearch("oooabc");
            
        }
        public static void ShowPatternInfo(int index, string pattern)
        {
            Console.WriteLine("the patten {0} start at the index {1}", pattern, index);
            Console.ReadLine();
        }

    }
    
}

