using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{

    public GameObject ennemyprefab;
    public float MinvalueY;
    public float MaxvalueY;
    public float ennemydestroytime = 11f;
    public float spawnx;
    void Start()
    {
        InvokeRepeating("instantiatenemy", 5f, 6f);

    }
    void instantiatenemy()
    {
        Vector3 enemypos = new Vector3(spawnx, Random.Range(MinvalueY, MaxvalueY));
        GameObject respawn = Instantiate(ennemyprefab, enemypos, Quaternion.identity);
        Destroy(respawn, ennemydestroytime);
    }

}
