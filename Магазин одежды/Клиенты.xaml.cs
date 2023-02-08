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
    /// Логика взаимодействия для Клиенты.xaml
    /// </summary>
    public partial class Клиенты : Window
    {
        МагазинEntities магазин { get; set; }
        Class1 class1;
        public Клиенты()
        {
            магазин = new МагазинEntities(); //ЗАДАЕТСЯ ПЕРЕМЕННАЯ С ПОДКЛЮЧЕННОЙ БАЗОЙ
            InitializeComponent();
            class1 = new Class1(); //ЗАДАЕТСЯ ПЕРЕМЕННАЯ С КЛАССОМ
            tableКлиент.ItemsSource = магазин.Клиент.ToList(); //ВЫВОДИТСЯ ТАБЛИЦА КЛИЕНТОВ НА ОКНО
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) //КНОПКА
        {
            var generator = class1.Generate(); //ЗАДАЕТСЯ ПЕРЕМЕННАЯ ГДЕ ПРОИСХОДИТ ГЕНЕРАЦИЯ СЛУЧАЙНЫХ КЛИЕНТОВ В КЛАССЕ
            магазин.Клиент.Add(generator); //СГЕНЕРИРОВАННЫЙ КЛЛЕНТ ПОЯВЛЯЕТСЯ В ТАБЛИЦЕ
            var добавление = new Добавление_клиента(магазин, generator); //СГЕНЕРИРОВАННЫЙ КЛИЕНТ ДОБАВЛЯЕТСЯ В ПУСТЫЕ ТЕКСТБОКСЫ В ОКНЕ ДОБАВЛЕНИЯ
            добавление.ShowDialog(); //ОТКРЫВАЕТСЯ ОКНО ДОБАВЛЕНИЯ
            update(); //ОБНОВЛЕНИЕ ТАБЛИЦЫ
        }
        private void update()
        {
            tableКлиент.ItemsSource = магазин.Клиент.ToList(); //ВЫВОД ТАБЛИЦЫ КЛИЕНТОВ
            tableКлиент.Items.Refresh(); //ОБНОВЛЕНИЕ ТАБЛИЦЫ КЛИЕНТОВ
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
            List<Клиент> клиент = магазин.Клиент.ToList();
            клиент = клиент.Where(x => x.Имя.ToLower().Contains(search.Text.ToLower())).ToList();
            tableКлиент.ItemsSource = клиент.OrderBy(x => x.Код).ToList();
        }
    }
}
