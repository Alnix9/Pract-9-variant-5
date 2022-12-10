using System;
using System.Collections.Generic;
using System.Drawing;
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

namespace Генеральский_практическая_9
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Height += 25;
        }
        List<Staff> _staff = new List<Staff>();

        private void Create(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(tbFIO.Text, out int FIO) & !int.TryParse(tbGender.Text, out int Gender) 
                & !int.TryParse(tbPost.Text, out int Post) & int.TryParse(tbWorkExperience.Text, out int WorkExperience) 
                & int.TryParse(tbSalary.Text, out int Salary))
            {
                _staff.Add(new Staff(tbFIO.Text, tbGender.Text, tbPost.Text, WorkExperience, Salary));
                StructGrid.ItemsSource = null;
                StructGrid.ItemsSource = _staff;
            }
            else MessageBox.Show("Ошибка");
        }

        private void Result(object sender, RoutedEventArgs e)
        {
            var avg = _staff.Average(x => x.Salary);
            MessageBox.Show(avg.ToString());
        }

        private void About_Programm(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("5. Заполнить таблицу со списком сотрудников на 7 человек с полями: ФИО, пол, \r\nдолжность, стаж работы, оклад. " +
                "Вывести результат на экран. Вывести средний \r\nоклад.");
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
