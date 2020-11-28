using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class AirManagement : MonoBehaviour
{
    public float AIR=1000;
    public float BALOON=100;
    //airLevel set to no movement:
    public float airLevel;
    public float airDecrement;
    public float ballonLevel;
    public float ballonAirTransfer;
    public GameController GameController;

    // Start is called before the first frame update
    void Start()
    {
        airLevel = AIR; 
        ballonLevel = 0;
        GameController=GameController.instance;
    }
    
    // Update is called once per frame
    void Update()
    {
        airLevel = Mathf.Clamp(airLevel - (airDecrement * Time.deltaTime), 0, AIR);
        //sets player to dead if tank is out of air
        if(airLevel == 0)
        {
            GameController.isDead = true;
        }    
    }


    //used when the player goes up
    public void increaseBallonAir(float time){
        if(ballonLevel < BALOON) {
        airLevel = Mathf.Clamp(airLevel - (ballonAirTransfer * time), 0, AIR);
        ballonLevel = Mathf.Clamp(ballonLevel + ((ballonAirTransfer * time)), -BALOON, BALOON);  
        } 
    }

    //used when the player goes down
    public void decreaseBallonAir(float time){
        if(ballonLevel != -BALOON){
            airLevel = Mathf.Clamp(airLevel + (ballonAirTransfer * time), 0, AIR);
            ballonLevel = Mathf.Clamp(ballonLevel - (2*(ballonAirTransfer * time)), -BALOON, BALOON);
        }
    }

}
