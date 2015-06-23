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
using System.Windows.Threading;

namespace 保衛蛋塔
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer;
        int _timeInterval;
        int time = 0;
     
        
        GameController gc;
        List<Food> foodtray = new List<Food>();
        
        
        public MainWindow()
        {
            InitializeComponent();
           
            gc = new GameController();
            

            _timeInterval = 25;
            time = 0;
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(_timeInterval);
            timer.Tick += timer_Tick;
            timer.Start();

            
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            gc.UnitHandler(grid,towerHP);
            time += 1;
            if (time % 50 == 0)
            {
                gc.AddUnit(grid);
            }
        }

        private void UpgradeBtn_Click(object sender, RoutedEventArgs e)
        {
            new Window1().ShowDialog();
        }

        private void Food1Btn_Click(object sender, RoutedEventArgs e)
        {
            gc.AddFood(1,grid);           
        }

        private void Food2Btn_Click(object sender, RoutedEventArgs e)
        {
            gc.AddFood(2, grid);
        }

        private void Food3Btn_Click(object sender, RoutedEventArgs e)
        {
            gc.AddFood(3, grid);
        }

        private void Food4Btn_Click(object sender, RoutedEventArgs e)
        {
            gc.AddFood(4, grid);
        }

    }
}
