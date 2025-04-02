using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;
namespace AC9649
{
    public class enemyfinder : MonoBehaviour
    {
        private GameObject[] enemies;
        private List<Enemy> enemyList = new List<Enemy>();
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            enemies = GameObject.FindGameObjectsWithTag("enemy");
            foreach (GameObject enemy in enemies)
            {
                Enemy thisenemy = enemy.GetComponent<Enemy>();
                if (thisenemy != null)
                {
                    enemyList.Add(thisenemy);
                }
            }
            MakeAllEnemiesWarCry();
            GameObject asd = GameObject.Find("King Slime");
            if (asd != null)
            {
                Enemy kingSlimeEnemy = asd.GetComponent<Enemy>();
                kingSlimeEnemy.doWarCry();
            }
        }

        private void MakeAllEnemiesWarCry()
        {
            foreach (Enemy enemy in enemyList)
            {
                enemy.doWarCry();
            }

        }

    }
}
