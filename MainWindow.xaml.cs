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

namespace FullKeyBoard
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        private bool flag = false;
        private MyButton[] buttons = new MyButton[14];
        public MainWindow()
        {
            InitializeComponent();
           
            buttons[0] = new MyButton("~", "`", tilda);
            buttons[1] = new MyButton("!", "1", one);
            buttons[2] = new MyButton("@", "2", two);
        }

        private void TextBlock_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Tab)
            {
                Button_Tab.Background = new SolidColorBrush(Colors.White);
            }
            if (e.Key == Key.CapsLock)
            {
                Button_CapsLock.Background = new SolidColorBrush(Colors.White);
            }
            if (e.Key == Key.LeftShift)
            {
                Button_LeftShift.Background = new SolidColorBrush(Colors.White);
            }
            if (e.Key == Key.RightShift)
            {
                Button_RitghShift.Background = new SolidColorBrush(Colors.White);
            }
            if (e.Key == Key.LeftCtrl)
            {
                Button_LeftCtrl.Background = new SolidColorBrush(Colors.White);
            }
            if (e.Key == Key.RightCtrl)
            {
                Button_RitghCtrl.Background = new SolidColorBrush(Colors.White);
            }
            if (e.Key == Key.LWin)
            {
                Button_LeftWin.Background = new SolidColorBrush(Colors.White);
            }
            if (e.Key == Key.RWin)
            {
                Button_RitghWin.Background = new SolidColorBrush(Colors.White);
            }
            if (e.Key == Key.LeftAlt)
            {
                Button_LeftAlt.Background = new SolidColorBrush(Colors.White);
            }
            if (e.Key == Key.RightAlt)
            {
                Button_RitghAlt.Background = new SolidColorBrush(Colors.White);
            }
            if (e.Key == Key.Space)
            {
                Button_space.Background = new SolidColorBrush(Colors.White);
            }
            else
            {
                Bock1.Text += e.Key.ToString();
            }
        }

        private void TextBlock_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.CapsLock)
            {
                Button_CapsLock.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FFB5B5B5");
            }
            if (e.Key == Key.Tab)
            {
                Button_Tab.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FFB5B5B5");
            }
            if (e.Key == Key.LeftShift)
            {
                Button_LeftShift.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FFB5B5B5");
            }
            if (e.Key == Key.RightShift)
            {
                Button_RitghShift.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FFB5B5B5");
            }
            if (e.Key == Key.LeftCtrl)
            {
                Button_LeftCtrl.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FFB5B5B5");
            }
            if (e.Key == Key.RightCtrl)
            {
                Button_RitghCtrl.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FFB5B5B5");
            }
            if (e.Key == Key.LWin)
            {
                Button_LeftWin.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FFB5B5B5");
            }
            if (e.Key == Key.RWin)
            {
                Button_RitghWin.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FFB5B5B5");
            }
            if (e.Key == Key.RightAlt)
            {
                Button_RitghAlt.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FFB5B5B5");
            }
            if (e.Key == Key.LeftAlt)
            {
                Button_LeftAlt.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FFB5B5B5");
            }
            if (e.Key == Key.Space)
            {
                Button_space.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FFB5B5B5");
            }
        }

        private void Polzun_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ValueCharsBlock.Text = Polzun.Value.ToString(); ;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button_Start.IsEnabled = false;
            Button_Stop.IsEnabled = true;
            Bock1.Focusable = true;
            Bock1.Focus();
        }

        private void Button_Stop_Click(object sender, RoutedEventArgs e)
        {
            Button_Start.IsEnabled = true;
            Button_Stop.IsEnabled = false;
            Bock1.Focusable = false;
        }
    }
    }


