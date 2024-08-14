using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Class_Attributes
{
    class Song
    {
        public string title;
        public string artist;
        public int duration;

        //create a static attribute
        public static int songCount = 0;

        
        //CONSTRUCTOR METHOD
        public Song(string aTitle, string aArtist, int aDuration)
        {
            title = aTitle;
            artist = aArtist;
            duration = aDuration;
            songCount++;
        }

        public int getSongCount()
        {
            return songCount;
        }

    }
}
