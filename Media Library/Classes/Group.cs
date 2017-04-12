using Media_Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Media_Library.Classes
{
    public class Group : IGroup, ICollection<IMediaItem>
    {
       public ICollection<IMediaItem> mediaItems = new List<IMediaItem>();

       
       
        public DateTime DateOfCreation
        {
            get;
        }

        public string Name
        {
            get;
        }

        public int Count
        {
            get
            {
                return mediaItems.Count;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return mediaItems.IsReadOnly;
            }
        }
        public void Add(IMediaItem item)
        {
            mediaItems.Add(item);
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

        public bool Remove(IMediaItem item)
        {
            return mediaItems.Remove(item);
        }

        public IEnumerator<IMediaItem> GetEnumerator()
        {
            return mediaItems.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return mediaItems.GetEnumerator();
        }
        public Group(string name, DateTime dateOfCreation)
        {
            Name = name;
            DateOfCreation = dateOfCreation;
        }
    }
}
