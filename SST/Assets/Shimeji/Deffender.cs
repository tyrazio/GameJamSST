using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class Deffender : MonoBehaviour {
    private GameObject SP;
    public enum Side {
        One,
        Two
     };

    public Side Player;

    public float speed = 5f;
    
	// Use this for initialization
	void Start () {
        if (Player == Side.One)
            SP = GameObject.Find("OneSP");
        if (Player == Side.Two)
            SP = GameObject.Find("TwoSP");

    }
	
	// Update is called once per frame
	void Update () {
		Move();
	}
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ball")
        ArtsCharge();
    }
    void Move() {
        if (Player == Side.One)
            One();
        if (Player == Side.Two)
            Two();
        
    }
    void One()
    {
        if (Input.GetKey(KeyCode.W))
            GetComponent<Rigidbody>().velocity = Vector3.forward * speed * 100f * Time.deltaTime;
        else if (Input.GetKey(KeyCode.S))
            GetComponent<Rigidbody>().velocity = - Vector3.forward * speed * 100f * Time.deltaTime;
        else if (!Input.GetKey(KeyCode.W) &&
            !Input.GetKey(KeyCode.S))
        {
            GetComponent<Rigidbody>().velocity = Vector3.zero;
        }
    }
    void Two()
    {
        if (Input.GetKey(KeyCode.O))
            GetComponent<Rigidbody>().velocity = Vector3.forward * speed * 100f * Time.deltaTime;
        else if (Input.GetKey(KeyCode.L))
            GetComponent<Rigidbody>().velocity = -Vector3.forward * speed * 100f * Time.deltaTime;
        else if (!Input.GetKey(KeyCode.O) &&
            !Input.GetKey(KeyCode.J))
        {
            GetComponent<Rigidbody>().velocity = Vector3.zero;
        }
    }
    void ArtsCharge(){
        SP.GetComponent<Arts>().SpCharge();
    }
#if UNITY_EDITOR
    [CanEditMultipleObjects]
    [CustomEditor(typeof(Deffender))]
    public class DefEX : Editor {
        SerializedProperty Playerpro;
        SerializedProperty Speedpro;
        SerializedProperty Powerpro;
        private void OnEnable()
        {
            Playerpro = serializedObject.FindProperty("Player");
            Speedpro = serializedObject.FindProperty("speed");
        }
        public override void OnInspectorGUI()
        {
            serializedObject.Update();
            EditorGUI.BeginChangeCheck();
            Playerpro.enumValueIndex =(int)(Side)EditorGUILayout.EnumPopup("プレイヤー",(Side)Playerpro.enumValueIndex);
            Speedpro.floatValue = EditorGUILayout.FloatField("スピード", Speedpro.floatValue);
            if (EditorGUI.EndChangeCheck())
                serializedObject.ApplyModifiedProperties();

        }
    }
#endif
}
