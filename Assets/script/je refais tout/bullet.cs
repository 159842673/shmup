using UnityEngine;

public class bullet : MonoBehaviour
{
    public float speed = 10f;
    public Rigidbody2D rb;
    float pv;
    void Start()
    {
        rb.velocity = transform.right * -speed;
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "player")
        {
            col.gameObject.GetComponent<player>().Damage();
            pv -= 1f;
        }
        if (col.gameObject.GetComponent<player>())
        {
            Destroy(gameObject);
        }
    }

}