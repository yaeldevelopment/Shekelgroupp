using ENV;
using ENV.Data;
using Firefly.Box;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Northwind.Views
{
    public class ShowProducts_n : UIControllerBase
    {

        public ShowProducts_n()
        {

        }

        public void Run()
        {
            Execute();
        }

        protected override void OnLoad()
        {
            View = () => new Views.ShowProducts_nView(this);
        }
    }
}