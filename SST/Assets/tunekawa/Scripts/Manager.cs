using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour {

    public Text title;
    public Text title2;
    public Text title3;
	// Use this for initialization
	void Start () {
        title2.gameObject.SetActive(false);
        title3.gameObject.SetActive(false);
        GameStart();
	}
	
    public void P1Win()
    {
        GameObject.Find("BallCreate").GetComponent<BallCreate>().flag = false;
        StartCoroutine("P1win");
    }
    IEnumerator P1win()
    {
        title2.gameObject.SetActive(true);
        yield return new WaitForSeconds(4.0f);

    }
    public void P2Win()
    {
        GameObject.Find("BallCreate").GetComponent<BallCreate>().flag = false;
        StartCoroutine("P2win");
    }
    IEnumerator P2win()
    {
        title3.gameObject.SetActive(true);
        yield return new WaitForSeconds(4.0f);
    }
    public void GameStart()
    {
        StartCoroutine("Gamestart");
    }
    IEnumerator Gamestart()
    {
        yield return new WaitForSeconds(3.0f);
        title.gameObject.SetActive(false);
    }
}

