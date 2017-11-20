using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetroyArea : MonoBehaviour {

    void OnTriggerExit(Collider c)
    {
        if (c.tag == "ball")
        {
            Destroy(c.gameObject);
        }
    }
}
