using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLife : MonoBehaviour
{
    public Text gameOver;
    public GameObject player;
    public GameObject camara;
    public GameObject boton;
    public Text won;
    public GameObject helpc;

    void Start()
    {
        won.enabled = false;
        gameOver.enabled = false;
        camara.SetActive(false);
        boton.SetActive (false);

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
            player.SetActive(false);
            gameOver.enabled = true;
            camara.SetActive(true);
            boton.SetActive(true);
        }

    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "WinPlatform")
        {
            player.SetActive(false);
            won.enabled = true;
            camara.SetActive(true);
            boton.SetActive(true);
            transform.position = new Vector3(0, -5, -30);
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "kill")
        {
            Lifecounter.countervida -= 20;
        }
        if (Lifecounter.countervida <= 0)
        {
            transform.position = new Vector3(0, -5, -30);
        }
    }

    public void botonn()
    {
        won.enabled = false;
        player.SetActive(true);
        gameOver.enabled = false;
        camara.SetActive(false);
        boton.SetActive(false);
        Lifecounter.countervida = 200;
        CoinDestroy.countercoin = 0;
        helpc.transform.position = new Vector3(-8.95f, 16.01f, 34.43f);
    }
 
}

