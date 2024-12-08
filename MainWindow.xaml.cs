using System;
using System.Linq;
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

namespace prog1
{
    public partial class MainWindow : Window
    {
        public Staff selectedStaff { get; set; }
        public List<Staff> Staffs { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            Staffs = new List<Staff>
            {
                new Staff(_id: 1, _fName: "Иванов", _name: "Иван", _pos: "Менеджер проекта", _div: "Управление", _hir: "2020-01-15", _sal: 70000),
                new Staff(2, "Петрова", "Анна", "Разработчик", "IT", "2019-03-22", 80000),
                new Staff(3, "Сидоров", "Алексей", "Аналитик", "Маркетинг", "2021-06-10", 60000),
                new Staff(4, "Смирнова", "Ольга", "Дизайнер", "Дизайн", "2022-02-05", 65000),
                new Staff(5, "Наумов", "Александр", "Специалист по продажам", "Продажи", "2020-11-30", 55000)
            };
            LoadData();
        }

        private void LoadData()
        {
            dataList.ItemsSource = Staffs.ToList();
        }

        private void ClearTextBox()
        { 
            txbId.Text = string.Empty;
            txbFirstName.Text = string.Empty;
            txbName.Text = string.Empty;
            txbPosition.Text = string.Empty;
            txbDiviion.Text = string.Empty;
            txbHired.Text = string.Empty;
            txbSalary.Text = string.Empty;
        }

        private void dataList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedStaff = (Staff)dataList.SelectedItem;
            if (selectedStaff != null)
            {
                txbId.Text = selectedStaff.Id.ToString();
                txbFirstName.Text = selectedStaff.FirstName;
                txbName.Text = selectedStaff.Name;
                txbPosition.Text = selectedStaff.Position;
                txbDiviion.Text = selectedStaff.Division;
                txbHired.Text = selectedStaff.Hired;
                txbSalary.Text = selectedStaff.Salary.ToString();
            }
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Staff staff = new Staff
            {
                Id = int.Parse(txbId.Text),
                FirstName = txbFirstName.Text,
                Name = txbName.Text,
                Position = txbPosition.Text,
                Division = txbDiviion.Text, 
                Hired = txbHired.Text,
                Salary = int.Parse(txbSalary.Text)
            };

            Staffs.Add(staff);
            LoadData();
            ClearTextBox();
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            if (selectedStaff != null)
            {
                selectedStaff.Id = int.Parse(txbId.Text);
                selectedStaff.FirstName = txbFirstName.Text;
                selectedStaff.Name = txbName.Text;
                selectedStaff.Division = txbDiviion.Text;
                selectedStaff.Position = txbPosition.Text;
                selectedStaff.Hired = txbHired.Text;
                selectedStaff.Salary = int.Parse(txbSalary.Text);
            }
            LoadData();
            ClearTextBox();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (selectedStaff != null)
            {
                Staffs.Remove(selectedStaff);
                LoadData();
                ClearTextBox();
            }
        }
    }
}