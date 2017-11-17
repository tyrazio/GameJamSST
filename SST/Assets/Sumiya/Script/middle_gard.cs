using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class middle_gard : MonoBehaviour {
    float z = 0;
    bool select = true;
    public float position_z = 0.0001f;
    // Use this for initialization
    void Start()
    {
        transform.position = new Vector3(0, 0, 0);
    }
	// Update is called once per frame
	void Update () {
        if (select == true)
        {
            z += position_z;
        }
        if (select == false)
        {
            z -= position_z;
        }
        transform.position = new Vector3(0, 0, z);
        if (z >= 5.5f)
        {
            select = false;
        }
        if (z <= -5.5f)
        {
            select = true;
        }
	}
}
