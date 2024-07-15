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

namespace Northwind.Views.Views
{
    partial class ShowProductsView : Shared.Theme.Controls.Form
    {
        ShowProducts _controller;
        public ShowProductsView(ShowProducts controller)
        {
            _controller = controller;
            InitializeComponent();
        }
    }
}