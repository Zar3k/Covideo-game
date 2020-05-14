using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public string SceneNameToLoad;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene(SceneNameToLoad);
    }

}
