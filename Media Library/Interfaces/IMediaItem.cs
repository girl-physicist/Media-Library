using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Library.Interfaces
{
    interface IMediaItem
    {
        string Name { get; }
        string Author { get; }
        string Genre { get; }
        int Id     { get; }
        int Size { get; }
        DateTime DateOfCreation { get; }
    }
}
