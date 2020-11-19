using System;
using System.ComponentModel.DataAnnotations;

namespace stickynotes.Models
{
    public class Sticky
    {
        public int ID { get; set; }
        public string Content { get; set; }
        public int Order { get; set; }
        

        
    }
}