using UnityEngine;

public class enemy : MonoBehaviour
{
    Rigidbody2D rb;
    
    //cara de l'ennemi
    public float pv;
    public float moveSpeed = 4;
    private void FixedUpdate()
    {
        Vector2 pos = transform.position;
        pos.x -= moveSpeed * Time.fixedDeltaTime;
        if (pos.x < -11)
        {
            Destroy(gameObject);
        }
        transform.position = pos;
    }
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();

    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "player")
        {
            col.gameObject.GetComponent<player>().Damage();
            pv -= 1f;


        }
        if (pv <= 0)
        {
            Die();
        }
    }
    void Die()
    {
        Destroy(gameObject);
    }
}

