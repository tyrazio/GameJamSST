using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goal1 : MonoBehaviour {

    // Use this for initialization
    score sc;
    public int p1;
    public int p2;
    public int c1;
    public int c2;
    void Start()
    {
        sc = FindObjectOfType<score>();

        
    }
    // Update is called once per frame
    void Update () {
        p1 = sc.score1;
        p2 = sc.score2;
        c1 = sc.count1;
        c2 = sc.count2;
	}
    void OnTriggerEnter(Collider obj)
    {
        if(obj.tag == "Ball")
        {
            if(p1 == 20 && p2 == 20)
            {
                sc.Count1();
                Destroy(obj.gameObject);
            }
            else
            {
                sc.Point1();
                Destroy(obj.gameObject);
            }

        }
    }
}

