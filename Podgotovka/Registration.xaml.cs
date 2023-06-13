using System.Windows;

namespace WpfAppVetclinic
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {

        public Registration()
        {
            InitializeComponent();
        }

        private void buttonRegReg_Click(object sender, RoutedEventArgs e)
        {
            using (Dostavka1Entities usersEntities = new Dostavka1Entities())
            {
                Users user = new Users
                {

                    userName = tbName.Text,
                    userSurname = tbSurname.Text,
                    userPatronymic = tbPatronymic.Text,
                    userPhoneNumber = tbPhoneNumb.Text,
                    userAdress = tbAdressNumber.Text,
                    userHomeNumber = tbAdressNumber.Text,
                    userApartmentsNumber = tbApartmentsNumber.Text,
                    userLogin = tbLoginRef.Text,
                    userPassword = tbPasswordRed.Text,
                    userRole = 2
                };
                // Добавить в DbSet
                usersEntities.Users.Add(user);

                // Сохранить изменения в базе данных
                usersEntities.SaveChanges();

                new Registration().Close();
            }
        }
    }
}
