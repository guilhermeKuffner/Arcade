using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] Transform[] SpawnPoints;
    [SerializeField] GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnimes",0.5f,0.5f);
        
    }
    void SpawnEnimes()
    {
        int index = Random.Range(0,SpawnPoints.Length);
        Instantiate(enemy,SpawnPoints[index].position,Quaternion.identity);
    }
}
