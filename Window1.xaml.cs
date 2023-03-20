using SecondPractTask.dataWPFDataSetTableAdapters;
using System;
using System.Data;
using System.Windows;


namespace SecondPractTask
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        pizzasTableAdapter Pizza = new pizzasTableAdapter();
        public Window1()
        {
            InitializeComponent();
            
        }
        
        

        private void DeletePizzaButton_Click(object sender, RoutedEventArgs e)
        {
            object id = (PizzasData.SelectedItem as DataRowView).Row[0];
            Pizza.DeleteQuery(Convert.ToInt32(id));
            
        }

        private void PChangeElementButton_Click(object sender, RoutedEventArgs e)
        {
            object id = (PizzasData.SelectedItem as DataRowView).Row[0];
            Pizza.UpdateQuery(PTBfortext.Text,Convert.ToInt32(PTBfortext2.Text),Convert.ToInt32(id));
        }

        private void SelectButton_Click(object sender, RoutedEventArgs e)
        {

            object pizzaName = (PizzasData.SelectedItem as DataRowView).Row[1];
            PTBfortext.Text = Convert.ToString(pizzaName);
            object pizzaPrice = (PizzasData.SelectedItem as DataRowView).Row[3];
            PTBfortext2.Text = Convert.ToString(pizzaPrice);
            
        }

    }
}
