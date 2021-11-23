using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyed : MonoBehaviour
{
    bool canbedestroyed = false;
    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < 17.0f)
        {
            canbedestroyed = true;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!canbedestroyed)
        {
            return;
        }
        Bullet bullet = collision.GetComponent<Bullet>();
        if (bullet != null)
        {
            if (!bullet.isenemy)
            {
                Destroy(gameObject);
                Destroy(bullet.gameObject);
            }

        }


    }
}
