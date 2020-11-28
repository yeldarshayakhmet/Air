using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ending : MonoBehaviour
{
    public GameObject player;
    public GameController gameController;
    BoxCollider2D endingCollider;
    // Start is called before the first frame update
    void Start()
    {
        //trapCollider = GetComponent<BoxCollider2D>();
        gameController=GameController.instance;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == player)
        {
            gameController.isWon = true;
        }
    }
}
