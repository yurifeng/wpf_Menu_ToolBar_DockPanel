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

namespace yty_wpf_180509_02
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    Close();
        //}

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            //声明定义一个string类型name，用来接收主窗体的text内容
            string name = textName.Text;
            //new一个about的窗体
            about_windows abwin = new about_windows();
            //将name赋值给about类中的UserName
            abwin.UserName=name;
            //显示about窗体对话框
            abwin.ShowDialog();

            MessageBox.Show(abwin.Password);

        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }

        //private void MenuItem_Click(object sender, RoutedEventArgs e)
        //{
        //    Close();
        //}
    }
}
