using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Library.Interfaces
{
   public interface IPlayableItem:IMediaItem
    {
       Double Duration { get; }
   // TimeSpan Duration { get; }
    }
}
