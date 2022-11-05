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
    /// Логика взаимодействия для Price.xaml
    /// </summary>
    public partial class Price : System.Windows.Window
    { public PracticaEntities1 pr = new PracticaEntities1(); 
        public Price()
        {
            InitializeComponent();
            pr = new PracticaEntities1();
            pr.PriceList.Load();
            PriceT.DataContext = pr.PriceList.ToList();
        }
        private void PriceT_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void PriceT_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void PriceT_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {

        }
        //создание pdf файлв
        private void pdf_Click(object sender, RoutedEventArgs e)
        {

            var price = PracticaEntities1.GetContext().PriceList.OrderBy(x => x.PriceID).ToList();
            Word.Application app = new Word.Application();
            Word.Document document = app.Documents.Add();
            int startRowIndex = 1;
            Word.Paragraph paragraph = document.Paragraphs.Add();
            Word.Range range = paragraph.Range;
            range.Text = "Цена товаров";
            paragraph.set_Style("Заголовок 1");
            range.InsertParagraphAfter();
            Word.Paragraph tableParagraph = document.Paragraphs.Add();
            Word.Range tableRange = tableParagraph.Range;
            Word.Table table = document.Tables.Add(tableRange, price.Count() + 1, 8);
            Word.Range cellRange;
            cellRange = table.Cell(1, 1).Range;
            cellRange.Text = "Номер операции";
            cellRange = table.Cell(1, 2).Range;
            cellRange.Text = "Номер продукта";
            cellRange = table.Cell(1, 3).Range;
            cellRange.Text = "Номер комбината";
            cellRange = table.Cell(1, 4).Range;
            cellRange.Text = "Номер ответственного лица";
            cellRange = table.Cell(1, 5).Range;
            cellRange.Text = "Цена";
            cellRange = table.Cell(1, 6).Range;
            cellRange.Text = "Дата изменения";
            startRowIndex++;
            foreach (var item in price)
            {
                cellRange = table.Cell(startRowIndex, 1).Range;
                cellRange.Text = item.PriceID.ToString(); ;
                cellRange = table.Cell(startRowIndex, 2).Range;
                cellRange.Text = item.ProductID.ToString();
                cellRange = table.Cell(startRowIndex, 3).Range;
                cellRange.Text = item.PlantID.ToString();
                cellRange = table.Cell(startRowIndex, 4).Range;
                cellRange.Text = Convert.ToString(item.ResponsiblePersonID);
                cellRange = table.Cell(startRowIndex, 5).Range;
                cellRange.Text = item.Price.ToString();
                cellRange = table.Cell(startRowIndex, 6).Range;
                cellRange.Text = Convert.ToString(item.DateOfChange);
                startRowIndex++;
            }
            app.Visible = true;
            document.SaveAs2(@"C:\Users\uni\Report.docx");
            document.SaveAs2(@"C:\Users\uni\Report.pdf", Word.WdExportFormat.wdExportFormatPDF);
 
        }
        //метод для удаления строки данных
        private void delete_Click(object sender, RoutedEventArgs e)
        {
            using (PracticaEntities1 db = new PracticaEntities1())
            {
                PriceList r1 = db.PriceList.FirstOrDefault();
                if (r1 != null)
                {
                    db.PriceList.Remove(r1);
                    db.SaveChanges();
                }
            }
        }
        //метод для создания новой строки данных
        private void newprice_Click(object sender, RoutedEventArgs e)
        {

            using (PracticaEntities1 db = new PracticaEntities1())
            {
                PriceList r1 = new PriceList {PriceID = Convert.ToInt32(priceID.Text), ProductID = Convert.ToInt32(prID.Text),
                    PlantID = Convert.ToInt32(plID.Text),
                    ResponsiblePersonID = Convert.ToInt32(rpID.Text),
                    Price = Convert.ToInt32(price.Text),
                    DateOfChange = Convert.ToString(data.Text)
                }; // добавление
                db.PriceList.Add(r1);
                db.SaveChanges();   // сохранение изменений
                var reg = db.Region.ToList();
            }
        }
        //метод для обновления отображения данных
        private void update_Click(object sender, RoutedEventArgs e)
        {
            pr = new PracticaEntities1();
            pr.PriceList.Load(); // загружаем данные
            PriceT.DataContext = pr.PriceList.ToList(); // устанавливаем привязку к кэшу

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
        //метод для сохранения изменений
        private void savwchanges_Click(object sender, RoutedEventArgs e)
        {
            using (PracticaEntities1 db = new PracticaEntities1())
            {
                // получаем первый объект
                PriceList pr = db.PriceList.FirstOrDefault();
                pr.PriceID = Convert.ToInt32(priceID.Text);
                pr.ProductID = Convert.ToInt32(prID.Text);
                pr.PlantID = Convert.ToInt32(plID.Text);
                pr.ResponsiblePersonID = Convert.ToInt32(rpID.Text);
                pr.Price = Convert.ToInt32(price.Text);
                pr.DateOfChange = data.Text;
                db.SaveChanges();   // сохраняем изменения
            }
        }
    }
}
