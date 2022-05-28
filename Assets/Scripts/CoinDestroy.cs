using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinDestroy : MonoBehaviour
{
    public GameObject coin;
    int countercoin;
    public Text lbl;

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Player")
        {
            Destroy(coin);
            countercoin++;
          
            Debug.Log(countercoin);
        }

        




    }
}
