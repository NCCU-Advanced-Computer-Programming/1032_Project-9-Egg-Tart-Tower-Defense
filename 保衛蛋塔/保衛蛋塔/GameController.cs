using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace 保衛蛋塔
{
    class GameController
    {
        public List<Enemy> enemyList;
        public List<Food> foodList;
        string source;

        public GameController()
        {
            enemyList = new List<Enemy>();
            foodList = new List<Food>();
        }

        public void AddUnit(Grid grid)
        {
            enemyList.Add(new Enemy(1, 10, 10));
            grid.Children.Add(enemyList[enemyList.Count - 1].Show(200, 200, "/Images/enemy.png"));
        }

        public void AddFood(int type, Grid grid)
        {
            foodList.Add(new Food(type));
            switch (type) 
            {
                case 1:
                    source = "/Images/cake.png";
                    break;
            }
            grid.Children.Add(foodList[foodList.Count - 1].Show(200, 200, source));
        }

        public void UnitHandler(Grid grid, ProgressBar towerHP)
        {
            for (int i = 0; i < enemyList.Count; i++)
            {
                if (enemyList[i] != null)
                {
                    enemyList[i].Move();
                    if (enemyList[i].position == 760)
                         {
                            for (int j = 0; j < foodList.Count; j++) 
                             {
                                 if (enemyList[i].need == foodList[j].type)
                                 {
                                     enemyList[i].kill(grid);
                                     foodList[j].kill(grid);
                                 }
                               }          
                         }
                    if (enemyList[i].position == 800 && enemyList[i].need != 0)
                    {
                        towerHP.Value -= enemyList[i].damage;
                        enemyList[i].kill(grid);
                    }
               
                    
                } 
                
                
                
            }
            
        }
    }
}
