using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Model
{
    public interface ILibraryItem
    {
        Guid LibraryItemNumber { get; set; }
        DateTime CreatedOn { get; set; }
    }

    public enum LibraryItemType
    {
        Book,
        Magzine
    }
    
}
