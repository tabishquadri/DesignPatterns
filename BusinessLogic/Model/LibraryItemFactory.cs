using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Model
{
    public static class LibraryItemFactory 
    {
        public static ILibraryItem GetLibraryItem(LibraryItemType ItemType, string ItemName)
        {
            ILibraryItem libraryItem;
            switch (ItemType)
            {
                case LibraryItemType.Book:
                    return libraryItem = new Book(new Guid(), ItemName, DateTime.Now);
                case LibraryItemType.Magzine:
                    return libraryItem = new Magzine(new Guid(), ItemName, DateTime.Now);
                default:
                    return null;
            }
        }

    }
}
