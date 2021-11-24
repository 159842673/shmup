using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class joinin : MonoBehaviour
{
    int index = 0;
    [SerializeField] List<GameObject> vagabond = new List<GameObject>();
    PlayerInputManager manager;
    // Start is called before the first frame update
    private void Start()
    {
        manager = GetComponent<PlayerInputManager>();
        index = Random.Range(0, vagabond.Count);
        manager.playerPrefab = vagabond[index];
    }

   public void changerdeperso(PlayerInput ipt)
    {
        index = Random.Range(0, vagabond.Count);
        manager.playerPrefab = vagabond[index];
    }
}
