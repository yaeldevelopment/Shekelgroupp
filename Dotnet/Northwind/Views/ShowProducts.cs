using ENV;
using ENV.Data;
using Firefly.Box;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Northwind.Views
{
    public class ShowProducts : UIControllerBase
    {

        public readonly Northwind.Models.Products Products = new Northwind.Models.Products();
        public ShowProducts(string start_with)
        {
            From = Products;
            Where.Add(Products.ProductName.StartsWith(start_with));

        }

        public void Run()
        {
            Execute();
        }

        protected override void OnLoad()
        {
            View = () => new Views.ShowProductsView(this);
        }
    }
}