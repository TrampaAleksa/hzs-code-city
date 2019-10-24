using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectCoins : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {  
       if (other.gameObject.CompareTag("CPUS"))
          {
           // Debug.Log("i collected cpu");
            Destroy(other.gameObject);
          }
        }
    }

