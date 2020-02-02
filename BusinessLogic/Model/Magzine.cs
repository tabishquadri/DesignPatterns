using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Model
{
    public class Magzine : ILibraryItem
    {
        public Guid LibraryItemNumber { get; set; }
        public string ItemName { get; set; }
        public DateTime CreatedOn { get; set; }

        public Magzine(Guid libItemNum, string libItemName, DateTime createdOn)
        {
            this.LibraryItemNumber = libItemNum;
            this.ItemName = libItemName;
            this.CreatedOn = createdOn;
        }    
    }
}
