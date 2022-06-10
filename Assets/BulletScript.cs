using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float life = 3;
    public AudioSource hitsound;
    void Awake()
    {
        Destroy(gameObject, life);
    }
    public void OnCollisionEnter(Collision collision)
    {
        /*Debug.Log("ass");
        hitsound.Play();*/
        Destroy(gameObject);
    }
}
