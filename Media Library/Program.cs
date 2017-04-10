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
            AudioUrl sing1 = new AudioUrl("Scorpions", 1990, "Classic rok", "Wind of Change", 4970250, 5.10, 320, "http://mmm");
            ImageURL photo1 = new ImageURL("Unknown", 1990, "AlbumArt", "Scorpions", 65536, "500x500", "http://mmm");
            VideoURL clip1 = new VideoURL("Scorpions", 1990, "Classic rok", "Wind of Change", 555, 5.10, Quality.Best, "http://mmm");
            // добавить подсчет размера

            Disk disk = new Disk();
            disk.Add(sing);
            disk.Add(photo);
            disk.Add(clip); // Error

            Serial serial = new Serial();
            serial.Add(new Video("Scorpions", 1990, "Classic rok", "Wind of Change", 555, 5.10, Quality.Best));
            serial.Add( new Image("Unknown", 1990, "AlbumArt", "Scorpions", 65536, "500x500"));
            serial.Add(new Audio("Scorpions", 1990, "Classic rok", "Wind of Change", 4970250, 5.10, 320)); // Error

            History history = new History();
            history.Add(photo);
            history.Add(photo1);
            history.Add(clip);
            history.Add(clip1);
            history.Add(sing); // Error

            Compilation comp = new Compilation();
            comp.Add(sing);
            comp.Add(photo);
            comp.Add(sing1); //Error
        }
    }
}
