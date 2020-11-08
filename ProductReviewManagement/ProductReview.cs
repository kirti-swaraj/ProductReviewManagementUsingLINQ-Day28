// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ProductReview.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Kirti Swaraj"/>
// --------------------------------------------------------------------------------------------------------------------
namespace ProductReviewManagement
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// UC 1 : Class having mentioned properties
    /// </summary>
    public class ProductReview
    {
        public int ProductID { get; set; }
        public int UserID { get; set; }
        public double Rating { get; set; }
        public string Review { get; set; }
        public bool IsLike { get; set; }
    }
}