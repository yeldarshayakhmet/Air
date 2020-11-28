using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public static GameController instance = null;
    
    public bool isDead = false;
    public bool isWon = false;
    // Start is called before the first frame update
    void Awake()
    {
        if(instance == null){
            instance = this;
        }
        else if(instance != this){
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }


    // Update is called once per frame
    void Update()
    {
        string currentScene = SceneManager.GetActiveScene().name;
        if(currentScene == "Intro" && Input.GetKeyDown("space")){
            SceneManager.LoadScene("Test", LoadSceneMode.Single);
        }

        

        if(isDead == true) { 
            SceneManager.LoadScene("DeadScreen", LoadSceneMode.Single);
            isDead = false;
        }
        else {
            if(isDead == false && currentScene == "DeadScreen" && Input.GetKeyDown("space")){
                SceneManager.LoadScene("Test", LoadSceneMode.Single);
            }

        }
        if(isWon == true) { 
            SceneManager.LoadScene("WonScreen", LoadSceneMode.Single);
            isWon = false;
        }
        else {
            if(isWon == false && currentScene == "WonScreen" && Input.GetKeyDown("space")){
                SceneManager.LoadScene("Test", LoadSceneMode.Single);
            }

        }
        
    }
}
