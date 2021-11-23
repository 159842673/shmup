using UnityEngine;

public class enemy : MonoBehaviour
{
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
}

