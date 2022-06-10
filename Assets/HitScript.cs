using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitScript : MonoBehaviour
{
    public AudioSource hitsound;
    public void OnCollisionEnter(Collision collision)
    {
        hitsound.Play();
    }
}
