using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace Магазин_одежды
{
    /// <summary>
    /// Логика взаимодействия для Добваление_товара.xaml
    /// </summary>
    public partial class Добваление_товара : Window
    {
        МагазинEntities магазин;
        public Добваление_товара(МагазинEntities магазин1, Готовые_товары готовые)
        {
            InitializeComponent();
            this.магазин = магазин1;
            this.DataContext = готовые;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Ассортимент ассортимент = new Ассортимент();
            ассортимент.Show();
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            магазин.SaveChanges();
            Close();
        }
    }
}
