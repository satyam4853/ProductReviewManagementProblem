using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ProductReviewManagementWithLinq
{
  public  class Management
    {
        public readonly DataTable dataTable = new DataTable();
            //UC2
            public void TopRecords(List<ProductReview> listProductReview)
        {
            var recoededdata = (from ProductReview in listProductReview
                                orderby ProductReview.Rating descending
                                select ProductReview).Take(3);
            foreach (var list in recoededdata)

            {
                Console.WriteLine("ProductId:-" + list.ProductID + " " + "UserId:-" + list.UserID + " " + "Rating:-" + list.Rating + " " + "Review:-" + list.Review + "" + "isLike:-" + list.isLike);


            }
        }
        //UC3
        public void SelectRecords(List<ProductReview> listProductReview)
        {
            var recordeddata = from ProductReview in listProductReview
                               where (ProductReview.ProductID == 1 || ProductReview.ProductID == 4 || ProductReview.ProductID == 9)
                               && ProductReview.Rating > 3
                               select ProductReview;

            foreach (var list in recordeddata)

            {
                Console.WriteLine("ProductId:-" + list.ProductID + " " + "UserId:-" + list.UserID + " " + "Rating:-" + list.Rating + " " + "Review:-" + list.Review + "" + "isLike:-" + list.isLike);


            }





        }


        //Uc4

        public void RetrieveCountOfRecords(List<ProductReview> listProductReview)
        {
            var recordedData = listProductReview.GroupBy(x => x.ProductID).Select(x => new { ProductId = x.Key, Count = x.Count() });

            foreach (var list in recordedData)
            {
                Console.WriteLine(list.ProductId + "------" + list.Count);
            }
        }


        //UC5
        public void RetrieveProductIDAndReview(List<ProductReview> list)
        {
            var recordedData = (from products in list
                                select new { products.ProductID, products.Review });
            foreach (var productReview in recordedData)
            {
                Console.WriteLine("Product ID: " + productReview.ProductID + "\tReviews: " + productReview.Review);
            }
        }


        //UC6
        public void SkipTopFive(List<ProductReview> list)
        {
            var recordedData = (from products in list
                                select products).Skip(5);
            foreach (var productReview in recordedData)
            {
                Console.WriteLine("ProductId : " + productReview.ProductID + " " + "UserId : " + " " + productReview.UserID
                    + " " + "Rating : " + productReview.Rating + " " + "Review : " + productReview.Review + " " + "IsLike : " + productReview.isLike);

            }
        }
        //UC7
        public void RetrieveProductIDAndReviewWithSelect(List<ProductReview> list)
        {
            var recordedData = list.Select(x => new { ProductID = x.ProductID, Review = x.Review });
            foreach (var productReview in recordedData)
            {
                Console.WriteLine("Product ID: " + productReview.ProductID + " Review: " + productReview.Review);
            }
        }

    }
}
