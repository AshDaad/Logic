using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moods_and_Fruit
{
    class Program
    {
        [Flags] enum Mood
        {

            HAPPY = 1,
            SAD = 2,
            THOUGHFUL = 4,
            BLISSFUL = 8,
            AMUSED = 16,
            ANNOYED = 24,

        };

        static void Main()
        {
            // ... These values are enum E types.
            var m1 = (Mood.HAPPY | Mood.BLISSFUL).ToString();
            Console.WriteLine(m1);

            var m2 = (Mood.HAPPY | Mood.AMUSED).ToString();
            Console.WriteLine(m2);

            var m3 = (Mood.SAD | Mood.ANNOYED).ToString();
            Console.WriteLine(m3);

            var m4 = (Mood.THOUGHFUL).ToString();
            Console.WriteLine(m4);

            var m5 = (Mood.THOUGHFUL | Mood.AMUSED | Mood.BLISSFUL).ToString();
            Console.WriteLine(m5);

            Console.Read();
        }
    }
}
