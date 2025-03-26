using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

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
    }

    private void MakeAllEnemiesWarCry()
    {
        foreach (Enemy enemy in enemyList)
        {
            enemy.doWarCry();
        }

    }

}
