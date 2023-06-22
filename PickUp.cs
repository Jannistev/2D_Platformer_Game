using System;
using Unity.VisualScripting;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public Score score; //de score script
    public GameObject gameobject; //het object dat word weggehaald

    // Update is called once per frame

    void OnTriggerEnter2D(Collider2D collider) //als je een object raakt dan komt die hier
    {
        Destroy(gameObject); //verwijderd de gameobject
        score.attemptCounter++;

        print("sdaf");
    }
}
