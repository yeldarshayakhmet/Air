using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    public GameObject player;
    public GameController gameController;

    // Start is called before the first frame update
    void Start()
    {
        gameController = GameController.instance;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == player)
        {
            gameController.isDead = true;
        }
    }
}
