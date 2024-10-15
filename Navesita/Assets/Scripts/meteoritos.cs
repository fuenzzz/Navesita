using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meteoritos : MonoBehaviour
{

    public float speed;
    public Rigidbody2D rb;
    Vector2 startPos;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        Launch();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Launch()
    {
       float x = Random.Range(-1, 2);

           rb.velocity = new Vector2(x * speed * Time.deltaTime, -speed * Time.deltaTime);
        
    }


}
