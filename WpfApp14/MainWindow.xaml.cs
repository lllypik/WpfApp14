using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp14
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> products;

        public MainWindow()
        {
            InitializeComponent();

            products = new ObservableCollection<Product>();

            products.Add(new Product()
            {
                NameProduct = "Яблоки",
                PathImage = "Data/1.jpg",
                Price = 108.8,
                TypeProduct = TypesProduct.Food
            });

            products.Add(new Product()
            {
                NameProduct = "Телевизор",
                PathImage = "Data/2.jpg",
                Price = 108000,
                TypeProduct = TypesProduct.Appliances
            });

            products.Add(new Product()
            {
                NameProduct = "Мясо",
                PathImage = "Data/1.jpg",
                Price = 500,
                TypeProduct = TypesProduct.Food
            });

            products.Add(new Product()
            {
                NameProduct = "Микроволновка",
                PathImage = "Data/2.jpg",
                Price = 25000,
                TypeProduct = TypesProduct.Appliances
            });
            shoppingList.ItemsSource = products;
        }
    }
}
