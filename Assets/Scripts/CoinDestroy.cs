﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinDestroy : MonoBehaviour
{
  
    public static int countercoin;
    public Text lbl;

    void Update()
    {
        lbl.text = ("Monedas: " + countercoin.ToString());
    }
}
