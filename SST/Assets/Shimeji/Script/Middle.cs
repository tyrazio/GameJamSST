using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Middle : MonoBehaviour {
    public float speed = 5f;
    public float limit = 5f;
    public bool direction = true;
	// Use this for initialization
	void Start () {
        transform.position = Vector3.zero + Vector3.up * transform.lossyScale.y / 2;
	}
	
	// Update is called once per frame
	void Update () {
        Move();
        Change();
	}

    public void Move()
    {
        if (direction == true){
            transform.Translate(new Vector3(0, 0, speed) * Time.deltaTime);
        }
        else {
           transform.Translate(new Vector3(0, 0, -speed) * Time.deltaTime);
        }
    }
    public void Change()
    {
        if (Vector3.Distance(Vector3.zero + Vector3.up * transform.lossyScale.y / 2, transform.position) >= limit &&
            transform.position.z > 0)
        {
            direction = false;
        }
        if(Vector3.Distance(Vector3.zero + Vector3.up * transform.lossyScale.y / 2, transform.position) >= limit &&
            transform.position.z < 0) {
            direction = true;
        }
    }
}
