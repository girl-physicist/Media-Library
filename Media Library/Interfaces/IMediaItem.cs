using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Library.Interfaces
{
   public interface IMediaItem
    {
        string Name { get; }
        string Author { get; }
        string Genre { get; }
        int Size { get; }
        DateTime DateOfCreation { get; }
        void OpenItem();
        void GetTypeOfItem();
    }
}
