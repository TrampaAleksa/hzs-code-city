using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigerShakeAndFall : MonoBehaviour
{
    public shake shaking;
    public GameObject objThatFalls;
    public Transform fallPoint;
    public float fallSpeed = 5f;

    private bool var;

    // Start is called before the first frame update
    void Start()
    {

        shaking = GetComponent<shake>();
        shaking.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
          
           // objThatFalls.transform.position = Vector3.MoveTowards(objThatFalls.transform.position, fallPoint.position, fallSpeed * Time.deltaTime);
        
    }
    
    
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            
            Debug.Log("pipnuo");
            StartCoroutine(fja());     
        }
    }
        

    void drm()
    {
        shaking.enabled = true;
    }


    IEnumerator fja()
    {
        drm();
        yield return new WaitForSeconds(1.5f);    
        shaking.enabled = false;


    }
        
}
