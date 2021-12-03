using UnityEngine;
using UnityEngine.InputSystem;

public class player : MonoBehaviour
{
    public InputAction playercontrol;
    public Rigidbody2D rb;
    Vector2 move = Vector2.zero;


    //caractéristique du perso
    public float speed = 5f;
    public float pv = 2f;

    //action
    public Joueur playercontrols;
    private InputAction bouge;
    private void Awake()
    {
        playercontrols = new Joueur();
    }
    public void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }
    private void OnEnable()
    {
        bouge = playercontrols.Player.Move;
        bouge.Enable();
    }
    private void OnDisable()
    {
        bouge.Disable();
    }
    void Update()
    {
        move = bouge.ReadValue<Vector2>();
    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(move.x * speed, move.y * speed);
    }

    public void Damage()
    {
        pv--;
        if (pv == 0)
        {
            Destroy(gameObject);
            Time.timeScale = 0f;
        }
    }
    public void commencer(InputAction.CallbackContext ctx)
    {
        Time.timeScale = 1f;
    }

}
