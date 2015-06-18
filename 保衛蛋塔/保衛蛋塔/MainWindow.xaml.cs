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

namespace 保衛蛋塔
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            AI ai = new AI();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            ai.UnitHandler();
        }

        private void UpgradeBtn_Click(object sender, RoutedEventArgs e)
        {
            new Window1().ShowDialog();
        }

        private void Food1Btn_Click(object sender, RoutedEventArgs e)
        {
            Enemy qqq = new Enemy(100, 1, 1);
            var img = qqq.Show(200, 200, "/Images/enemy.png");
            EnemyGrid.Children.Add(img);
        }

    }
}
