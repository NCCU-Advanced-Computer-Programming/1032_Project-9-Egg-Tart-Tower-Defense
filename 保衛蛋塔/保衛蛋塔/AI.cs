using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace 保衛蛋塔
{
    class AI
    {
        public List<Enemy> enemyList;

        public AI()
        {
            enemyList = new List<Enemy>();
        }
        StackPanel img;
        public void AddUnit(Panel EnemyGrid)
        {
            enemyList.Add(new Enemy(200, 10, 1));
            img = enemyList[enemyList.Count - 1].Show(200, 200, "/Images/enemy.png");
            EnemyGrid.Children.Add(img);
        }

        public void UnitHandler(List<Food> foodtray, Panel EnemyGrid)
        {
            for (int i = 0; i < enemyList.Count; i++)
            {
                if (enemyList[i] != null)
                {
                    enemyList[i].Move();
                    if (enemyList[i].position == 760)
                         {
                   /* for (int j = 0; j < foodtray.Count; j++) 
                    {
                        if (enemyList[i].need == foodtray[j].type)
                        {
                            enemyList[i].hungry = false;
                            
                            enemyList[i] = null;
                            foodtray[j] = null;
                        }
                    }
                    */

                             EnemyGrid.Children.Remove(img);
                      }

               
                    
                } 
                
                
                
            }
            
        }
    }
}
