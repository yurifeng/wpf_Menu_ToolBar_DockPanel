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
using System.Windows.Shapes;

namespace yty_wpf_180509_02
{
    /// <summary>
    /// about_windows.xaml 的交互逻辑
    /// </summary>
    public partial class about_windows : Window
    {
        //给aboutwindow添加属性以及get，set
        public string UserName { get; set; }
        public string Password { get; set; }

        //构造方法
        public about_windows()
        { 
            InitializeComponent();
        }

        //about窗口加载时的事件
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ab_textbox.Text = UserName;
        }
    }
}
