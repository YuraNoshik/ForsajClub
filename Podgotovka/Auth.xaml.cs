using EasyCaptcha.Wpf;
using System.Linq;
using System.Windows;


namespace WpfAppVetclinic
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class Auth : Window
    {
        public Auth()
        {
            InitializeComponent();

        }


        string capchaLow;
        string capchaUp;

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            Captcha.CreateCaptcha(Captcha.LetterOption.Alphanumeric, 6);

            capchaLow = Captcha.CaptchaText;
            capchaUp = Captcha.CaptchaText;


        }
        private void buttonReCaptcha_Click(object sender, RoutedEventArgs e)
        {

            Captcha.CreateCaptcha(Captcha.LetterOption.Alphanumeric, 6);

            capchaLow = Captcha.CaptchaText;
            capchaUp = Captcha.CaptchaText;


        }

        private void buttonExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();

        }

        private void buttonLogin_Click(object sender, RoutedEventArgs e)
        {
            Users user;
            Stuffs stuffs;

            using (Dostavka1Entities usersEntities = new Dostavka1Entities())
            {

                if (textBoxEnterCaptcha.Text == "" || textBoxLogin.Text == "" || textBoxPassword.Password == "")
                {

                    MessageBox.Show("Одно из полей пустое");

                }
                else
                {
                    user = usersEntities.Users.Where(x => x.userLogin == textBoxLogin.Text && x.userPassword == textBoxPassword.Password).FirstOrDefault();
                    stuffs = usersEntities.Stuffs.Where(x => x.stuffLogin == textBoxLogin.Text && x.stuffPassword == textBoxPassword.Password).FirstOrDefault();



                    if (stuffs != null)
                    {
                        Katalog katalog = new Katalog(user, stuffs);
                        switch (stuffs.stuffRole)
                        {
                            default:
                                break;
                            case 1:
                                katalog.Show();
                                this.Hide();
                                break;
                            case 2:
                                katalog.Show();
                                this.Hide();

                                break;

                            case 3:
                                katalog.btAddProd.Visibility = Visibility.Hidden;
                                katalog.btCart.Visibility = Visibility.Visible;
                                katalog.btDelProd.Visibility = Visibility.Hidden;
                                katalog.Show();
                                this.Hide();
                                break;
                        }
                    }



                    if (user != null)
                    {
                        Katalog katalog = new Katalog(user, stuffs);
                        switch (user.userRole)
                        {
                            default:
                                break;
                            case 1:
                                katalog.Show();
                                this.Hide();
                                break;
                            case 2:

                                katalog.btAddProd.Visibility = Visibility.Hidden;
                                katalog.btCart.Visibility = Visibility.Visible;
                                katalog.btDelProd.Visibility = Visibility.Hidden;
                                katalog.Show();
                                this.Hide();
                                break;

                            case 3:
                                katalog.Show();
                                this.Hide();
                                break;
                        }

                    }
                }
            }
            textBoxLogin.Text = "";
            textBoxPassword.Password = "";
            textBoxEnterCaptcha.Text = "";
            Captcha.CreateCaptcha(Captcha.LetterOption.Alphanumeric, 6);
        }

        private void buttonReg_Click(object sender, RoutedEventArgs e)
        {
            new Registration().Show();
        }
        private void buttonGuest_Click(object sender, RoutedEventArgs e)
        {

            Katalog katalog = new Katalog(null, null);
            katalog.btAddProd.Visibility = Visibility.Hidden;
            katalog.btCart.Visibility = Visibility.Hidden;
            katalog.btDelProd.Visibility = Visibility.Hidden;
            katalog.Show();
        }
    }
}





