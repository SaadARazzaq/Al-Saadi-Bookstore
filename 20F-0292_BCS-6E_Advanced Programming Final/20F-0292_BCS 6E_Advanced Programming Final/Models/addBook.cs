namespace _20F_0292_BCS_6E_Advanced_Programming_Final.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class addBook
    {
        [Key]
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public string Availability { get; set; }
    }
}
