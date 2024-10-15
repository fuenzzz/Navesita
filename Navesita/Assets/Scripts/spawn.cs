using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public BoxCollider2D gridarea;
    public GameObject asteroideprefab;
    public float delay = .5f;
    public int inicio = 3;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("randompos", inicio, delay);  
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void randompos()
    {
        Bounds limites = gridarea.bounds;

        float x = Random.Range(limites.min.x, limites.max.x);
        float y = Random.Range(limites.min.y, limites.max.y);
        Vector3 pos = new Vector3(x, y, 0);
        Instantiate(asteroideprefab, pos, asteroideprefab.transform.rotation);

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("meteorito"))
        {
            Destroy(collision.gameObject);
        }

    }
}
