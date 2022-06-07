using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text txtTimeCustom;

    public static float customTime;
    bool isCounting;
   
    
    void Start()
    {
        customTime = 0;
    }

   
    void Update()
    {
        if (Lifecounter.countervida > 0 && PlayerLife.ganar == 0)
        {
        txtTimeCustom.enabled = true;

        float elapsedTime = Time.time;

        txtTimeCustom.text = customTime.ToString();
        txtTimeCustom.text = Mathf.Floor(customTime).ToString();


        if (Input.GetKeyDown(KeyCode.W))
        {
            isCounting = true;
        }

        if (isCounting)
        {
            customTime += Time.deltaTime;
        }
        }
        else
        {
            txtTimeCustom.enabled = false;
        }



    }
}
