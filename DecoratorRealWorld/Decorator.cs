﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorRealWorld
{
    public abstract class Decorator : LibraryItem
    {
        protected LibraryItem libraryItem;
        public Decorator(LibraryItem libraryItem)
        {
            this.libraryItem = libraryItem;
        }
        public override void Display()
        {
            libraryItem.Display();
        }
    }
}
