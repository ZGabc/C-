﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    internal class Book
    {

        public string title;
        public string author;
        public int pages;

        public Book() 
        {
            Console.WriteLine("Creating a book");
        }
    }
}