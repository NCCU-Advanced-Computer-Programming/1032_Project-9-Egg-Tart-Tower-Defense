using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace 保衛蛋塔
{
    class Enemy
    {
        private int hp;
        private double speed;
        private int damage;
        private bool hungry;
        public Image img;
        private double position;

        public Enemy(int hp, double speed, int damage)
        {
            this.hp = hp;
            this.speed = speed;
            this.damage = damage;
            this.hungry = true;
            img = new Image();
        }

        public void move() 
        {
            if (hungry) 
            {
                img.Margin = new Thickness(img.Margin.Left - speed, img.Margin.Top, img.Margin.Right + speed, img.Margin.Bottom);
                position = img.Margin.Right + img.Width; 
            }
        }

        public void Show(int height, int width, string imageSource)
        {
            img.Margin = new System.Windows.Thickness(0, 0, 1058 - width, 20);

            BitmapImage bi3 = new BitmapImage();
            bi3.BeginInit();
            bi3.UriSource = new Uri(imageSource, UriKind.Relative);
            bi3.EndInit();
            img.Source = bi3;
            img.Stretch = Stretch.Uniform;
            
            sp.Children.Add(img);
        }

    }
}
