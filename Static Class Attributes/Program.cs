using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Class_Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Song holiday = new Song("Holiday", "Hrvy", 200);
            Console.WriteLine(Song.songCount);
            Song birthday = new Song("Birthday", "Will.i.am", 140);

            Console.WriteLine(Song.songCount);
            Console.WriteLine(birthday.getSongCount());

            Console.ReadLine();
        }
    }
}
