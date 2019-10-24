using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particlesONCollecting : MonoBehaviour
{
    public Transform particle;

    // Start is called before the first frame update
    void Start()
    {
        particle.GetComponent<ParticleSystem>().enableEmission = false;   
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
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
