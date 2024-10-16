using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Temporizador : MonoBehaviour
{
    public TMP_Text counterText;
    float sec, min;
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
    }
}
