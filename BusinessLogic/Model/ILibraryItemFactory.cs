using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Model
{
    public interface ILibraryItemFactory
    {
        ILibraryItem GetLibraryItem(LibraryItemType ItemType, string ItemName);
    }
}
