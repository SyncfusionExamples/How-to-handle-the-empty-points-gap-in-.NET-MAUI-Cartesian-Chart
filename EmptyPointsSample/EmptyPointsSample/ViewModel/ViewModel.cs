using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmptyPointsSample
{
    internal class ViewModel
    {
        public ObservableCollection<Model> ProductSales { get; set; }

        public ViewModel()
        {
            ProductSales = new ObservableCollection<Model>();
            ProductSales.Add(new Model() { Product = "Electronics", Sales = 60 });
            ProductSales.Add(new Model() { Product = "Clothing", Sales = 40 });
            ProductSales.Add(new Model() { Product = "Stationery", Sales = 50 });
            ProductSales.Add(new Model() { Product = "Groceries", Sales = double.NaN });
            ProductSales.Add(new Model() { Product = "Furniture", Sales = 70 });
            ProductSales.Add(new Model() { Product = "Toys", Sales = 30 });
            ProductSales.Add(new Model() { Product = "Beauty Products", Sales = 40 });
            ProductSales.Add(new Model() { Product = "Sports", Sales = double.NaN });
            ProductSales.Add(new Model() { Product = "Footwear", Sales = 50 });
            ProductSales.Add(new Model() { Product = "Books", Sales = 40 });
        }
    }
}
