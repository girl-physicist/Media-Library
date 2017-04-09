using Media_Library.Classes;
using Media_Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Library
{
    class Program
    {
        static void Main(string[] args)
        {
            Audio sing = new Audio("Scorpions",1990,"Classic rok", "Wind of Change", 4970250, 5.10, 320);
            Image photo = new Image("Unknown",1990, "AlbumArt","Scorpions", 65536,"500x500");
            Video clip = new Video("Scorpions", 1990, "Classic rok", "Wind of Change", 555, 5.10,Quality.Best);
            // добавить подсчет размера
            Disk disk = new Disk("User",2017, "Classic rok","My favorite songs",65536, new List<IMediaItem>());
            disk.Items.Add(sing);
            disk.Items.Add(photo);
            disk.Items.Add(clip);
        }
    }
}
