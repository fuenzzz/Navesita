using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Temporizador : MonoBehaviour
{
    public TMP_Text counterText;
    public float sec, min;
    public GameObject delay;
    bool corte=false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        min = (int)(Time.time / 60f);
        sec = (int)(Time.time % 60f);
        counterText.text = min.ToString("00") + ":" + sec.ToString("00");

        if (sec%10==0 && sec!=0 && !corte)
        {
            delay.GetComponent<spawn>().acelerar();
            corte = true;   
        }
        else if(sec%10!=0)
        {
            corte = false;
        }

    }
}
