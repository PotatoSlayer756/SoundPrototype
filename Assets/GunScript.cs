using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour
{
    public Transform SpawnPoint;
    public GameObject bullett;
    public float bulletspeed = 10;
    public float speed = 10;
    public AudioSource bulletsound;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        Vector3 newVelo = transform.forward * moveX * speed;
        newVelo.y = rb.velocity.y;
        rb.velocity = newVelo;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var bullet = Instantiate(bullett, SpawnPoint.position, SpawnPoint.rotation);
            bullet.GetComponent<Rigidbody>().velocity = SpawnPoint.forward * bulletspeed;
            bulletsound.Play();
        }
    }
}
