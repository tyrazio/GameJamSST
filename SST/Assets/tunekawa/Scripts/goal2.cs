using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goal2 : MonoBehaviour {

    score sc;
    int p1;
    int p2;
    int c1;
    int c2;
    void Start()
    {
        sc = FindObjectOfType<score>();

    }
    // Update is called once per frame
    void Update()
    {
        p1 = sc.score1;
        p2 = sc.score2;
        c1 = sc.count1;
        c2 = sc.count2;
    }
    void OnTriggerEnter(Collider obj)
    {
        if (obj.tag == "boal")
        {
            if (p1 == 20 && p2 == 20)
            {
                sc.Count2();
            }
            else
            {
                sc.Point2();
            }

        }
    }
}
