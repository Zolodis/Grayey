using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire : MonoBehaviour
{
    int i=0;

    float counter = 0f;

    public float fireScale = 0.2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        i += 1;
        Debug.Log(Time.fixedDeltaTime);
        counter = (i * Time.fixedDeltaTime * fireScale) % 1;
        voidFire(counter);
        
    }
    void voidFire(float value)
    {
        transform.localScale = new Vector3(value + 0.5f, value + 0.5f, 1);
    }
}
