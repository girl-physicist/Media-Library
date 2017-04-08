using Media_Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Library.Classes
{
   public class Video : PlayableItem, IVideoItem
    {
        public Quality Quality
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
