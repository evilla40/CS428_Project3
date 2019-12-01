using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class castle : MonoBehaviour
{
    //public GameObject cam;
    public float Health = 1000;

    void OnTriggerEnter(Collider c)
    {
        if(c.gameObject.tag == "enemy")
        {
            Health -= 1;
            Debug.Log("Fort attacked!");
            Destroy(c.gameObject);
        }
    }

    public void IncHealth()
    {
        Health *= 1.1f;
    }

    void Start()
    {
        //cam = GameObject.FindWithTag("camS");
        //Transform t = cam.GetComponent<Transform>();
        //t.position = new Vector3(66.45f, 16.09f, -302.4175f);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
