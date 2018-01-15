using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallStart : MonoBehaviour {
    public float firstspeed = 5;
         
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter(Collision collision)
    {
        if (GetComponent<Rigidbody>().constraints != RigidbodyConstraints.FreezeAll&&
            collision.gameObject.name == "field_base")
        {
            float angle = Random.Range(30f, 150f);
            if (Random.value < 0.5)
                angle *= -1;
            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionY;
            GetComponent<Rigidbody>().AddForce(new Vector3(Mathf.Cos(angle), 0, Mathf.Sin(angle)) * firstspeed * 100f);
            StartCoroutine(DelayMethod());
        }
    }
    private IEnumerator DelayMethod() {
        yield return new WaitForSeconds(0.05f);
        Destroy(this);
    }
}
