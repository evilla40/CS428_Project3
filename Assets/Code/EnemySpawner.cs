using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    
    public GameObject[] enemyTypes;
    public Vector3 spValues;
    public float spWait;
    public float spMWait;
    public float spLWait;
    public float beginWait;
    public bool stop;
    int randEnemy;

    void Start()
    {
        StartCoroutine(spawner());
    }

    // Update is called once per frame
    void Update()
    {
        spWait = Random.Range(spLWait,spMWait);
    }

    IEnumerator spawner()
    {
        yield return new WaitForSeconds(beginWait);
        while (true)
        {
            Vector3 spPos = new Vector3(Random.Range(-spValues.x, spValues.x),0,Random.Range(-spValues.z, spValues.z));
            Instantiate(enemyTypes[0], spPos + transform.TransformPoint(0,0,0), gameObject.transform.rotation);
            yield return new WaitForSeconds(spWait);
        }
    }
}
