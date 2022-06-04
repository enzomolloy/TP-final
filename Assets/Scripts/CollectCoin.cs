using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoin : MonoBehaviour
{
    public GameObject coin;

    void OnCollisionEnter(Collision col)
    { 
        if (col.gameObject.name == "Player")
        {
            CoinDestroy.countercoin++;
            coin.SetActive(false);
        }
    }
    public void botonns()
    {
        coin.SetActive(true);
    }
}

