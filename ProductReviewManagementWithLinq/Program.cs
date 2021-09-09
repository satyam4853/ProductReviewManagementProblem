using System;
using System.Collections.Generic;

namespace ProductReviewManagementWithLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //UC1
            List<ProductReview> productReviewlist = new List<ProductReview>()
            {
                new ProductReview(){ProductID=1,UserID=1,Rating=5,Review="Good",isLike=true},
                new ProductReview(){ProductID=2,UserID=1,Rating=4,Review="Good",isLike=true},
                new ProductReview(){ProductID=3,UserID=2,Rating=4,Review="Good",isLike=true},
                new ProductReview(){ProductID=4,UserID=2,Rating=2,Review="Good",isLike=true},
                new ProductReview(){ProductID=5,UserID=3,Rating=1,Review="nice",isLike=false},
                new ProductReview(){ProductID=6,UserID=4,Rating=1.5,Review="bad",isLike=true},
                new ProductReview(){ProductID=7,UserID=3,Rating=4,Review="nice",isLike=false},
                new ProductReview(){ProductID=8,UserID=10,Rating=4,Review="nice",isLike=true},
                new ProductReview(){ProductID=9,UserID=10,Rating=4,Review="nice",isLike=true},
                new ProductReview(){ProductID=10,UserID=10,Rating=4,Review="nice",isLike=true},
                new ProductReview(){ProductID=11,UserID=10,Rating=4,Review="nice",isLike=true},
                new ProductReview(){ProductID=12,UserID=10,Rating=4,Review="nice",isLike=true},
            };
            //foreach (var list in productReviewlist)
            //{
            //    Console.WriteLine("ProductId:-" +list.ProductID +" "+ "UserId:-" +list.UserID + " " + "Rating:-" +list.Rating + " " + "Review:-" +list.Review+""+"isLike:-" +list.isLike);

            //}

            Management management = new Management();
            //UC2
            management.TopRecords(productReviewlist);
            
            
            //UC3
            management.SelectRecords(productReviewlist);

            //UC4
            management.RetrieveCountOfRecords(productReviewlist);

            //UC5
            management.RetrieveProductIDAndReview(productReviewlist);

            //UC6
            management.SkipTopFive(productReviewlist);

            //UC7
            management.RetrieveProductIDAndReviewWithSelect(productReviewlist);
        }
    }
}
