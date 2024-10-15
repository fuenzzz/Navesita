using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meteoritos : MonoBehaviour
{

    public float speed;
    public Rigidbody2D rb;
    Vector2 startPos;
    public BoxCollider2D gridarea;

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

    public void randompos()
    {
        Bounds limites = gridarea.bounds;

        float x = Random.Range(limites.min.x, limites.max.x);
        float y = Random.Range(limites.min.y, limites.max.y);

        transform.position = new Vector3(Mathf.Round(x), Mathf.Round(y), 0);

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("espacio"))
        {
            randompos();
        }

    }

}
