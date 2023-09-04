using Microsoft.VisualBasic;
using ProductReviewManagement;
using System.Collections.Generic;

namespace ProductReviewManagement
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            list.Add(new Product()
            {
                ProductID = 1,
                UserID = 1,
                Rating = 1,
                Review ="BAD",
                IsLike = false,
            });
            list.Add(new Product()
            {
                ProductID = 2,
                UserID = 2,
                Rating = 2,
                Review = "NeedTOImprove",
                IsLike = false,
            });
            list.Add(new Product()
            {
                ProductID = 3,
                UserID = 3,
                Rating = 3,
                Review = "Average",
                IsLike = true,
            });
            list.Add(new Product()
            {
                ProductID = 4,
                UserID = 4,
                Rating = 4,
                Review = "Good",
                IsLike = true,
            });
            list.Add(new Product()
            {
                ProductID = 5,
                UserID = 5,
                Rating = 5,
                Review = "VGood",
                IsLike = true,
            });
            list.Add(new Product()
            {
                ProductID = 6,
                UserID = 6,
                Rating = 5,
                Review = "VGood",
                IsLike = true,
            });
            list.Add(new Product()
            {
                ProductID = 7,
                UserID = 7,
                Rating = 3,
                Review = "Average",
                IsLike = true,
            });
            list.Add(new Product()
            {
                ProductID = 8,
                UserID = 8,
                Rating = 4,
                Review = "Good",
                IsLike = true,
            });
            list.Add(new Product()
            {
                ProductID = 9,
                UserID = 9,
                Rating = 1,
                Review = "BAD",
                IsLike = false,
            });
            list.Add(new Product()
            {
                ProductID = 10,
                UserID = 10,
                Rating = 1,
                Review = "BAD",
                IsLike = false,
            });
            list.Add(new Product()
            {
                ProductID = 11,
                UserID = 11,
                Rating = 4,
                Review = "Good",
                IsLike = true,
            });
            list.Add(new Product()
            {
                ProductID = 12,
                UserID = 12,
                Rating = 4,
                Review = "Good",
                IsLike = true,
            });
            list.Add(new Product()
            {
                ProductID = 13,
                UserID = 13,
                Rating = 5,
                Review = "VGood",
                IsLike = true,
            });
            list.Add(new Product()
            {
                ProductID = 14,
                UserID = 14,
                Rating = 3,
                Review = "Average",
                IsLike = true,
            });
            list.Add(new Product()
            {
                ProductID = 15,
                UserID = 15,
                Rating = 1,
                Review = "BAD",
                IsLike = false,
            });
            list.Add(new Product()
            {
                ProductID = 16,
                UserID = 10,
                Rating = 3,
                Review = "Average",
                IsLike = true,
            });
            list.Add(new Product()
            {
                ProductID = 17,
                UserID = 10,
                Rating = 2,
                Review = "NeedTOImprove",
                IsLike = false,
            });
            list.Add(new Product()
            {
                ProductID = 18,
                UserID = 10,
                Rating = 2,
                Review = "NeedTOImprove",
                IsLike = false,
            });
            list.Add(new Product()
            {
                ProductID = 19,
                UserID = 10,
                Rating = 3,
                Review = "Average",
                IsLike = true,
            });
            list.Add(new Product()
            {
                ProductID = 20,
                UserID = 10,
                Rating = 5,
                Review = "VGood",
                IsLike = true,
            });

            Operations operations = new Operations();
            Console.WriteLine("RetriveTopRecords");
            operations.RetrieveTopRecords(list);

         
            operations.Display(list);
            

            

        }
    }

    
}

