using System;
using System.Timers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace LethalCompanyTestMod
{
    public class Commandloop : MonoBehaviour
    {
        
        private static void Spawnthing()
        {
            // function called to spawn an enemy attempts to spawn an indoor enemy if in list of availible enemies if not it check for outdoor
            bool foundEnemy = false;
            foreach (var enemy in TestMod.currentLevel.Enemies)
            {

                if (enemy.enemyType.enemyName.ToLower().Contains(stuff.enemytype))
                {
                    try
                    {
                        foundEnemy = true;
                        TestMod.SpawnEnemy(enemy, 1, true);
                    }
                    catch
                    {
                        TestMod.mls.LogInfo("Could not spawn enemy");
                    }
                    break;
                }
            }
            if (!foundEnemy)
            {
                foreach (var outsideEnemy in TestMod.currentLevel.OutsideEnemies)
                {

                    if (outsideEnemy.enemyType.enemyName.ToLower().Contains(stuff.enemytype))
                    {
                        TestMod.SpawnEnemy(outsideEnemy, 1, false);
                        break;
                    }
                }

            }
        }
        void Update()
        {
            //if we are currently looping wait until the appropraite duration then spawn the enemy and write to screen
            if (stuff.spawningloop)
            {
                if (!stuff.timerstarted)
                {
                    stuff.timerstarted = true;
                    //stuff.sw = System.Diagnostics.Stopwatch.StartNew();
                    //stuff.last = Time.deltaTime;
                }
                else
                {
                    stuff.spawntimer += Time.deltaTime;
                   
                    if (stuff.spawntimer >= stuff.spawnduration)
                    {
                        HUDManager.Instance.DisplayTip("Spawning thing", stuff.enemytype.ToString());
                        stuff.spawntimer = 0;
                        Spawnthing();


                    }
                }
            }
        }
    }
    
}
