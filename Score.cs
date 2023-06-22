using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text text; //tekst dat op het scherm komt te staan
    public int attemptCounter; //telt de aantal pickups
    
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        if (attemptCounter == 11) //hier komt die als je 11 pickups hebt opgepakt
        {
            text.text = "Je hebt de hitgame uitgespeeld";
        }
        else
        {
            text.text = "Score: " + attemptCounter.ToString(); //laat de score zien
        }
        
    }
}
