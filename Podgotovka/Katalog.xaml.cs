using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace WpfAppVetclinic
{
    /// <summary>
    /// Логика взаимодействия для Katalog.xaml
    /// </summary>
    public partial class Katalog : Window
    {
        Users user;
        Stuffs stuffs;
        public Katalog(Users user, Stuffs stuffs)
        {
            InitializeComponent();


            this.user = user;
            this.stuffs = stuffs;
            if (user != null)
            {
                MessageBox.Show($"Вы вошли как {user.Roles.RoleName}");
                lbName.Text = user.userName;
            }

            if (stuffs != null)
            {
                MessageBox.Show($"Вы вошли как {stuffs.Roles.RoleName}");
                lbName.Text = stuffs.stuffName;
            }




        }

        List<Products> selectedProducts = new List<Products>();

        private static Bitmap bitmap;
        public static string path = @"D:\Downloads\wpfauth-main\wpfauth-main\WpfAppVetclinic\WpfAppVetclinic\Resources\";
        private static string picName;
        private string userName;
        private string userPatronymic;
        private string userSurname;
        private string userRole;
        int countAll1, countCurrent1, filterCategory;

        private void Katalog_Load(object sender, RoutedEventArgs e)
        {
            //labelUserName.Text = userName + " ";
            //labelUserName.Text += userPatronymic + " ";
            //labelUserName.Text += userSurname + "\n";
            //labelUserName.Text += userRole;

            using (Dostavka1Entities usersEntities = new Dostavka1Entities())
            {
                cbCategory.Items.Add("Все категории");
                var categories = usersEntities.Category.Select(x => x.categoryName).ToList();
                cbCategory.SelectedItem = cbCategory.Items[0];
                foreach (var category in categories)
                {
                    cbCategory.Items.Add(category);
                }

                var products = usersEntities.Products.ToList();
                cbSort.Items.Add("Без сортировки");
                cbSort.Items.Add("По возрастанию");
                cbSort.Items.Add("По убыванию");

                cbSort.SelectedItem = cbSort.Items[0];
                cbFilter.Items.Add("Без фильтра");
                cbFilter.SelectedItem = cbFilter.Items[0];
                countAll1 = products.Count();
                lbCountAll.Text = countAll1.ToString();

            }

            LoadProductsToGrid();
        }

        public void LoadProductsToGrid()
        {
            using (Dostavka1Entities usersEntities = new Dostavka1Entities())
            {
                var products = usersEntities.Products.ToList();
                //products = usersEntities.Category.ToList();
                products = usersEntities.Products.Include(c => c.Category).ToList();

                if (filterCategory != 0)
                {
                    products = usersEntities.Products.Where(x => x.categoryID == filterCategory).ToList();
                }

                if (tbSearch.Text != null)
                    products = products.Where(x => x.productName.Contains(tbSearch.Text)).ToList();


                switch (cbSort.SelectedIndex)
                {
                    default:
                        break;

                    case 1:
                        products = products.OrderBy(x => x.productCost).ToList();
                        break;

                    case 2:
                        products = products.OrderByDescending(x => x.productCost).ToList();
                        break;
                }

                countCurrent1 = products.Count();
                listProducts.ItemsSource = products;
                lbCurrent.Text = countCurrent1.ToString();
            }


        }

        private void cbCategory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            filterCategory = cbCategory.SelectedIndex;
            LoadProductsToGrid();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new Dobalenie().Show();
        }


        private void AddToCart_Click(object sender, RoutedEventArgs e)
        {

            foreach (var selectedItem in listProducts.SelectedItems)
            {
                Products products = selectedItem as Products;
                if (products != null)
                {
                    selectedProducts.Add(products);
                    MessageBox.Show($"Товар с id: {products.productID} и названием: {products.productName}\n Был добавлен в корзину");
                }

            }
        }


        private void Image_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {

            lbCountAll.Text = countCurrent1.ToString();
            LoadProductsToGrid();
        }

        private void delProd_Click(object sender, RoutedEventArgs e)
        {
            var selectedItem = listProducts.SelectedItem;

            using (Dostavka1Entities usersEntities = new Dostavka1Entities())
            {
                if (selectedItem != null)
                {
                    int selectedItemId = ((Products)selectedItem).productID;
                    var item = usersEntities.Products.FirstOrDefault(x => x.productID == selectedItemId);

                    if (item != null)
                    {
                        usersEntities.Products.Remove(item);
                        usersEntities.SaveChanges();
                    }
                }
                lbCountAll.Text = countCurrent1.ToString();
                listProducts.ItemsSource = null;
                LoadProductsToGrid();
            }
        }

        private void listProducts_PreviewMouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            new Redact().Show();
        }

        private void Image_MouseDown_1(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {


            Cart cart = new Cart(selectedProducts, user, stuffs);


            cart.ShowDialog();
        }

        private void cbSort_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            LoadProductsToGrid();
        }

        private void tbSearch_TextChanged(object sender, TextChangedEventArgs e)
        {


            if (tbSearch.Text == tbSearch.Text.ToLowerInvariant() || tbSearch.Text == tbSearch.Text.ToUpperInvariant())
            {
                listProducts.ItemsSource = null;
                LoadProductsToGrid();
            }

        }


    }

}




