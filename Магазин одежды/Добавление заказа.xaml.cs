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
    /// Логика взаимодействия для Добавление_заказа.xaml
    /// </summary>
    public partial class Добавление_заказа : Window
    {
        МагазинEntities магазин;
        public Добавление_заказа(МагазинEntities магазин1, Доставка доставка)
        {
            InitializeComponent();
            this.магазин = магазин1;
            this.DataContext = доставка;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Доставки доставки = new Доставки();
            доставки.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            магазин.SaveChanges();
            Close();
        }
    }
}
