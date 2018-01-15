using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Times : MonoBehaviour {
    public float time = 0;
    public bool flag = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timechange();
	}

    public void Normal()
    {
        Time.timeScale = 1;
    }
    void timechange() {
        if (flag == true)
        {
            Time.timeScale = time;
            flag = false;
        }
    }
}
