using SecondPractTask.dataWPFDataSetTableAdapters;
using System;
using System.Data;
using System.Windows;

namespace SecondPractTask
{
    /// <summary>
    /// Логика взаимодействия для Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        piesTableAdapter Pie = new piesTableAdapter();
        public Window3()
        {
            InitializeComponent();
        }

        private void DeletePiesButton_Click(object sender, RoutedEventArgs e)
        {
            object id = (PiesData.SelectedItem as DataRowView).Row[0];
            Pie.DeleteQuery(Convert.ToInt32(id));
        }

        private void PiesChangeElementButton_Click(object sender, RoutedEventArgs e)
        {
            object id = (PiesData.SelectedItem as DataRowView).Row[0];
            Pie.UpdateQuery(PPTBfortext2.Text, Convert.ToInt32(id));
            
        }

        private void SelectionButton_Click(object sender, RoutedEventArgs e)
        {
            object pieTopping = (PiesData.SelectedItem as DataRowView).Row[1];
            PPTBfortext2.Text = Convert.ToString(pieTopping);
        }
    }
}
