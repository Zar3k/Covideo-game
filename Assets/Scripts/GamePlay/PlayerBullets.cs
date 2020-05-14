using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullets : MonoBehaviour
{
    
    public Transform shotPrefab;
    public float shootingRate = 0.25f;

    private float shootCooldown;

    void Start()
    {
        shootCooldown = 0f;
    }

    void Update()
    {
        if (shootCooldown > 0)
        {
            shootCooldown -= Time.deltaTime;
        }
    }

    
    public void Attack(bool isEnemy)
    {
        if (CanAttack)
        {
            shootCooldown = shootingRate;

            //Instantiation of prefab object
            var shotTransform = Instantiate(shotPrefab) as Transform;

            // Position
            shotTransform.position = transform.position;

            // Propriétés du script
            ShotScript shot = shotTransform.gameObject.GetComponent<ShotScript>();
            if (shot != null)
            {
                shot.isEnemyShot = isEnemy;
            }

            // Movement direction
            EnemyMovement move = shotTransform.gameObject.GetComponent<EnemyMovement>();
            if (move != null)
            {
                move.direction = this.transform.right; //The right direction of our object
            }
        }
    }

    public bool CanAttack
    {
        get
        {
            return shootCooldown <= 0f;
        }
    }
}