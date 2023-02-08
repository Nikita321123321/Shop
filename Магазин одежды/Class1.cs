using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Магазин_одежды
{
    class Class1
    {
        private Random random = new Random(); //ЗАДАЕТСЯ ПЕРЕМЕНАЯ С МЕТОДОМ РАНДОМ
        public Клиент Generate() //ГЕНЕРАЦИЯ СУЛЧАЙНЫХ КЛИЕНТОВ
        {
            return new Клиент
            {
                Имя = generateRandomString(random.Next(5, 15)),
                Фамилия = generateRandomString(random.Next(5, 15)),
                Улица = generateRandomString(random.Next(5, 15)),
                Дом = random.Next(1, 6),
                Телефон = generateRandomString1(random.Next(5, 15)),
            };

        }
        public string generateRandomString(int length) //МЕТОД ДЛЯ ГЕНЕРАЦИИ СЛУЧАЙНЫХ БУКВ
        {
            const string chars = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }
        public string generateRandomString1(int length) //МЕТОД ДЛЯ ГЕНЕРАЦИИ СЛУЧАЙНЫХ ЧИСЕЛ
        {
            const string chars = "0123456789";
            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
