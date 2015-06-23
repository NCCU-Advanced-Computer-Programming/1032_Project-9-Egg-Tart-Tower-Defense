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
    class Food
    {
        public int type;
        public Image img;
        public StackPanel spImg;
        public string source;

        public Food(int type) 
        {
            this.type = type;
            img = new Image();
            spImg = new StackPanel();
            switch (type)
            {
                case 1:
                    source = "/Images/cake.png";
                    break;
                case 2:
                    source = "/Images/donut.png";
                    break;
                case 3:
                    source = "/Images/hamburger.png";
                    break;
                case 4:
                    source = "/Images/lemonade.png";
                    break;
                case 5:
                    source = "/Images/cake.png";
                    break;
                case 6:
                    source = "/Images/cake.png";
                    break;
            }
        }

        public StackPanel Show(int height, int width, string imageSource)
        {
            spImg.Margin = new System.Windows.Thickness(0, 0, 750, 20);
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
