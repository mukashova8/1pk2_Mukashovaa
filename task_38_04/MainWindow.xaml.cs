using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace task_38_04
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    ///
    /// Создайте окно для ввода информации о студенте (отдельно фамилия, имя , отчество, группа, пол – перечисление,
    //дата рождения(календарь))
    //При нажатии на кнопку «сохранить» данные о студенте сохраняются во внутренний список связанный с ListBox
    //При закрытии приложения данные сериализируются в файл
    public partial class MainWindow : Window
    {
        private Journal _journal = new();
        public MainWindow()
        {
            InitializeComponent();
            maleComboBox.SelectedIndex = 1;
            studentsListBox.ItemsSource = _journal.Students;
        }

        #region обработчики_Событий_WPF_элементов
        private void addStudentButton_Click(object sender, RoutedEventArgs e)
        {
            if (!Validate(out string errorMessage)) 
            {
                MessageBox.Show(errorMessage); 
                return; 
            }

            Student student = new Student(
                surnameTextBox.Text, 
                nameTextBox.Text,
                patronymicTextBox.Text,
                groupTextBox.Text,
                DateOnly.FromDateTime(datePicker1.SelectedDate.Value).ToString(),
            (Male)maleComboBox.SelectedIndex 
                );

            _journal.AddStudent(student); 

            studentsListBox.Items.Refresh();
            Clear();
        }

        private void clearStudentButton_Click(object sender, RoutedEventArgs e) 
        {
            Clear();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e) 
        {
            _journal.Load();
           studentsListBox.ItemsSource = _journal.Students;
        }
        private void Window_Closed(object sender, EventArgs e) 
        {
            _journal.Save();
        }

        private void deleteStudentMenuItem_Click(object sender, RoutedEventArgs e) 
        {
            var item = studentsListBox.SelectedItem;

            if (item != null && item is Student student)
            {
                _journal.RemoveStudent(student); 
                studentsListBox.Items.Refresh(); 
            }
        }
        private void showInfoMenuItem_Click(object sender, RoutedEventArgs e) 
        {
            ShowStudentInfo();
        }
        private void studentsListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            ShowStudentInfo();
        }
        #endregion

        #region вспомомагательные_методы
        private bool Validate(out string error) 
        {
            error = "";
            try 
            {
                DateOnly selectedDate = DateOnly.FromDateTime(datePicker1.SelectedDate.Value);
                DateOnly fourteenYearsAgo = DateOnly.FromDateTime(DateTime.Now.AddYears(-14));

                if (selectedDate > fourteenYearsAgo)
                {
                    error += "студенту должно быть больше 14 лет\n";
                }
            }
            catch (FormatException ex)
            {
                error = "Дата рождения не корректна\n";
            }

            if (string.IsNullOrEmpty(surnameTextBox.Text)) 
            {
                error += "поле Фамилия пусто\n";
            }
            if (string.IsNullOrEmpty(nameTextBox.Text))
            {
                error += "поле Имя пусто\n";
            }
            if (string.IsNullOrEmpty(patronymicTextBox.Text)) 
            {
                error += "поле Отчество пусто\n";
            }
            if (string.IsNullOrEmpty(groupTextBox.Text))
            {
                error += "поле Группа пусто\n";
            }

            if (error.Length > 0)
            {
                return false;
            }
            return true;
        }
        private void Clear()   
        {
            surnameTextBox.Clear();
            nameTextBox.Clear();
            patronymicTextBox.Clear();
            groupTextBox.Clear();
            datePicker1.SelectedDate=null;
            maleComboBox.SelectedIndex = 1;
        }
        private void ShowStudentInfo() 
        {
            var item = studentsListBox.SelectedItem;
            if (item != null && item is Student student)
            {
                MessageBox.Show($"ФИО: {student.Surname} {student.Name} {student.Patronymic}\n" +
                    $"Группа: {student.Group}\n" +
                    $"Год рождения: {student.Birthday}\n" +
                    $"Пол - {student.StringMale()}");
            }
        }
        #endregion
    }
}