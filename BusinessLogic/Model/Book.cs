using BusinessLogic.Model;
using System;

namespace BusinessLogic
{
    public class Book : ILibraryItem
    {
        public Guid LibraryItemNumber { get; set; }
        public string ItemName { get; set; }
        public DateTime CreatedOn { get; set; }

        public Book(Guid libItemNum, string libItemName, DateTime createdOn)
        {
            this.LibraryItemNumber = libItemNum;
            this.ItemName = libItemName;
            this.CreatedOn = createdOn;
        }
    }
}
