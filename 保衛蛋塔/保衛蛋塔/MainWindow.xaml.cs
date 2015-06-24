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
        int spawn = 70;
        bool game = false;
        Random rd = new Random();
     
        
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
            if (game) {
                gc.UnitHandler(grid, towerHP);
                game = gc.Check(towerHP,gameover,restart);
                scoreLB.Content = "Score: " + gc.score;
                time += 1;
                if (time % spawn == 0)
                {
                    gc.AddUnit(rd.Next(1,6),grid);
                    spawn -= 1;
                }
            }
            
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

        private void Food5Btn_Click(object sender, RoutedEventArgs e)
        {
            gc.AddFood(5, grid);
        }

        private void Food6Btn_Click(object sender, RoutedEventArgs e)
        {
            gc.AddFood(6, grid);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (game)
                pause.Content = "Resume";
            else
                pause.Content = "Pause";
            game = !game;
        }

        private void start_Click(object sender, RoutedEventArgs e)
        {
            game = true;
            cover.Visibility = Visibility.Hidden;
            start.Visibility = Visibility.Hidden;
            help.Visibility = Visibility.Hidden;
        }

        private void help_Click(object sender, RoutedEventArgs e)
        {
            new Window1().ShowDialog();
        }

        private void restart_Click(object sender, RoutedEventArgs e)
        {
            towerHP.Value = 100;
            time = 0;
            spawn = 70;
            game = false;
            gc = new GameController();
            gameover.Visibility = Visibility.Hidden;
            restart.Visibility = Visibility.Hidden;
            cover.Visibility = Visibility.Visible;
            start.Visibility = Visibility.Visible;
            help.Visibility = Visibility.Visible;
            grid.Children.RemoveRange(0,100);
        }
    }
}
