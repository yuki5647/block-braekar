using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {
    public float speed = 5.0f;



    // Use this for initialization
    void Start() {
        
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (this.transform.position.x < 4.5)
                this.transform.position += Vector3.right * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (this.transform.position.x > -4.5)
                this.transform.position += Vector3.left * speed * Time.deltaTime;
        }

    }
}
