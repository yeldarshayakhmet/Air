using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public static GameController instance = null;
    
    public bool isDead = false;
    public bool isWon = false;

    public Button playButton;
    public Button exitButton;

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

    void Start(){
        playButton =  GameObject.FindGameObjectWithTag("PlayButton").GetComponent<Button>();
        exitButton =  GameObject.FindGameObjectWithTag("ExitButton").GetComponent<Button>();
        playButton.onClick.AddListener(OnPlayClicked);
        exitButton.onClick.AddListener(OnExitClicked); 
    }

    void OnPlayClicked (){
        SceneManager.LoadScene("Test", LoadSceneMode.Single);
    }

    void OnExitClicked (){
        Application.Quit();
    }

    // Update is called once per frame
    void Update()
    {
        string currentScene = SceneManager.GetActiveScene().name;

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
				StartCoroutine(ReloadTheLevel());
            }

        }

		if (Input.GetKeyDown("escape"))
		{
			StartCoroutine(ReloadTheLevel());
		}
        
    }

    IEnumerator ReloadTheLevel()
	{
		SceneManager.LoadScene("Intro", LoadSceneMode.Single);
		do
		{
			yield return null;
		}
		while (SceneManager.GetActiveScene() != SceneManager.GetSceneByName("Intro"));

		playButton = GameObject.FindGameObjectWithTag("PlayButton").GetComponent<Button>();
		exitButton = GameObject.FindGameObjectWithTag("ExitButton").GetComponent<Button>();
		playButton.onClick.AddListener(OnPlayClicked);
		exitButton.onClick.AddListener(OnExitClicked);

	}
}
