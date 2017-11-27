using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetroyArea : MonoBehaviour {

    void OnTriggerExit(Collider c)
    {
        if (c.tag == "Ball")
        {
            Destroy(c.gameObject);
            GameObject.Find("BallCreate").GetComponent<BallCreate>().flag = true;
        }
    }
}
