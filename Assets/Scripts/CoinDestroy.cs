using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinDestroy : MonoBehaviour
{

    public static int countercoin;
    public Text lbl;
    public GameObject player;

    void Update()
    {
        if (Lifecounter.countervida > 0 && PlayerLife.ganar == 0)
        {
            lbl.enabled = true;
            lbl.text = ("Monedas: " + countercoin.ToString() + "/9");
        }
        else
        {
            lbl.enabled = false;
        }
    }
}

