using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingplatforms : MonoBehaviour
{
    public float X0 = 3;

    public float X1 = 20;

    public float movespeed = 400f;

    int direction = 1;

    public bool Rotate = false;

    Vector3 tempPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        tempPos = this.transform.position;
        tempPos.x += 0.1f * Time.deltaTime * movespeed * direction;
        transform.position = tempPos;
        
        if (tempPos.x > X1)
        {
            if (Rotate)
            {
                transform.localScale = new Vector3(1, 1, 1);
            }
            direction = -1;
        }
        if(tempPos.x < X0)
        {
            if (Rotate)
            {
                transform.localScale = new Vector3(-1, 1, 1);
            }
            direction = 1;
        }

        

    }
}
