using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brock : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter(Collision collision)
    {


        Destroy(gameObject);

    }
    void OnTriggerEnter(Collider other)
    {
        GetComponent<ParticleSystem>().Play();
    }




}
    
        

