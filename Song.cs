﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    internal class Song
    {
        public string title;
        public string artist;
        public double duration;
        public static int songCount = 0;

        public Song(string aTitle, string aArtist, double aDuration)
        {
            title = aTitle;
            artist = aArtist;
            duration = aDuration;
            songCount++;
        }

        public int getSongCount()
        { return songCount; }

    }
}
