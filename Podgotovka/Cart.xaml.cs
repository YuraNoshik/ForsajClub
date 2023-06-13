using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows;

namespace WpfAppVetclinic
{
    /// <summary>
    /// Логика взаимодействия для Cart.xaml
    /// </summary>
    public partial class Cart : Window
    {

        List<Products> selectedProducts;
        Users user;
        Stuffs stuff;
        public Cart(List<Products> selectedProducts, Users user, Stuffs stuff)
        {
            InitializeComponent();


            this.selectedProducts = selectedProducts;
            this.stuff = stuff;
            this.user = user;
            if (user != null)
            {
                MessageBox.Show($"{user.userName}, вы вошли в корзину");
                tbCountAddress.Text = $"Адресс: {user.userAdress} \n {user.userHomeNumber}  ";
            }

            if (stuff != null)
            {
                MessageBox.Show($"{stuff.stuffName}, вы вошли в корзину");
            }

            listProductsCart.ItemsSource = selectedProducts;


            if (selectedProducts != null)
            {
                decimal totalPrice = 0;
                int amountServices = selectedProducts.Count;

                foreach (Products product in selectedProducts)
                {

                    totalPrice += product.productCost;


                }
                tbCost.Text = $"Стоимость заказа: {Math.Round(totalPrice, 0)}";
                tbCountProd.Text = $"В корзине {amountServices} услуг";

            }


        }
        private void CreateOrder()
        {
            using (Dostavka1Entities context = new Dostavka1Entities())
            {
                if (user != null)
                {
                    Orders order = new Orders()
                    {
                        userID = user.userID, // здесь должен быть ID пользователя, создающего заказ
                        orderDate = DateTime.Now,

                    };
                    context.Orders.Add(order);
                    context.SaveChanges();

                    // Получаем идентификатор созданного заказа
                    int orderId = order.orderID;

                    // Добавляем выбранные товары в заказ
                    decimal total = 0;
                    foreach (Products product in selectedProducts)
                    {
                        // Создаем новую запись в таблице "OrderServices"
                        orderProducts orderProducts = new orderProducts()
                        {
                            orderID = orderId,
                            productID = product.productID,
                        };
                        context.orderProducts.Add(orderProducts);

                        // Добавляем стоимость текущего товара к общей стоимости заказа

                        total += product.productCost;

                    }

                    // Обновляем общую стоимость заказа в таблице "Orders"
                    Orders currentOrder = context.Orders.FirstOrDefault(o => o.orderID == orderId);
                    currentOrder.orderCost = Math.Round((decimal)total, 0);
                    context.SaveChanges();

                    MessageBox.Show("Заказ успешно создан!");
                    Thread.Sleep(500);
                    Close();
                }


                if (stuff != null)
                {
                    Orders order = new Orders()
                    {
                        stuffID = stuff.stuffID, // здесь должен быть ID пользователя, создающего заказ
                        orderDate = DateTime.Now,

                    };
                    context.Orders.Add(order);
                    context.SaveChanges();

                    // Получаем идентификатор созданного заказа
                    int orderId = order.orderID;

                    // Добавляем выбранные товары в заказ
                    decimal total = 0;
                    foreach (Products product in selectedProducts)
                    {
                        // Создаем новую запись в таблице "OrderServices"
                        orderProducts orderProducts = new orderProducts()
                        {
                            orderID = orderId,
                            productID = product.productID,
                        };
                        context.orderProducts.Add(orderProducts);

                        // Добавляем стоимость текущего товара к общей стоимости заказа

                        total += product.productCost;

                    }

                    // Обновляем общую стоимость заказа в таблице "Orders"
                    Orders currentOrder = context.Orders.FirstOrDefault(o => o.orderID == orderId);
                    currentOrder.orderCost = Math.Round((decimal)total, 0);
                    context.SaveChanges();

                    MessageBox.Show("Заказ успешно создан!");
                    Thread.Sleep(500);
                    Close();
                }
            }
        }
        // Создаем новый заказ
        private void DeleteFromOrder()
        {
            var selectedItem = listProductsCart.SelectedItem as Products;
            if (selectedItem != null)
            {
                selectedProducts.Remove(selectedItem);
                listProductsCart.ItemsSource = null;
                listProductsCart.ItemsSource = selectedProducts;

                decimal totalPrice = 0;
                int amountServices = selectedProducts.Count;

                foreach (Products products in selectedProducts)
                {
                    totalPrice += products.productCost;
                }
                tbCost.Text = totalPrice.ToString();
                tbCountProd.Text = $"В корзине {amountServices} услуг";
            }
        }

        private void ButtonDeleteFromOrder_Click(object sender, RoutedEventArgs e)
        {
            DeleteFromOrder();
        }

        private void CreateOrder(object sender, RoutedEventArgs e)
        {

            CreateOrder();

        }
    }



}

