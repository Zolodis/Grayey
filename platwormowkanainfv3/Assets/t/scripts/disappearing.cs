using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disappearing : MonoBehaviour
{
    public float t1 = 4f;
    public float t2 = 2f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time%(t1+t2) > t1)
        {
            transform.localScale = new Vector3(2, 3, 1);
        }
        else
        {
            transform.localScale = new Vector3(0, 0, 1);
        }
    }
}
