using System;
using System.Windows;

namespace WpfAppVetclinic
{
    /// <summary>
    /// Логика взаимодействия для Redact.xaml
    /// </summary>
    public partial class Redact : Window
    {
        public Redact()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using (Dostavka1Entities usersEntities = new Dostavka1Entities())
            {
                //Поиск удаляемой записи по ключевому полю
                Products product = usersEntities.Products.Find(Convert.ToInt32(tbProdIDredact.Text));
                if (product == null)
                {
                    MessageBox.Show("Такого продукта нет");
                    return;
                }
                else
                {  //Меняем значение полей

                    product.productName = tbProdNameRedact.Text;
                    product.productCost = Convert.ToDecimal(tbProdCostRedac.Text);
                    try
                    {
                        usersEntities.SaveChanges();	//Фиксируем изменения в БД
                        MessageBox.Show("Продукт отредактирован");
                    }
                    catch
                    {
                        MessageBox.Show("Не удалось изменить роль пользователя");
                        return;
                    }
                }
            }

        }
    }
}
