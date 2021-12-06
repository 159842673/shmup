using UnityEngine;

public class shoot : MonoBehaviour
{
    public GameObject bullet;
    public Vector2 direction;
    public float bulletSpeed;
    public void Shoot()
    {
        var instantiatedBullet = Instantiate(bullet, transform.position, Quaternion.identity);
        var bulletMove = instantiatedBullet.GetComponent<move>();
        bulletMove.direction = direction;
        bulletMove.speed = bulletSpeed;
    }
  
}
