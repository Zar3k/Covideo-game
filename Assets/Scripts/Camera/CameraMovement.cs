using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float speed;
    public float startX;
    public float endX;

    void Update()
    {
        //Move to the right
        transform.Translate(Vector2.left * speed * Time.deltaTime);


        //Change the positions
        if(transform.position.x <= endX)
        {
            Vector2 pos = new Vector2(startX, transform.position.y);
            transform.position = pos;
        }
    }
}