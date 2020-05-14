using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthScript : MonoBehaviour
{
    public int hp = 1;
    public bool isEnemy = true;

    void OnTriggerEnter2D(Collider2D collider)
    {
        //Is it a shot ?
        ShotScript shot = collider.gameObject.GetComponent<ShotScript>();

        if (shot != null)
        {
            if (shot.isEnemyShot != isEnemy)
            {
                hp -= shot.damage;
                Destroy(shot.gameObject);


                if (hp <= 0)
                {   
                    Destroy(gameObject);
                    ScoreScript.scoreValue += 1;

                }
            }
        }
    }
}
