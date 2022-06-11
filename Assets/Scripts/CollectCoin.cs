using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoin : MonoBehaviour
{
    public GameObject coin;
    public AudioManager Am;

    void OnCollisionEnter(Collision col)
    { 
        if (col.gameObject.name == "Player")
        {
            CoinDestroy.countercoin++;
            coin.SetActive(false);
            Am.PlayClip5();
        }
    }
    public void botonns()
    {
        coin.SetActive(true);
    }
}

