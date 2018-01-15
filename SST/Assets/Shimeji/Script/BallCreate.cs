using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCreate : MonoBehaviour
{
    public bool flag = false;
    public GameObject Ball;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Create();
    }
    void Create()
    {
        if (flag == true)
        {
            GameObject.Instantiate(Ball, gameObject.transform.position, Quaternion.identity);
            flag = false;
        }
    }
    void Flag() {
        flag = true;
    }
    
    //private IEnumerator Delay()
    //{
    //    yield return new WaitForSeconds(0.05f);
    //    flag = false;
    //}
}
