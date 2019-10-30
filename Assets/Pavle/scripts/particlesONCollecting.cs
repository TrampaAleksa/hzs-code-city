using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particlesONCollecting : MonoBehaviour
{
    public Transform particle;
    //public AudioSource cpuCollectSound;

    // Start is called before the first frame update
    void Start()
    {
        //cpuCollectSound = GetComponent<AudioSource>();
        particle.GetComponent<ParticleSystem>().enableEmission = false;   
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
           //cpuCollectSound.Play();
            particle.GetComponent<ParticleSystem>().enableEmission = true;
            StartCoroutine(stopParticles());
        }
           
    }

    IEnumerator stopParticles()
    {
        yield return new WaitForSeconds(1f);
   
        particle.GetComponent<ParticleSystem>().enableEmission = false;
    }
}
