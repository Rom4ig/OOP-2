﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace SampleMVVM.Models
{
    class Book
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Count { get; set; }

        public Book(string title, string author, int count)
        {
            this.Title = title;
            this.Author = author;
            this.Count = count;
        }
        public Book ()
        {

        }
    }
}
