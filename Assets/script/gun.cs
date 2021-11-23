using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour
{
    public Bullet bullet;
    Vector2 direction;
    public bool autoShoot = false;
    public float shootIntervalseconds = 0.5f;
    public float shootdelayseconds = 0.0f;
    float shoottimer = 0f;
    float delaytimer = 0f;

    // Start is called before the first frame update
    void Start()
    {
        direction = (transform.localRotation * Vector2.right).normalized;
        
        if (autoShoot)
        {
            if (delaytimer >= shootdelayseconds)
            {
                if (shoottimer >= shootIntervalseconds)
                {
                    Shoot();
                    shoottimer = 0;
                }
                else
                {
                    shoottimer += Time.deltaTime;
                }
            }
            else
            {
                delaytimer += Time.deltaTime;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Shoot()
    {
        GameObject go = Instantiate(bullet.gameObject, transform.position, Quaternion.identity);
        Bullet gobullet = go.GetComponent<Bullet>();
        gobullet.direction = direction;
    }
}
