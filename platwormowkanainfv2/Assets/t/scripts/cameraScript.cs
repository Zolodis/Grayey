using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraScript : MonoBehaviour
{

    public float cameraSize = 5f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame

    

    void Update()
    {
        Camera.main.orthographicSize = cameraSize;
        if (Input.GetAxis("Mouse ScrollWheel") < 0f) // forward
        {
            if(cameraSize < 20f)
            {
                cameraSize += 1f;
            }
            
        }
        if (Input.GetAxis("Mouse ScrollWheel") > 0f) // backwards
        {
            if (cameraSize > 3f)
            {
                cameraSize -= 1f;
            }
        }

    }
}
