using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour
{
    //public GameObject cam;
    public float Health = 1000;
    public AudioSource boom;
    public void IncHealth()
    {
        Health *= 1.1f;
        boom.Play();
        Debug.Log("Health increased");
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
