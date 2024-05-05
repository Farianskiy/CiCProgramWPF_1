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

namespace CiCProgramWPF_1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ShowGraphicButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int digit = int.Parse(InputTextBox.Text);
                string[] graphicRepresentation = GetGraphicRepresentation(digit);
                OutputStackPanel.Children.Clear();

                foreach (string line in graphicRepresentation)
                {
                    TextBlock textBlock = new TextBlock();
                    textBlock.Text = line;
                    textBlock.TextAlignment = TextAlignment.Center;
                    textBlock.VerticalAlignment = VerticalAlignment.Center;
                    OutputStackPanel.Children.Add(textBlock);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите корректное число.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Число должно быть в диапазоне от 0 до 9.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        public string[] GetGraphicRepresentation(int digit)
        {
            switch (digit)
            {
                case 0:
                    return new string[]
                    {
                        "##",
                        "##",
                        "##",
                        "##"
                    };
                case 1:
                    return new string[]
                    {
                        ".#",
                        "##",
                        ".#",
                        ".#"
                    };
                case 2:
                    return new string[]
                    {
                        "##",
                        ".#",
                        "##",
                        "##"
                    };
                case 3:
                    return new string[]
                    {
                        "##",
                        ".#",
                        ".#",
                        "##"
                    };
                case 4:
                    return new string[]
                    {
                        "##",
                        "##",
                        ".#",
                        ".#"
                    };
                case 5:
                    return new string[]
                    {
                        "##",
                        "#.",
                        ".#",
                        "##"
                    };
                case 6:
                    return new string[]
                    {
                        ".#",
                        "#.",
                        "##",
                        "##"
                    };
                case 7:
                    return new string[]
                    {
                        "##",
                        ".#",
                        "#.",
                        "#."
                    };
                case 8:
                    return new string[]
                    {
                        "##",
                        "..",
                        "##",
                        "##"
                    };
                case 9:
                    return new string[]
                    {
                        "##",
                        "##",
                        ".#",
                        "#."
                    };
                default:
                    throw new ArgumentException("Число должно быть в диапазоне от 0 до 9.");
            }
        }
    }
}
