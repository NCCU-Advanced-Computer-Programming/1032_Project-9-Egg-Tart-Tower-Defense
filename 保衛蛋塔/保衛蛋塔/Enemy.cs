using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

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
        }

        public void move() 
        {
            if (hungry) 
            {
                img.Margin = new Thickness(img.Margin.Left - speed, img.Margin.Top, img.Margin.Right + speed, img.Margin.Bottom);
                position = img.Margin.Right + img.Width; 
            }
        }


    }
}
