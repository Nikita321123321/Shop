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
    /// Логика взаимодействия для Доставки.xaml
    /// </summary>
    public partial class Доставки : Window
    {
        МагазинEntities магазин { get; set; }
        public Доставки()
        {
            магазин = new МагазинEntities();
            InitializeComponent();
            tableДоставка.ItemsSource = магазин.Доставка.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Основное основное = new Основное();
            основное.Show();
            Close();
        }
        private void search_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (search.Text == null)
            {
                return;
            }
            List<Доставка> доставка = магазин.Доставка.ToList();
            доставка = доставка.Where(x => x.Дата_доставки.ToLower().Contains(search.Text.ToLower())).ToList();
            tableДоставка.ItemsSource = доставка.OrderBy(x => x.Код).ToList();
        }
        private void update()
        {
            tableДоставка.ItemsSource = магазин.Доставка.ToList();
            tableДоставка.Items.Refresh();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var add = new Доставка();
            магазин.Доставка.Add(add);
            var add1 = new Добавление_заказа(магазин, add);
            add1.ShowDialog();
            update();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var del = tableДоставка.SelectedItem as Доставка;
            if (del == null)
            {
                MessageBox.Show("Выберите строку");
                return;
            }
            магазин.Доставка.Remove(del);
            магазин.SaveChanges();
            update();
        }
    }
}
