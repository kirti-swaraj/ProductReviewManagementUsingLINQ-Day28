// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ProductManagement.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Kirti Swaraj"/>
// --------------------------------------------------------------------------------------------------------------------
namespace ProductReviewManagement
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ProductManagement
    {
        /// <summary>
        /// UC 2 : Retrieves the top three high rated records.
        /// </summary>
        /// <param name="productList">The product list.</param>
        public static void RetrieveTopThreeHighRatedRecords(List<ProductReview> productList)
        {
            var retrievedData = (from products in productList
                                 orderby products.Rating descending
                                 select products).Take(3);
            Console.WriteLine("\nTop 3 high rated products are:");
            foreach (var v in retrievedData)
            {
                Console.WriteLine($"ProductID:{v.ProductID}\tUserID:{v.UserID}\tRating:{v.Rating}\tReview:{v.Review}\tIsLike:{v.IsLike}");
            }
        }
    }
}