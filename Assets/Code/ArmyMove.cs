using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmyMove : MonoBehaviour
{
    
    public float speed = 1;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
            this.GetComponent<Rigidbody>().velocity += Vector3.forward * 0.01f;
            this.GetComponent<Rigidbody>().AddForce(this.transform.forward * 0.01f );
    }
}
