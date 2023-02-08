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
    /// Логика взаимодействия для Ассортимент.xaml
    /// </summary>
    public partial class Ассортимент : Window
    {
        МагазинEntities магазин { get; set; }
        public Ассортимент()
        {
            магазин = new МагазинEntities();
            InitializeComponent();
            tableТовар.ItemsSource = магазин.Готовые_товары.ToList();
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
            List<Готовые_товары> товары = магазин.Готовые_товары.ToList();
            товары = товары.Where(x => x.Ресунок_украшения.ToLower().Contains(search.Text.ToLower())).ToList();
            tableТовар.ItemsSource = товары.OrderBy(x => x.Код).ToList();
        }
        private void update()
        {
            tableТовар.ItemsSource = магазин.Готовые_товары.ToList();
            tableТовар.Items.Refresh();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var add = new Готовые_товары();
            магазин.Готовые_товары.Add(add);
            var add1 = new Добваление_товара(магазин, add);
            add1.ShowDialog();
            update();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var del = tableТовар.SelectedItem as Готовые_товары;
            if (del == null)
            {
                MessageBox.Show("Выберите строку");
                return;
            }
            магазин.Готовые_товары.Remove(del);
            магазин.SaveChanges();
            update();
        }
    }
}
