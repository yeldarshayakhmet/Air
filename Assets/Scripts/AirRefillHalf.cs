using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirRefillHalf : MonoBehaviour
{
    public GameObject player;
    public AirManagement airManagement;
    public AudioClip audioClip;

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
            airManagement.airLevel += (airManagement.AIR)/2;
            AudioSource.PlayClipAtPoint(audioClip, gameObject.transform.position);
            Destroy(gameObject);
        }
    }
}
