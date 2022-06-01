using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lifecounter : MonoBehaviour
{
    public static int countervida = 200;
    public Text vida;

    void Start()
    {
        vida.enabled = true;
    }

    void Update()
    {
        if (countervida > 0)
        { 
            vida.text = ("Vida: " + countervida.ToString() + "/200");
        }
        else
        {
            vida.enabled = false;
        }
    }
}
