//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Online_Store
{
    using System;
    using System.Collections.Generic;
    
    public partial class TblBook
    {
        public int BookId { get; set; }
        public Nullable<decimal> ISBN { get; set; }
        public string BookName { get; set; }
        public string BookPublisher { get; set; }
        public string BookAuthor { get; set; }
        public Nullable<int> BookPage { get; set; }
        public Nullable<decimal> BookPrice { get; set; }
        public Nullable<int> BookStock { get; set; }
        public byte[] BookImage { get; set; }
        public Nullable<int> BookPoint { get; set; }
        public Nullable<int> BookAmount { get; set; }
    }
}
