using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Arts : MonoBehaviour {
    public enum player {
        One,
        Two,
    }
    public enum Using {
        Active,
        Unactive
    }
    public Using artsuse = Using.Unactive;
    public player Statas = player.One;
    public float timer = 10;
    public float Ctimer = 10;
    public float max = 1;
    public float current = 0;
    public float charge = 0.2f;
    public float speed = 1.0f;
    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        EffectTime();
        Now();
        Limit();
        Timelate();
    }
    void Limit() {
        if (current >= max)
            current = max;
    }
    void Timelate()
    {
        if (current >= max &&
            Input.GetKey(KeyCode.D)&&
            Statas == player.One) {
            GameObject.FindWithTag("Time").GetComponent<Times>().flag = true;
            artsuse = Using.Active;
        }
        if (current >= max &&
            Input.GetKey(KeyCode.K) &&
            Statas == player.Two)
        {
            GameObject.FindWithTag("Time").GetComponent<Times>().flag = true;
            artsuse = Using.Active;
        }
    }
    void EffectTime() {
        if (artsuse == Using.Active) {
            Ctimer -= Time.deltaTime / Time.timeScale;
            current = Ctimer / timer;
        }
        if (Ctimer <= 0) {
            artsuse = Using.Unactive;
            GameObject.FindWithTag("Time").GetComponent<Times>().Normal();
            current = 0;
            Ctimer = 10;
            
        }
        if (artsuse == Using.Active &&
            Time.timeScale >= 1) {
            GameObject.FindWithTag("Time").GetComponent<Times>().flag = true;
        }
    }
    public void SpCharge() {
        if (artsuse == Using.Unactive)
            current += charge;
    }
    void Now() {
        if (current > GetComponent<Image>().fillAmount)
        {
            GetComponent<Image>().fillAmount += Time.deltaTime * speed;
        } else if(current < GetComponent<Image>().fillAmount&&
            artsuse == Using.Active){
            GetComponent<Image>().fillAmount = current;
        }else {
            GetComponent<Image>().fillAmount = current;
        }

    }
}
