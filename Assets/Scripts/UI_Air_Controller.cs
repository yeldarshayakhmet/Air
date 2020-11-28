using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Air_Controller : MonoBehaviour
{
    public Text Air_UI;
    public AirManagement airLevel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Air_UI.text=airLevel.airLevel.ToString("F0")+"/"+airLevel.AIR.ToString();
    }
}
