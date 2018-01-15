using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrailDelete : MonoBehaviour {
    public float timer = 10f;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        if (GetComponent<Rigidbody>().velocity == Vector3.zero) {
            timer -= Time.deltaTime;
        }

        if (timer == 0) {
            Destroy(gameObject);
        }
	}
}
