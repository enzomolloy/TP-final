using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lifecounter : MonoBehaviour
{
    public static int countervida = 200;
    public Text vida;

    // Update is called once per frame
    void Update()
    {
        vida.text = (countervida.ToString());
    }
}
