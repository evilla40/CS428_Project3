using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Init : MonoBehaviour
{
    public GameObject cam;

    void Start()
    {
        cam = GameObject.FindWithTag("camS");
        Transform t = cam.GetComponent<Transform>();
        t.position = new Vector3(66.45f, 16.09f, -302.4175f);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
