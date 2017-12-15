using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour {
    public int max = 20;
    public int score1 = 0;
    public int score2 = 0;
    public int count1 = 0;
    public int count2 = 0;
    public Text p1text;
    public Text p2text;

    

    void Update()
    {
        if (max == score1 && max == score2)
        {
            if(count1 == 0 && count2 == 0)
            {
                p1text.text = "Deuce";
                p2text.text = "Deuce";
            } else if(count1 > count2)
            {
                if(count1 >= 2)
                {
                    FindObjectOfType<Manager>().P1Win();
                } else if(count1 > count2)
                {
                    p1text.text = "Advantage";
                    p2text.text = score2.ToString();
                } else if(count1 == 1 && count2 == 1)
                {
                    count1 = 0;
                    count2 = 0;
                }
            }
            else if (count2 > count1)
            {
                if (count2 >= 2)
                {
                    FindObjectOfType<Manager>().P2Win();
                }
                else if (count2 > count1)
                {
                    p1text.text = score1.ToString();
                    p2text.text = "Advantage";
                }
                else if (count1 == 1 && count2 == 1)
                {
                    count1 = 0;
                    count2 = 0;
                }
            }
        }
        else
        {
            p1text.text = score1.ToString();
            p2text.text = score2.ToString();
        }
        if(score1 > max)
        {
            FindObjectOfType<Manager>().P1Win();
        } else if(score2 > max)
        {
            FindObjectOfType<Manager>().P2Win();
        }
    }

    public void Point1()
    {
        score1 += 5;
        if (score1 < 25)
        {
            GameObject.Find("BallCreate").GetComponent<BallCreate>().flag = true;

        }
    }
    public void Point2()
    {
        score2 += 5;
        if (score2 < 25)
        {
            GameObject.Find("BallCreate").GetComponent<BallCreate>().flag = true;
        }
    }
    public void Count1()
    {
        count1 += 1;
        if (count1 < 2)
        {
            GameObject.Find("BallCreate").GetComponent<BallCreate>().flag = true;

        }
    }
    public void Count2()
    {
        count2 += 1;
        if (count2 < 2)
        {
            GameObject.Find("BallCreate").GetComponent<BallCreate>().flag = true;
        }
    }
}
