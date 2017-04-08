using Media_Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Library.Classes
{
   public abstract class PlayableItem : IPlayableItem
    {
        public string Author
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public DateTime DateOfCreation
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public TimeSpan Duration
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string Genre
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int Id
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string Name
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int Size
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
