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
        public int score = 0;

        public GameController()
        {
            enemyList = new List<Enemy>();
            foodList = new List<Food>();
        }

        public void AddUnit(int type,Grid grid)
        {
            enemyList.Add(new Enemy(type, 20));
            grid.Children.Add(enemyList[enemyList.Count - 1].Show(200, 200, "/Images/enemy.png"));
        }

        public void AddFood(int type, Grid grid)
        {
                foodList.Add(new Food(type));
                grid.Children.Add(foodList[foodList.Count - 1].Show(200, 200, foodList[foodList.Count - 1].source));        
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
                                 if (enemyList[i].type == foodList[j].type)
                                 {
                                     enemyList[i].kill(grid);
                                     foodList[j].kill(grid);
                                      score += 10;    
                                 }else
                                    {
                                         foodList[j].kill(grid);
                                     }
                               }          
                         }
                    if (enemyList[i].position == 900 && enemyList[i].type != 0)
                    {
                        towerHP.Value -= enemyList[i].damage;
                        enemyList[i].kill(grid);
                    }
               
                    
                } 
                
                
                
            }
            
        }

        public bool Check(ProgressBar towerHP,Label gameover,Button restart)
        {
            if(towerHP.Value == 0)
            {
                gameover.Visibility = System.Windows.Visibility.Visible;
                restart.Visibility = System.Windows.Visibility.Visible;
                return false;
            }else
            {
                return true;
            }
        }
    }
}
