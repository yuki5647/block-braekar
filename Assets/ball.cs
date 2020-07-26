using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ball : MonoBehaviour {

    public float speed = 5.0f;
    private Rigidbody myRigidbody;

    private float coefficient = 0.9f;

    private bool isEnd = false;

    private float visiblePosZ = -7f;

    private GameObject GameOvertext;

    private GameObject cleartext;

   

	// Use this for initialization
	void Start () {

        this.GameOvertext = GameObject.Find("GameOvertext");

        this.cleartext = GameObject.Find("cleartext");



        myRigidbody = this.GetComponent<Rigidbody>();
        myRigidbody.AddForce((transform.forward + transform.right) * speed, ForceMode.VelocityChange);
	}
	
	// Update is called once per frame
	void Update () {

        if (this.transform.position.z < this.visiblePosZ)
        {
            this.GameOvertext.GetComponent<Text>().text = "GameOver";
        }

    }
    private void OnCollisionEnter(Collision other)
    {
        Debug.Log(other.gameObject.tag);
        if (other.gameObject.tag == "blocktag")
        {
            
                    this.cleartext.GetComponent<Text>().text = "clear";
                }
            }
        }
    

