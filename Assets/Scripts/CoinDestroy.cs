using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinDestroy : MonoBehaviour
{

    public static int countercoin;
    public Text lbl;

    void Update()
    {
        if (Lifecounter.countervida > 0)
        {
            lbl.enabled = true;
            lbl.text = ("Monedas: " + countercoin.ToString());
        }
        else
        {
            lbl.enabled = false;
        }
    }
}
