﻿using System;
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
        public void RetrieveTopRecords(List<Product> list)
        {
            var result = list.Where(x => x.Rating == 5).Take(3);
            Display(result.ToList());
        }
        public void Display(List<Product> list)
        {
            foreach (var data in list)
            {
                Console.WriteLine(data.ProductID);
                Console.WriteLine(data.UserID);
                Console.WriteLine(data.Rating);
                Console.WriteLine(data.Review);
                Console.WriteLine(data.IsLike);
                Console.WriteLine("====");

            }
        }

    }
}
