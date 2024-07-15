using ENV;
using ENV.Data;
using Firefly.Box;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Northwind.Traning.SimpleScreen.views
{
    public class ShowProductsLike : UIControllerBase
    {

        public readonly Models.Products Products = new Models.Products();
        public ShowProductsLike()
        {

            From = Products;
            Where.Add(Products.ProductName.StartsWith("C"));
        }

        public void Run()
        {
            Execute();
        }

        protected override void OnLoad()
        {
            View = () => new Views.ShowProductsLikeView(this);
        }
    }
}