﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Week_10_Database.Models
{
    /// <summary>
    /// Lookup table containing the languages in which some AdventureWorks data is stored.
    /// </summary>
    public partial class Culture
    {
        public Culture()
        {
            ProductModelProductDescriptionCultures = new HashSet<ProductModelProductDescriptionCulture>();
        }

        /// <summary>
        /// Primary key for Culture records.
        /// </summary>
        public string CultureId { get; set; }
        /// <summary>
        /// Culture description.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Date and time the record was last updated.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

        public virtual ICollection<ProductModelProductDescriptionCulture> ProductModelProductDescriptionCultures { get; set; }
    }
}