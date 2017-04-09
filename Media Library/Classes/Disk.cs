using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Library.Classes
{
    class Disk : ICollection<Audio>
    {
        public int Count
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool IsReadOnly
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Add(Audio item)
        {
            throw new NotImplementedException();
        }

        public void Add(MediaItem item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(Audio item)
        {
            throw new NotImplementedException();
        }

        public bool Contains(MediaItem item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(Audio[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(MediaItem[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<MediaItem> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool Remove(Audio item)
        {
            throw new NotImplementedException();
        }

        public bool Remove(MediaItem item)
        {
            throw new NotImplementedException();
        }

        IEnumerator<Audio> IEnumerable<Audio>.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
 