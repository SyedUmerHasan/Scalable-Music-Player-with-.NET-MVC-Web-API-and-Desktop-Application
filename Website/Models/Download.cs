//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Website.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Download
    {
        public int Download_Id { get; set; }
        public int Song_Id { get; set; }
        public int User_Id { get; set; }
    
        public virtual Song Song { get; set; }
        public virtual User User { get; set; }
    }
}
