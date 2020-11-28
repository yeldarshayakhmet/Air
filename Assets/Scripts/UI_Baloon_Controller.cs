using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Baloon_Controller : MonoBehaviour
{
    public Text Baloon_UI;
    public AirManagement ballonLevel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        double temp=((ballonLevel.ballonLevel)+ballonLevel.BALOON);
        Baloon_UI.text=temp.ToString("F0") + "/" +(2*(ballonLevel.BALOON)).ToString();
    }
}
