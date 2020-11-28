using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yoda : MonoBehaviour
{
    public GameObject player;
    public AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D (Collider2D collider)
    {
        if (collider.gameObject == player)
        {
            audioSource.Play();
                        Destroy(gameObject);

        }
    }
}
