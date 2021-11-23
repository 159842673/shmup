using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float speed = 5;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void FixedUpdate()
    {
        Vector2 pos = transform.position;
        pos.x -= speed * Time.fixedDeltaTime;
        transform.position = pos;
        if (pos.x < -11)
        {
            Destroy(gameObject);
        }

    }
}
