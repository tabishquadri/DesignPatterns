using BusinessLogic.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Controller
{
    public interface IShelf
    {
        void AddItemToShelf(ILibraryItem item);
        bool RemoveItemFromShelf(Guid itemNumber);
        ILibraryItem FindItemById(Guid LibraryItemNumber);

    }
}
