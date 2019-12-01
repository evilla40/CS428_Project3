using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cannonFire2 : MonoBehaviour
{
    public GameObject shell;
    public float speed = 1000f;
    public float force = 3000f;
    Rigidbody rb;
    Transform t;
    float tiltAngle = 45f;
    public AudioSource boom;
    public float spWait;

    //public float spMWait = 2;
    //public float spLWait = 6;
    //public float beginWait = 2;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        t = GetComponent<Transform>();
        //StartCoroutine(coro());
    }

    // Update is called once per frame
    void Update()
    {
        //spWait = Random.Range(spLWait,spMWait);
    }

    public void shoot()
    {
        //yield return new WaitForSeconds(beginWait);
            /*GameObject bullet = Instantiate(shell,transform.position,Quaternion.identity) as GameObject;
            Rigidbody body = bullet.GetComponent<Rigidbody>();
            body.velocity += this.transform.forward * speed * Time.deltaTime;
            body.AddForce(Vector3.forward * speed);
            //Debug.Log("We have waited for");*/
            float tiltAroundX = Input.GetAxis("Vertical") * tiltAngle;
            float tiltAroundZ = Input.GetAxis("Horizontal") * tiltAngle;

        Quaternion target = Quaternion.Euler(tiltAroundX, 0, tiltAroundZ);

        // Dampen towards the target rotation
            GameObject newBullet = GameObject.Instantiate(shell, t.transform.position, t.transform.rotation) as GameObject;
            newBullet.GetComponent<Rigidbody>().velocity += Vector3.up * 5;
            newBullet.GetComponent<Transform>().rotation = Quaternion.Slerp(t.rotation, target,  Time.deltaTime * 5.0f);
            boom.Play();
            newBullet.GetComponent<Rigidbody>().AddForce(newBullet.transform.forward * 1000);
            //yield return new WaitForSeconds(spWait);

    }
}
