using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearnExercises.Practice
{
    public class StaticMethod
    {
        public class Cat
        {
            public static int count = 0;
            public Cat()
            {
                count++;
                Console.WriteLine(count);
            }
        }
    }
}
