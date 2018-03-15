using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    static float  timeLeft = .2f;
    bool audioCue = false;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(audioCue && timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
        }
        else if(audioCue = true && timeLeft <= 0)
        {
            Destroy(gameObject);
        }

        transform.Rotate(90 * Time.deltaTime, 0, 0);
        

    }
    private void OnTriggerEnter(Collider other)
    {
        

        if (!audioCue) {
            AudioSource audio = GetComponent<AudioSource>();

            audio.Play();
            audioCue = true;
            //renderer.enabled = false;
            other.transform.localScale = new Vector3(.5f, .5f, .5f);

        }
    }

        //if (other.name == "Player")  

        //{
        //gameObject.SetActive(false);

        //AudioSource audio = GetComponent<AudioSource>();

        //audio.Play();

        //Destroy(gameObject);

        //}
    }
    //private void OnTriggerEnter(Collider other)
    //{
    //if (other.name == "Player")
    //{

    //other.GetComponent<PlayerScript>().points++;
    //AudioSource audio = GetComponent<AudioSource>();
    //audio.Play();
    //gameObject.SetActive(false);
    //gameObject.active = false;
    //Destroy(gameObject);
    //}
    //}

