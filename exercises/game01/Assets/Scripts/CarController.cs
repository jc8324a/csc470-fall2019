using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarController : MonoBehaviour
{
    public List<WheelCollider> throttleWheels;
    public List<WheelCollider> steeringWheels;
    public float strengthCoefficient = 20000f;
    public float maxTurn = 20f;
    public Text countText;
    public Text timerText;
    public Text winText;
    public Text winText2;
    public Text crashText;
    public Text crashText2;
    public int count;
    private float time;
    bool crash = false;
    public ParticleSystem smoke;
    public GameObject sphere;
    public TrailRenderer trail;
    public GameObject rightGun;
    public GameObject leftGun;
    public GameObject projectilePrefab;


    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        countText.text = "Coins: " + count.ToString() + "/8";
        winText.text = "";
        winText2.text = "";
        crashText.text = "";
        crashText2.text = "";
        smoke.Stop();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        bool crash = !GameObject.Find("Sphere");
        if (crash == false)
        {
            foreach (WheelCollider wheel in throttleWheels)
            {
                wheel.motorTorque = strengthCoefficient * Time.deltaTime * Input.GetAxis("Vertical");
            }
            foreach (WheelCollider wheel in steeringWheels)
            {
                wheel.steerAngle = maxTurn * Input.GetAxis("Horizontal");
            }

            trail.transform.position = sphere.transform.position;

            if (Input.GetKeyDown(KeyCode.Space))
            {
                //pos will be the position we will create the hotdog, we want to position it in
                //front of the player a bit, and at approximately eye level.
                Vector3 posRight = rightGun.transform.position;
                Vector3 posLeft = leftGun.transform.position;
                GameObject projectileRight = Instantiate(projectilePrefab, posRight, transform.rotation);
                GameObject projectileLeft = Instantiate(projectilePrefab, posLeft, transform.rotation);
                Destroy(projectileRight, 5);
                Destroy(projectileLeft, 5);
            }
        }
        else
        {
            foreach (WheelCollider wheel in throttleWheels)
            {
                wheel.motorTorque = 0;
            }
            foreach (WheelCollider wheel in steeringWheels)
            {
                wheel.steerAngle = 0;
            }
        }

        if (Input.GetKeyDown("return"))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        if (count < 8 && crash == false)
            {
                time += Time.deltaTime;
                var minutes = time / 60;
                var seconds = time % 60;
                var fraction = (time * 100) % 100;
                timerText.text = string.Format("{0:00} : {1:00} : {2:000}", minutes, seconds, fraction);
            }
            if (crash == true)
            {
                smoke.transform.position = sphere.transform.position;
                smoke.Play();
            }
        }

    void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Pick Up") && crash == false)
            {
                other.gameObject.SetActive(false);
                count = count + 1;
                countText.text = "Coins: " + count.ToString() + "/8";
                if (count == 8)
                {
                    winText.text = "You Win";
                    winText2.text = "Press Enter to Replay";
                }
            }
        }
}