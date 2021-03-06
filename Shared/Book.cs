﻿using System;

namespace SharedLib
{
    public class Book
    {
        // WASM JSON deserialization from Blazor needs a public default constructor
        public Book()
        {
        }
        public Book(int bookId, string title, string publisher)
            => (BookId, Title, Publisher) = (bookId, title, publisher);
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Publisher { get; set; }
        public override string ToString() => Title;
    }
}
