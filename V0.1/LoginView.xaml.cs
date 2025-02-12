using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace UltiKeep.View
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : Window
    {
        bool passwordVisible = false;

        SolidColorBrush Primary1 = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#2E2C2F"));
        SolidColorBrush Primary2 = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#475B63"));
        SolidColorBrush Secondary1 = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#729B79"));
        SolidColorBrush Secondary2 = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#BACDB0"));
        SolidColorBrush Text = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#F3E8EE"));

        public LoginView()
        {
            InitializeComponent();
        }

        private void Btn_TogglePasswordVisibility_Click(object sender, RoutedEventArgs e)
        {
            if (passwordVisible)
            {
                EyeIcon.Source = new BitmapImage(new Uri("pack://application:,,,/UltiKeep;component/Assets/EyeOpenIconWhite.png"));
                Txt_Password.Visibility = Visibility.Collapsed;
                Pwd_Password.Visibility = Visibility.Visible;
                Pwd_Password.Password = Txt_Password.Text;
            }
            else
            {
                EyeIcon.Source = new BitmapImage(new Uri("pack://application:,,,/UltiKeep;component/Assets/EyeClosedIconWhite.png"));
                Pwd_Password.Visibility = Visibility.Collapsed;
                Txt_Password.Visibility = Visibility.Visible;
                Txt_Password.Text = Pwd_Password.Password;
            }

            passwordVisible = !passwordVisible;
        }


        private void Btn_TogglePasswordVisibility_MouseEnter(object sender, MouseEventArgs e)
        {
            Btn_TogglePasswordVisibility.Background = Primary1;
        }

        private void Btn_TogglePasswordVisibility_MouseLeave(object sender, MouseEventArgs e)
        {
            Btn_TogglePasswordVisibility.Background = Primary2;
        }

        private void Btn_Login_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_ResetPassword_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_ResetPassword_MouseEnter(object sender, MouseEventArgs e)
        {
            Btn_ResetPassword.Background = Primary2;
        }

        private void Btn_ResetPassword_MouseLeave(object sender, MouseEventArgs e)
        {
            Btn_ResetPassword.Background = Primary1;
        }

        private void Btn_SignUp_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_SignUp_MouseEnter(object sender, MouseEventArgs e)
        {
            Btn_SignUp.Background = Primary2;
        }

        private void Btn_SignUp_MouseLeave(object sender, MouseEventArgs e)
        {
            Btn_SignUp.Background = Primary1;
        }
    }
}
