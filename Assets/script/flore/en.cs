using UnityEngine;

public class en : MonoBehaviour
{
    private shoot shooter;

    // Start is called before the first frame update
    private void Start()
    {
        shooter = GetComponent<shoot>();
        InvokeRepeating(nameof(Shoot), 0, 0.4f);
    }

    private void Shoot()
    {
        shooter.Shoot();
    }
}
