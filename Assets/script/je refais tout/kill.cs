using UnityEngine;

public class kill : MonoBehaviour
{
    public Transform FirePoint;
    public GameObject bulletPrefab;
    public float fireRate;
    public float nextFire;
   public void Start()
    {
        fireRate = 1f;
        nextFire = Time.time;
    }
    public void Update()
    {
        if (Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(bulletPrefab, FirePoint.position, FirePoint.rotation);
        }
    }
}