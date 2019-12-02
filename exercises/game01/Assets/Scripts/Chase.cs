using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Chase : MonoBehaviour
{
    float speed;
    float timeLeft;
    public ParticleSystem hit;
    public GameObject sphere;
    void Start()
    {
        speed = Random.Range(0f, 5f);
        timeLeft = 4;
        hit.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            speed = Random.Range(0f, 5f);
            timeLeft = 5;
        }
        int count = GameObject.Find("Car").GetComponent<CarController>().count;
        if (GameObject.Find("Sphere") == true && count < 8)
        {
            gameObject.transform.LookAt(sphere.transform, Vector3.up);
            transform.position = transform.position + transform.forward * speed * Time.deltaTime;
        }
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Projectile"))
        {
            other.gameObject.SetActive(false);
            gameObject.SetActive(false);
            hit.transform.position = transform.position;
            hit.Play();
        }
    }
}
