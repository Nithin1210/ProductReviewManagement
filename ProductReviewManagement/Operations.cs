using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement
{
    public class Operations
    {
        DataTable table =new DataTable();
        public void RetriveTopRecords(List<Product>list)
        {
            var result = list.Where(x => x.Rating == 5).Take(3);
            Display(result.ToList());
        }
        public void RetriveAllRecordsWithCondition(List<Product>list) 
        {
            var result = list.Where(x => x.Rating > 3 && (x.ProductID == 1 || x.ProductID == 20 || x.ProductID == 8));
            Display(result.ToList());
        }
        public void UsingGroupBy(List<Product> list)
        {
            var result = list.GroupBy(x => x.ProductID).Select(x => new { ProductID = x.Key, Count = x.Count() });
            foreach (var data in result) 
            {
                Console.WriteLine(data.ProductID+"  "+data.Count);
            }
        }
        public void RetriveProductIdAndReview(List<Product> list)
        {   
            var result = list.Select(x => new {ProductID =x.ProductID,Review=x.Review}); 
            foreach(var data in result)
            {
                Console.WriteLine(data.ProductID+" "+data.Review);
            }
        }
        public void SkipTopRecords(List<Product> list)
        {
            var result = list.Skip(5);
            Display(result.ToList());
        }

        public void AddDataToDataTabel(List<Product>list) 
        {
            table.Columns.Add("ProductId").DataType = typeof(Int32);
            table.Columns.Add("UsereId").DataType = typeof(Int32);
            table.Columns.Add("Rating").DataType = typeof(Int32);
            table.Columns.Add("Review").DataType = typeof(string);
            table.Columns.Add("IsLike").DataType = typeof(bool);
            foreach(var data in list) 
            {
                table.Rows.Add(data.ProductID,data.UserID,data.Rating,data.Review,data.IsLike);
            }
            foreach (var item in table.AsEnumerable())
            {
                Console.WriteLine(item.Field<int>("ProductId"));
                
            }
        }
        public void RetriveRecordsFromDataTable()
        {
            var result = table.AsEnumerable().Where(x => x.Field<bool>("IsLike").Equals(true));
            foreach (var item in result.AsEnumerable())
            {
                Console.WriteLine(item.Field<int>("ProductId"));
            }
        }
        public void AvgRating(List<Product>list)
        {
            var result =list.Average(x => x.Rating);
            Console.WriteLine(result);
        }
        public void RetriveUsingReview(List<Product> list)
        {
            var result = list.Where(x => x.Review.Equals("Good"));
            Display(result.ToList());
        }
        public void RetriveUsingRating(List<Product> list) 
        {
            var result = list.Where(x => x.UserID.Equals(10)).OrderBy(x => x.Rating);
            Display(result.ToList());
        }




        public void Display (List<Product> list)
        {
            foreach (var data in list)
            {
                Console.WriteLine(data.ProductID);
            }
        }


    }
}
