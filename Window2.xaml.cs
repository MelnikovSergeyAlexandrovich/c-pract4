using SecondPractTask.dataWPFDataSetTableAdapters;
using System;
using System.Data;
using System.Windows;


namespace SecondPractTask
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        bakeryShopTableAdapter BakeryShop = new bakeryShopTableAdapter();
        public Window2()
        {
            InitializeComponent();
        }

        private void DeleteBakeryButton_Click(object sender, RoutedEventArgs e)
        {
            object id = (BakeryData.SelectedItem as DataRowView).Row[0];
            BakeryShop.DeleteQuery(Convert.ToInt32(id));
        }

        
    }
}
