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
            Audio sing = new Audio("Scorpions", new DateTime(1990), "Classic rok", "Wind of Change", 4970250, new TimeSpan(0, 5, 10), 320);
            Image photo = new Image("Unknown", new DateTime(1990), "AlbumArt","Scorpions", 65536,"500x500");
            Video clip = new Video("Scorpions", new DateTime(1990), "Classic rok", "Wind of Change", 555, new TimeSpan(0, 5, 10), Quality.Best);
            AudioUrl sing1 = new AudioUrl("Scorpions", new DateTime(1990), "Classic rok", "Wind of Change", 4970250, new TimeSpan(0, 5, 10), 320, "http://mmm");
            ImageURL photo1 = new ImageURL("Unknown", new DateTime(1990), "AlbumArt", "Scorpions", 65536, "500x500", "http://mmm");
            VideoURL clip1 = new VideoURL("Scorpions", new DateTime(1990), "Classic rok", "Wind of Change", 555, new TimeSpan(0, 5, 10), Quality.Best, "http://mmm");


            Disk disk = new Disk("MyDisk", DateTime.Now);
            disk.Add(sing);
            disk.Add(photo);
            disk.Add(clip); // Error

            Serial serial = new Serial("MySerial",DateTime.Now);
            serial.Add(new Video("Scorpions", new DateTime(1990), "Classic rok", "Wind of Change", 555, new TimeSpan(0, 5, 10), Quality.Best));
            serial.Add( new Image("Unknown", new DateTime(1990), "AlbumArt", "Scorpions", 65536, "500x500"));
            serial.Add(new Audio("Scorpions", new DateTime(1990), "Classic rok", "Wind of Change", 4970250, new TimeSpan(0, 5, 10), 320)); // Error

            History history = new History("MyHistory", DateTime.Now);
            history.Add(photo);
            history.Add(photo1);
            history.Add(clip);
            history.Add(clip1);
            history.Add(sing); // Error
            
            Compilation comp = new Compilation("MyCompilation", DateTime.Now);
            comp.Add(sing);
            comp.Add(photo);
            comp.Add(sing1); //Error
        }
    }
}
