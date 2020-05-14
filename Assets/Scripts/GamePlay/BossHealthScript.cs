using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BossHealthScript : MonoBehaviour
{
    public int hp = 10;
    public int currentHp;
    public bool isEnemy = true;

    public HealthBarScript healthBar;

    void Start()
    {
        currentHp = hp;
        healthBar.SetMaxHealth(hp);
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        // Est-ce un tir ?
        ShotScript shot = collider.gameObject.GetComponent<ShotScript>();

        if (shot != null)
        {
            if (shot.isEnemyShot != isEnemy)
            {
                currentHp -= shot.damage;
                Destroy(shot.gameObject);
                healthBar.SetHealth(currentHp);

                if (currentHp <= 0)
                {
                    SceneManager.LoadScene(7);
                }
            }
        }
    }
}
