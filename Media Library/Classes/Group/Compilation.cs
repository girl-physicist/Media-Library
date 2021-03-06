﻿using Media_Library.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Library.Classes
{
    class Compilation : Group
    {
        public Compilation(string name, DateTime dateOfCreation) : base(name, dateOfCreation)
        {
        }

        public new void Add(IMediaItem item)
        {
            // mediaItems.Add(item);
            if (item is Audio || item is Image)
            { p.Add(item);
                Console.WriteLine("item " + item.Name + " has been added.");
            }
            else
            {
                Console.WriteLine("item " + item.Name + " has not been added. Compilation can only consist of Audio and Image");
               
                //   throw new InvalidOperationException("Compilation can only consist of Audio and Image"); }
            }


        }
    }
}
