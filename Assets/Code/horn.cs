using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class horn : MonoBehaviour
{

    public AudioSource hhorn;

    void Start()
    {
    }

    public void play()
    {
        Debug.Log("COLL");
        hhorn.Play();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
