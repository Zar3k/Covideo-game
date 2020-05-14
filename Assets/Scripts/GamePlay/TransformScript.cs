using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformScript : MonoBehaviour
{
    public int maxInstanciation = 1;
    private int countInstanciation = 0;

    public Transform prefabObject = null;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Collision tag verification

       if(collision.gameObject.tag == "Virus")
        {
            //Limit the instanciation

            if(countInstanciation == maxInstanciation) return;
            {
                //New Object Instanciation

                var prefabTransform = Instantiate(prefabObject) as Transform;
                prefabTransform.position = transform.position;
                
                Destroy(gameObject);

                countInstanciation++;

            }
        }
    }
}
