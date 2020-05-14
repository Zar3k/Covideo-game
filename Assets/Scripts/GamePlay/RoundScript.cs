using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoundScript : MonoBehaviour
{
    public static float fieverValue = 38.0f;
    Text fiever;

    // Start is called before the first frame update
    void Start()
    {
        fiever = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        fiever.text = "Fièvre: " + fieverValue;
    }
}
