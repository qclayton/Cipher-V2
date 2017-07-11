using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Transpiration_Cipher
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        public MainWindow()
        {
            InitializeComponent();
        }

        public static String encode(String myKey, String myMessage)
        {

            //myMessage = myMessage.Replace(" ", "");

            int z = 0;
            String encodedMessage = "";

            Char[,] message = new Char[(int)Math.Round((double)myMessage.Length / myKey.Length), myKey.Length];

            for (int x = 0; x < (int)Math.Round((double)myMessage.Length / myKey.Length); x++)
            {
                for (int y = 0; y < myKey.Length; y++)
                {
                    if (z < myMessage.Length)
                    {
                        message[x, y] = myMessage[z];
                        Console.Write(message[x, y]);
                        //Console.WriteLine(z);
                    }
                    z++;
                }
                Console.WriteLine();
            }

            Console.WriteLine(z);

            for (int col = 0; col < myKey.Length; col++)
            {
                for (int row = 0; row < (int)Math.Round((double)myMessage.Length / myKey.Length); row++)
                {
                    encodedMessage += message[row, col];
                }
            }

            Console.WriteLine(encodedMessage);

            return encodedMessage;
        }

        public static String decrypt(String myKey, String myMessage)
        {

            int z = 0;

            String decryptedMessage = "";

            Char[,] message = new Char[(int)Math.Round((double)myMessage.Length / myKey.Length), myKey.Length];

            for (int y = 0; y < myKey.Length; y++)
            {
                for (int x = 0; x < (int)Math.Round((double)myMessage.Length / myKey.Length); x++)
                {
                    if (z < myMessage.Length)
                    {
                        message[x, y] = myMessage[z];
                        Console.Write(message[x, y]);
                        //Console.WriteLine(z);
                    }
                    z++;
                }
                Console.WriteLine();
            }

            for (int row = 0; row < (int)Math.Round((double)myMessage.Length / myKey.Length); row++)
            {
                for (int col = 0; col < myKey.Length; col++)
                {
                    decryptedMessage += message[row, col];
                }
            }

            Console.WriteLine(decryptedMessage);

            return decryptedMessage;
        }


        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            {
                if (EncryptButton.IsChecked == true)
                {
                    //encode(myKey, myMessage);
                    MessageBox.Show("Encrypted.");
                    Window1 window1 = new Window1();
                    window1.Show();
                    this.Close();
                }
                else
                {
                    //decrypt(myKey, myMessage);
                    DecryptButton.IsChecked = true;
                    MessageBox.Show("Decrypted.");
                    Window1 window1 = new Window1();
                    window1.Show();
                    this.Close();
                }

                

            }


        }
        private void UserInput_textchanged(object sender, textchangedeventargs e)
        {

        }

        private void UserInput_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void Viewbox_SizeChanged(object sender, SizeChangedEventArgs e)
        {

        }
    }
}
