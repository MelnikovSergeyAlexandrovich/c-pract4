using SecondPractTask.dataWPFDataSetTableAdapters;
using System;
using System.Data;
using System.Windows;


namespace SecondPractTask
{
    /// <summary>
    /// Логика взаимодействия для Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        pizzasTableAdapter Pizza = new pizzasTableAdapter();
        piesTableAdapter Pie = new piesTableAdapter();
        bakeryShopTableAdapter BakeryShop = new bakeryShopTableAdapter();
        sizesTableAdapter sizes = new sizesTableAdapter();
        shopsTableAdapter shops = new shopsTableAdapter();
        diameterTableAdapter diameter = new diameterTableAdapter();
        public Window4()
        {
            InitializeComponent();
            PiesComboBox.ItemsSource = sizes.GetData();
            PiesComboBox.DisplayMemberPath = "value";
            PiesComboBox.SelectedValuePath = "size id";

            PizzasComboBox.ItemsSource = diameter.GetData();
            PizzasComboBox.DisplayMemberPath = "value";
            PizzasComboBox.SelectedValuePath = "diameter id";

            BakeryShopComboBox.ItemsSource = shops.GetData();
            BakeryShopComboBox.DisplayMemberPath = "value";
            BakeryShopComboBox.SelectedValuePath = "shops id";
        }

        private void CompleteOrderButton_Click(object sender, RoutedEventArgs e)
        {
            //Pie
            int sizeId = Convert.ToInt32(PiesComboBox.SelectedValue);
            var generedPie = Pie.GetInsertData(PiesInputDataTextBox.Text,sizeId);
            int pieId = (int)generedPie.Rows[0][0];

            //Pizza
            int diameter = Convert.ToInt32(PizzasComboBox.SelectedValue);
            var generedPizza = Pizza.InsertAndGet(PizzasInputDataTextBox.Text, diameter, Convert.ToInt32(PizzaPriceInputDataTextBox.Text));
            int pizzaID = (int)generedPizza.Rows[0][0];

            //BakeryShop
            int ShopId = Convert.ToInt32(BakeryShopComboBox.SelectedValue);
            BakeryShop.InsertQuery(pizzaID, pieId, ShopId);
        }


    }
}
