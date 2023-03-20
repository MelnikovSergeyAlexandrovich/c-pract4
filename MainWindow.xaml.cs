using System;
using System.Data;
using System.Windows;
using System.Windows.Forms;
using SecondPractTask.dataWPFDataSetTableAdapters;

namespace SecondPractTask
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
         pizzasTableAdapter Pizza = new pizzasTableAdapter();
         piesTableAdapter Pie = new piesTableAdapter();
         bakeryShopTableAdapter BakeryShop = new bakeryShopTableAdapter();
         sizesTableAdapter sizes = new sizesTableAdapter();
         shopsTableAdapter shops = new shopsTableAdapter(); 
         diameterTableAdapter diameter = new diameterTableAdapter();    
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window2 window2 = new Window2();
            window2.BakeryData.ItemsSource = BakeryShop.GetData();
            window2.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.PizzasData.ItemsSource = Pizza.GetData();
            //window1.ChooseItemComboBox.ItemsSource = window1.PizzasData.Columns;
            
            window1.Show();
            

        }

        private void PiesDataBaseButton_Click(object sender, RoutedEventArgs e)
        {
            Window3 window3 = new Window3();
            window3.PiesData.ItemsSource = Pie.GetData();
            window3.Show();
        }

        private void InputInfoDataBaseButton_Click(object sender, RoutedEventArgs e)
        {
            Window4 window4 = new Window4();

            window4.Show();
        }

        private void DiameterDataBaseButton_Click(object sender, RoutedEventArgs e)
        {
            Window6 window6 = new Window6();
            window6.DiameterData.ItemsSource = diameter.GetData();
            window6.Show();
        }

        private void SizesDataBaseButton_Click(object sender, RoutedEventArgs e)
        {
            Window5 window5 = new Window5();
            window5.SizesData.ItemsSource = sizes.GetData();
            window5.Show();
        }

        private void ShopsDataBaseButton_Click(object sender, RoutedEventArgs e)
        {
            Window7 window7 = new Window7();
            window7.ShopsData.ItemsSource = shops.GetData();
            window7.Show();
        }
    }
}
