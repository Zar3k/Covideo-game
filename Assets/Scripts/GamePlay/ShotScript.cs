using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Comportement des tirs
/// </summary>
public class ShotScript : MonoBehaviour
{
    public int damage = 1;

    public bool isEnemyShot = false;

    void Start()
    {
        // 2 - Destruction programmée
        Destroy(gameObject, 20); // 20sec
    }
}
