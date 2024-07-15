using ENV;
using ENV.Data;
using Firefly.Box;
using Firefly.Box.UI.Advanced;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Northwind.Traning.SimpleScreen.views.Views
{
    partial class ShowProductsLikeView : Shared.Theme.Controls.Form
    {
        ShowProductsLike _controller;
        public ShowProductsLikeView(ShowProductsLike controller)
        {
            _controller = controller;
            InitializeComponent();
        }

        private void grid1_Click(object sender, EventArgs e)
        {

        }

        private void gcUnitsInStock_Click(object sender, EventArgs e)
        {

        }
    }
}