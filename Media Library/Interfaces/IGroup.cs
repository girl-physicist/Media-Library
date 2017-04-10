using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Library.Interfaces
{
    interface IGroup
    {
        string Name { get; }
        DateTime DateOfCreation { get; }
    }
}
