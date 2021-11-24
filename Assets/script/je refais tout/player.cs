using UnityEngine;
using UnityEngine.InputSystem;

public class player : MonoBehaviour
{
    public InputAction playercontrol;
    public Rigidbody2D rb;
    public InputAction tirer;
    Vector2 move = Vector2.zero;


    //caractéristique du perso
    public float speed = 5f;
    public int pv = 3;

    //action
    public Joueur playercontrols;
    private InputAction bouge;
    private InputAction shoote;
    [SerializeField] GameObject balle;
    public void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }
    private void Awake()
    {
        playercontrols = new Joueur();
    }
    private void OnEnable()
    {
        bouge = playercontrols.Player.Move;
        bouge.Enable();
        shoote = playercontrols.tirer.shooter;
        shoote.Enable();
        shoote.performed += pioupiou;
    }
    private void OnDisable()
    {
        bouge.Disable();
        shoote.Disable();
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

    public void pioupiou(InputAction.CallbackContext ctx)
    {
        Debug.Log("t mort");
        if (ctx.started)
        {
            GameObject.Instantiate(balle, transform.position,transform.rotation);

        }
    }

    //je tente celui la j'ai pas trouvé au-dessus


}
