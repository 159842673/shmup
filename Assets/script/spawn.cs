using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject ennemyprefab;
    public float minInstantiateValue;
    public float maxInstantiateValue;
    private void Start()
    {
        InvokeRepeating("instantiatenemy", 4f, 5f);
    }
    void instantiatenemy()
    {
        Vector3 enemypos = new Vector3(11f, Random.Range(minInstantiateValue, maxInstantiateValue));
        Instantiate(ennemyprefab, enemypos,Quaternion.Euler(0f,0f,180f));
    }
}
