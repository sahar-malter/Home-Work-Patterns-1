using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Enemy : MonoBehaviour
{
   public EnemyModel EnemyModelData;
   Score score = Score.GetScoreInstance();



    public void takeDamage()
    {
        float temp = EnemyModelData.hp;

        if (Input.GetKeyDown(EnemyModelData.press))
        {
            EnemyModelData.hp = 0;

        }
        if(EnemyModelData.hp <= 0)
        {
            EnemyModelData.hp = temp;
            score.addScore();
            Destroy(gameObject.transform.GetChild(0).gameObject);

        }

       
    }

    private void Update()
    {
        takeDamage();
        creat_enemy();


    }


    public void creat_enemy()
    {
        if (Input.GetKeyDown(EnemyModelData.creat))
        {

           GameObject temp =   Instantiate(EnemyModelData.enemyObject);
            temp.transform.parent = this.gameObject.transform;
            
        }

    }
}
