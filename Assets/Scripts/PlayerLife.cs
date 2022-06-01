using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLife : MonoBehaviour
{
    public Text gameOver;
    public GameObject player;
    public GameObject camara;
    

    void Start()
    {
        gameOver.enabled = false;
        
    }
    void Update()
    {
        if (Lifecounter.countervida > 0)
        {

        
         if (transform.position.y < -10)
         {
            Lifecounter.countervida -= 100;

            transform.position = new Vector3(0, -5, -30);
         }

        }
        else
        {
            gameOver.enabled = true;
            camara.transform.position = new Vector3(100, 100, 100);
        }

    }

}

