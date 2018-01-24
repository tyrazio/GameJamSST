using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BallColor : MonoBehaviour
{
    public GameObject Trail;
    public Material[] Ballmate = new Material[7];
    public Material[] Trailmate = new Material[7];
    public int id = 0;
    

    // Use this for initialization
    void Start()
    {
        StartColor();
    }
    private void StartColor()
    {
        GetComponent<MeshRenderer>().material = Ballmate[id];
        gameObject.transform.GetChild(0).GetComponent<TrailRenderer>().material = Trailmate[id];
    }
    private void ChangeColor(){
        gameObject.transform.GetChild(0).transform.parent = null;
        Instantiate(Trail, gameObject.transform);
        StartColor();
    }
    private void Next() {
        id++;
        if (id > 6)
            id = 0;
        ChangeColor();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name != "field_base")
            Next();
    }
    // Update is called once per frame
    void Update()
    {

    }
}

