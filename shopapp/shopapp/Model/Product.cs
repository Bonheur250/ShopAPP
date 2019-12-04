using System;
using System.ComponentModel.DataAnnotations;

namespace shopapp.Model
{
    public class Product
    {
    public int id { get; set; }
            public string product_name { get; set; }
            public string product_description { get; set; }
            public float product_price { get; set; }
            public string product_image { get; set; }

            public int Quantity { get; set; }
        }

    }
