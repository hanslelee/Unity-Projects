using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloCode : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        bool isDead = false;
        int hp = 100;
        while (!isDead)
        {
            Debug.Log("현재 체력: " + hp);
            hp -= 33;
            if (hp <= 0)
            {
                isDead = true;
                Debug.Log("플레이어는 죽었습니다");
            }
        }

    }

    float GetDistance(float x1,float y1, float x2, float y2)
    {
        return Mathf.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
