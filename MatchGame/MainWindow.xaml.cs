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
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Net.WebRequestMethods;

namespace MatchGame
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            SetUpGame();
        }

        private void SetUpGame()
        {
            //Создание списка
            List<string> animalEmoji = new List<string>()
            {
              "😼", "😼",
              "🐼", "🐼",
              "🐸", "🐸",
              "🐶", "🐶",
              "🦁", "🦁",
              "🦒", "🦒",
              "🐭", "🐭",
              "🦝", "🦝",
            };
            //Создает новый генератор случайных чисел
            Random random = new Random();
            //находиткаждый текстблокв сетке
            foreach (TextBlock textBlock in mainGrid.Children.OfType<TextBlock>())
            {
             //Выбирает случайное число от 0 до кол-ва эмодзи, дает имя индекс
              int index = random.Next(animalEmoji.Count);
                //использует случайное число для выбора случайного эмодзи
              string nextEmoji = animalEmoji[index];
                //Обновляет текстблок случайным эмодзи из списка
                textBlock.Text = nextEmoji;
                //удаляет случайный эмодзи из списка
                animalEmoji.RemoveAt(index);
            }
        }
    }
}
