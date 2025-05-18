using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.IO;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;
using System.Collections.ObjectModel;

namespace task_39_02
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// Создайте приложение – список покупок. Использовать ListBox. В качестве источника данных использовать не List а
    /// ObservableCollection
    /// Функции:
    ///• Ввод продуктов
    ///• Сохранение списка продуктов в текстовый файл
    ///• Использовать стандартные диалоговые окна
    public partial class MainWindow : Window
    {
        private ObservableCollection<string> products = new ObservableCollection<string>();

        public MainWindow()
        {
            InitializeComponent();
            productList.ItemsSource = products;
        }
       
        private void SaveFileButton_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog()
            {
                DefaultExt = ".txt",
                Title = "Сохранить",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            };

            try
            {
                if (saveFileDialog.ShowDialog() == true)
                {
                    string filePath = saveFileDialog.FileName;
                    using (System.IO.StreamWriter writer = new System.IO.StreamWriter(filePath))
                    {
                        foreach (var product in products)
                        {
                            writer.WriteLine(product);
                        }
                    }
                    MessageBox.Show("Список успешно сохранен!", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "ошибка",
                    MessageBoxButton.YesNoCancel,
                    MessageBoxImage.Warning);
            }
        } 
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string input = InputTextBox.Text.Trim();
                if (!string.IsNullOrEmpty(input))
                {
                    products.Add(input);
                    InputTextBox.Clear();
                }
                else
                {
                    MessageBox.Show("Пожалуйста, введите строку.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}