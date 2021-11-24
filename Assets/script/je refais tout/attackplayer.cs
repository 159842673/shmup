using UnityEngine;

public class attackplayer : MonoBehaviour
{
    Rigidbody2D rb;
    public float xspd;
    public float yspd;

    public bool canshoot;
    public float cadence;
    public float pv;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();

    }
    void Update()
    {
        rb.velocity = new Vector2(xspd, yspd * -1);

    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "player")
        {
            col.gameObject.GetComponent<player>().Damage();
            Die();
        }
    }
    void Die()
    {
        Destroy(gameObject);
    }
}
