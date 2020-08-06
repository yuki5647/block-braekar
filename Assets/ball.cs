using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ball : MonoBehaviour
{

    public float speed = 5.0f;
    private Rigidbody myRigidbody;

    private float coefficient = 0.9f;

    private bool isEnd = false;

    private float visiblePosZ = -7f;

    private GameObject GameOvertext;

    private GameObject cleartext;

    GameObject[] tagObjects;




    // Use this for initialization
    void Start()
    {

        this.GameOvertext = GameObject.Find("GameOvertext");

        this.cleartext = GameObject.Find("cleartext");



        myRigidbody = this.GetComponent<Rigidbody>();
        myRigidbody.AddForce((transform.forward + transform.right) * speed, ForceMode.VelocityChange);
    }

    // Update is called once per frame
    void Update()
    {

        if (this.transform.position.z < this.visiblePosZ)
        {
            this.GameOvertext.GetComponent<Text>().text = "GameOver";
        }

    }

    void Check(string tagname)
    {
        tagObjects = GameObject.FindGameObjectsWithTag("blocktag");
        Debug.Log(tagObjects.Length); //tagObjects.Lengthはオブジェクトの数
        if (tagObjects.Length == 2)
        {
            this.cleartext.GetComponent<Text>().text = "clear";
        }
    }
    void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.tag == "blocktag")
        {

            this.cleartext.GetComponent<Text>().text = "clear";
        }
        if (other.gameObject.tag == "blocktag")
        {
            GetComponent<ParticleSystem>().Play();
        }
    }
}
        
    

