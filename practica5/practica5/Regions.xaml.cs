using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
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
using Word = Microsoft.Office.Interop.Word;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;

namespace practica5
{
    /// <summary>
    /// Логика взаимодействия для Regions.xaml
    /// </summary>
    public partial class Regions : System.Windows.Window
    { public PracticaEntities1 pr = new PracticaEntities1(); 
        public Regions()
        {
            InitializeComponent();
            pr = new PracticaEntities1();
            pr.Region.Load();
            RegionT.DataContext = pr.Region.ToList();
        }
        private void RegionT_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void RegionT_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void RegionT_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {

        }
        //метод для удаления строки данных
        private void delete_Click(object sender, RoutedEventArgs e)
        {
            using (PracticaEntities1 db = new PracticaEntities1())
            {
                Region r1 = db.Region.FirstOrDefault();
                if (r1 != null)
                {
                    db.Region.Remove(r1);
                    db.SaveChanges();
                }
            }
        }
        //метод для создания новой строки данных
        private void newreg_Click(object sender, RoutedEventArgs e)
        {

            using (PracticaEntities1 db = new PracticaEntities1())
            {
                Region r1 = new Region {RegionID = Convert.ToInt32(regID.Text), RegionName = regname.Text, City = city.Text }; // добавление
                db.Region.Add(r1);
                db.SaveChanges();   // сохранение изменений
                var reg = db.Region.ToList();
            }
        }
        //метод для обновления отображения данных
        private void update_Click(object sender, RoutedEventArgs e)
        {
           pr = new PracticaEntities1();
            pr.Region.Load(); // загружаем данные
            RegionT.DataContext = pr.Region.ToList(); // устанавливаем привязку к кэшу

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow m = new MainWindow();
            m.Show();
            this.Close();
        }
        //метод для сохранения изменений
        private void savwchanges_Click(object sender, RoutedEventArgs e)
        {

            using (PracticaEntities1 db = new PracticaEntities1())
            {
                // получаем первый объект
                Region pr = db.Region.FirstOrDefault();
                pr.RegionID = Convert.ToInt32(regID.Text);
                pr.RegionName = regname.Text;
                pr.City = city.Text;
                db.SaveChanges();   // сохраняем изменения
            }
        }
    }
}
