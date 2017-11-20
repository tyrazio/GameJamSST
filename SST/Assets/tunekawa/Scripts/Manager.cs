using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour {

    private GameObject title;
    private GameObject title2;
    private GameObject title3;
	// Use this for initialization
	void Start () {
        title = GameObject.Find("Start");
        title2 = GameObject.Find("p1win");
        title3 = GameObject.Find("p2win");
        title2.SetActive(false);
        title3.SetActive(false);
	}
	
    public void P1Win()
    {
        StartCoroutine("P1win");
    }
    IEnumerator P1win()
    {
        title2.SetActive(true);
        yield return new WaitForSeconds(4.0f);

    }
    public void P2Win()
    {
        StartCoroutine("P2win");
    }
    IEnumerator P2win()
    {
        title3.SetActive(true);
        yield return new WaitForSeconds(4.0f);
    }
}

