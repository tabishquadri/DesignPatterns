using BusinessLogic.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Controller
{
    public class Shelf : IShelf
    {
        Dictionary<Guid, ILibraryItem> LibraryShelf = new Dictionary<Guid, ILibraryItem>();
        public void AddItemToShelf(ILibraryItem item)
        {
            LibraryShelf.Add(item.LibraryItemNumber, item);
        }

        public ILibraryItem FindItemById(Guid LibraryItemNumber)
        {
            if (LibraryShelf.ContainsKey(LibraryItemNumber))
            {
                return LibraryShelf[LibraryItemNumber];
            }
            else
            {
                return null;
            }
        }

        public bool RemoveItemFromShelf(Guid itemNumber)
        {
            if (LibraryShelf.ContainsKey(itemNumber))
            {
                return LibraryShelf.Remove(itemNumber);
            }
            else
            {
                return false;
            }
        }
    }
}
