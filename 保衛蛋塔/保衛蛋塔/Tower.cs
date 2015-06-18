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
    class Tower
    {
        private int hp;
        private int coodX;
        private int coodY;
        private double speed;
        private int damage;
        private bool hungry;
        public Image img;
        public StackPanel spImg;
        private double position;

        public Tower(int hp, double speed, int damage, int coodX, int coodY)
        {
            this.hp = hp;
            //this.speed = speed;
            //this.damage = damage;
            //this.hungry = true;
            this.position = 0;
            img = new Image();
            coodX = 63;
            coodY = -151;
            //img.Margin
            spImg = new StackPanel();
        }

        /*public void Move()
        {
            if (hungry)
            {
                position = position + speed;
                spImg.Width += 10;
            }
        }*/

        public StackPanel Show(int height, int width, string imageSource)
        {
            spImg.Margin = new System.Windows.Thickness(0, 0, 0, 20);
            spImg.Width = width * 1.1;
            spImg.VerticalAlignment = VerticalAlignment.Bottom;
            spImg.HorizontalAlignment = HorizontalAlignment.Right;

            BitmapImage bi3 = new BitmapImage();
            bi3.BeginInit();
            bi3.UriSource = new Uri(imageSource, UriKind.Relative);
            bi3.EndInit();
            img.Source = bi3;
            img.Height = height;
            img.Width = width;
            
            img.Stretch = Stretch.Uniform;
            spImg.Children.Add(img);

            return spImg;
        }

    }
}
