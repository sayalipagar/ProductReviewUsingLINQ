using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewUsingLINQ
{
    public class ProductManagement
    {
        public static void RetrieveProductIDAndReviewUsingLambdaSyntax(List<ProductReview> list)
        {
            //Query Syntax using lambda
            var recordedData = list.Select(reviews => new { ProductId = reviews.ProductId, Review = reviews.Review });
            Console.WriteLine("\n Retrieving Product and Review from list");
            foreach (var productReview in recordedData)
            {
                Console.WriteLine("Product ID : " + productReview.ProductId + "\t" + "Review : " + productReview.Review);
            }
        }
    }
    }



