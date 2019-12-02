using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Crash : MonoBehaviour
{
    public Text crashText;
    public Text crashText2;
    public bool crash;
    public int count;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (GameObject.Find("Car").GetComponent<CarController>().count < 8)
        {
            if (other.gameObject.CompareTag("World"))
            {
                crash = true;
                gameObject.SetActive(false);
                crashText.text = "You Crashed";
                crashText2.text = "Press Enter to Respawn";
            }
            if (other.gameObject.CompareTag("Chaser"))
            {
                crash = true;
                gameObject.SetActive(false);
                crashText.text = "You Were Caught";
                crashText2.text = "Press Enter to Respawn";
            }
        }
    }
}
