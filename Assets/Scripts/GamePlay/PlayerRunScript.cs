using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class PlayerRunScript : MonoBehaviour
{
    public int ScoreGoal;

    public float speed = 25f;
    public int health = 3;

    public float maxHeight;
    public float minHeight;
    public float maxWidth;
    public float minWidth;

    private bool isPaused = false;

    public string SceneNameToLoad;
    

    void Start() { print("Start"); }

    void Update()
    {
        //Commands movement

        if (Input.GetKey(KeyCode.D) && transform.position.x < maxWidth)
            transform.Translate(Vector3.right * speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.Q) && transform.position.x > minWidth)
            transform.Translate(-Vector3.right * speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.Z) && transform.position.y < maxHeight)
            transform.Translate(Vector3.up * speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.S) && transform.position.y > minHeight)
            transform.Translate(-Vector3.up * speed * Time.deltaTime);

        //Return to the menu
        if (Input.GetKey(KeyCode.Escape))
            SceneManager.LoadScene(0);

        //Pause
        if (Input.GetKeyDown(KeyCode.P))
            pauseGame();

        //Shooting
        bool shoot = Input.GetKey(KeyCode.Space);
        
        if (shoot)
        {
            PlayerBullets weapon = GetComponent<PlayerBullets>();
            if (weapon != null)
            {
                weapon.Attack(false);
            }
        }

        //Death
        if(health <= 0)
        {
            SceneManager.LoadScene(1);
            ScoreScript.scoreValue = 0;

        }

        //Goal transition
        if(ScoreScript.scoreValue == ScoreGoal)
        {
            SceneManager.LoadScene(SceneNameToLoad);
            RoundScript.fieverValue += 0.5f;
        }


        void pauseGame()
        {
            if (isPaused)
            {
                Time.timeScale = 1;
                isPaused = false;
            } else {
                Time.timeScale = 0;
                isPaused = !isPaused;
            }
        }
    }
}