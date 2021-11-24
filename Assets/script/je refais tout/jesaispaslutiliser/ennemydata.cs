using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName ="enemydata",menuName = "My Game/Enemy data")]
public class ennemydata : ScriptableObject
{
    public string enemyname;
    public string description;
    public GameObject enemysprite;
    public int healt = 100;
    public float speed = 1.0f;
    public int dmg = 1;
}
