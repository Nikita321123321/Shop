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
    /// Логика взаимодействия для Добавление_клиента.xaml
    /// </summary>
    public partial class Добавление_клиента : Window
    {
        МагазинEntities магазин { get; set; } //ЗАДАЕТСЯ ПЕРЕМЕННАЯ С ПОДКЛЮЧЕННОЙ БАЗОЙ
        public Добавление_клиента(МагазинEntities магазинEntities, Клиент клиент)
        {
            InitializeComponent();
            магазин = магазинEntities;
            this.DataContext = клиент;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            магазин.SaveChanges(); //СОХРАНЕНИЕ И ИЗМЕНЕНИЕ В ТАБЛИЦЕ 
            Close(); //ЗАКРЫТИЕ ОКНА ДОБАВЛЕНИЯ
        }
    }
}
