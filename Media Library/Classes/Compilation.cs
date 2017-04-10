using Media_Library.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Library.Classes
{
    class Compilation :IGroup, ICollection<IMediaItem>
    {
        private ICollection<IMediaItem> mediaItems = new List<IMediaItem>();

        public int Count
        {
            get
            {
                return mediaItems.Count;
            }
        }

        public DateTime DateOfCreation
        {
            get;
        }

        public bool IsReadOnly
        {
            get
            {
                return mediaItems.IsReadOnly;
            }
        }

        public string Name
        {
            get;
        }

        public void Add(IMediaItem item)
        {
            // mediaItems.Add(item);
            if (item is Audio || item is Image)
            { mediaItems.Add(item); }
            else
            { throw new InvalidOperationException("Compilation can only consist of Audio and Image"); }
        }

        public void Clear()
        {
            mediaItems.Clear();
        }

        public bool Contains(IMediaItem item)
        {
            return mediaItems.Contains(item);
        }

        public void CopyTo(IMediaItem[] array, int arrayIndex)
        {
            mediaItems.CopyTo(array, arrayIndex);
        }

        public IEnumerator<IMediaItem> GetEnumerator()
        {
            return mediaItems.GetEnumerator();
        }

        public bool Remove(IMediaItem item)
        {
            return mediaItems.Remove(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return mediaItems.GetEnumerator();
        }
        public Compilation(string name, DateTime dateOfCreation)
        {
            Name = name;
            DateOfCreation = dateOfCreation;
        }
    }
}
