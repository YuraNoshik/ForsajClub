using Microsoft.Win32;
using System;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Media.Imaging;

namespace WpfAppVetclinic
{
    /// <summary>
    /// Логика взаимодействия для Dobalenie.xaml
    /// </summary>
    public partial class Dobalenie : Window
    {
        public Dobalenie()
        {
            InitializeComponent();
        }
        OpenFileDialog openFileDialog = new OpenFileDialog();
        BitmapImage uploadedImageBitmap;
        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            using (Dostavka1Entities usersEntities = new Dostavka1Entities())
            {
                var categories = usersEntities.Category.Select(x => x.categoryName).ToList();
                cbCategory.Text = "Все категории";
                foreach (var category in categories)
                {
                    cbCategory.Items.Add(category);
                }
                var producer = usersEntities.Producer.Select(x => x.producerName).ToList();
                cbProducer.Text = "Все производители";
                foreach (var producers in producer)
                {
                    cbProducer.Items.Add(producers);
                }
            }
        }
        string imagePath;
        byte[] imageBytes;


        private void buttonAddPhoto_Click(object sender, RoutedEventArgs e)
        {
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png, *.bmp)|*.jpg; *.jpeg; *.png; *.bmp|All files (*.*)|*.*";

            // Отображение диалогового окна и проверка результата
            if (openFileDialog.ShowDialog() == true)
            {
                // Создание объекта BitmapImage и загрузка изображения из выбранного файла
                uploadedImageBitmap = new BitmapImage(new Uri(openFileDialog.FileName));

                // Установка свойства источника изображения элемента Image
                imageAdd.Source = uploadedImageBitmap;

                imagePath = openFileDialog.FileName;


            }

            if (!string.IsNullOrEmpty(imagePath))
            {
                imageBytes = File.ReadAllBytes(imagePath);
                //...
            }
            else
            {
                // обработка ошибки
            }
        }
        private void buttonAdd_Click(object sender, RoutedEventArgs e)
        {
            using (Dostavka1Entities usersEntities = new Dostavka1Entities())
            {

                // Установка свойств диалогового окна для фильтрации файлов изображений

                Products products = new Products
                {
                    producerID = cbProducer.SelectedIndex + 1,
                    categoryID = cbCategory.SelectedIndex + 1,
                    productName = tbNameAdd.Text,
                    productDate = datePicker1.SelectedDate.Value,
                    productCost = Convert.ToDecimal(tbCostAdd.Text),
                    productPhoto = imageBytes,

                };
                // Добавить в DbSet
                usersEntities.Products.Add(products);

                // Сохранить изменения в базе данных
                usersEntities.SaveChanges();

                new Dobalenie().Close();
            }
        }


    }
}
