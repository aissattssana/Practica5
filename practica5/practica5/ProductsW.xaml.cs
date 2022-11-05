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
    /// Логика взаимодействия для Products.xaml
    /// </summary>
    public partial class ProductsW : System.Windows.Window
    {
        public PracticaEntities1 pr = new PracticaEntities1();
        public ProductsW()
        {
            InitializeComponent();
            pr = new PracticaEntities1();
            pr.Product.Load();
            ProductT.DataContext = pr.Product.ToList();
        }
        private void ProductT_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ProductT_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void ProductT_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {

        }
        //метод для удаления строки данных
        private void delete_Click(object sender, RoutedEventArgs e)
        {
            using (PracticaEntities1 db = new PracticaEntities1())
            {
                Product r1 = db.Product.FirstOrDefault();
                if (r1 != null)
                {
                    db.Product.Remove(r1);
                    db.SaveChanges();
                }
            }
        }
        //метод для создания новой строки данных
        private void newreg_Click(object sender, RoutedEventArgs e)
        {
            using (PracticaEntities1 db = new PracticaEntities1())
            {
                Product r1 = new Product
                { ProductID = Convert.ToInt32(prID.Text), 
                  ProductName = prname.Text, 
                  ProductSort = prsort.Text,
                  ProductGroup = prgroup.Text}; // добавление
                db.Product.Add(r1);
                db.SaveChanges();   // сохранение изменений
                var reg = db.Product.ToList();
                prID.Text = "";
                prname.Text = "";
                prsort.Text = "";
                prgroup.Text = "";

            }
        }
        //метод для обновления отображения данных
        private void update_Click(object sender, RoutedEventArgs e)
        {
            pr = new PracticaEntities1();
            pr.Product.Load(); // загружаем данные
            ProductT.DataContext = pr.Product.ToList(); // устанавливаем привязку к кэшу

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
                Product pr = db.Product.FirstOrDefault();
                pr.ProductID = Convert.ToInt32(prID.Text);
                pr.ProductName = prname.Text;
                pr.ProductGroup = prgroup.Text;
                pr.ProductSort = prsort.Text;
                db.SaveChanges();   // сохраняем изменения
            }
        }
    }
}
