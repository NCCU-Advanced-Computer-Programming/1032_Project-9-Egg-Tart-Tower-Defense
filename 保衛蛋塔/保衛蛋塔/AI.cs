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

        public void AddUnit(Panel EnemyGrid)
        {
            enemyList.Add(new Enemy(100, 1, 1));
            EnemyGrid.Children.Add(enemyList[enemyList.Count-1].Show(200, 200, "/Images/enemy.png"));
        }

        public void UnitHandler()
        {
            for (int i = 0; i < enemyList.Count; i++)
            {
                enemyList[i].Move();
            }
        }
    }
}
