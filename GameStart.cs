using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameStart : MonoBehaviour
{
    // Start is called before the first frame update
    public void TheStart()
    {
       
        SceneManager.LoadScene("SampleScene"); //laadt een scene in
    }

    public void GameOver()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("StartScreen");
    }
}
