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
        public int type;
        public double speed;
        public int damage;
        public bool hungry;
        private Image img;
        private Label lb;
        public StackPanel spImg;
        public double position;

        public Enemy(int type, int damage)
        {
            this.type = type;
            this.speed = 5;
            this.damage = damage;
            this.hungry = true;
            this.position = 0;
            img = new Image();     
            spImg = new StackPanel();
        }

        public void Move() 
        {
            if (hungry)
            {
                position += speed;
                spImg.Margin = new System.Windows.Thickness(0, 0, position, 20);
            }
            else
            {
                spImg.Children.Remove(img);
            }
        }

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

            lb = new Label();
            switch (type)
            {
                case 1:
                    lb.Content = "Cake";
                    break;
                case 2:
                    lb.Content = "Donut";
                    break;
                case 3:
                    lb.Content = "Hamburger";
                    break;
                case 4:
                    lb.Content = "Lemonade";
                    break;
                case 5:
                    lb.Content = "cake";
                    break;
                case 6:
                    lb.Content = "cake";
                    break;
            }
            lb.HorizontalAlignment = HorizontalAlignment.Center;
            lb.FontSize = 20;

            spImg.Children.Add(lb);
            spImg.Children.Add(img);

            return spImg;
        }

        public void kill(Grid g)
        {
            if (g != null)
                g.Children.Remove(this.LifeCheck());
            type = 0;

        }
        public virtual StackPanel LifeCheck()
        {
            //C#使用記憶體自動回收
            spImg.Visibility = Visibility.Hidden;

            return spImg;
        }
    }
}
