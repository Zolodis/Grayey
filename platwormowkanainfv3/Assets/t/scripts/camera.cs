using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{

    public Camera CameraObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Mouse ScrollWheel") > 0f) // forward
        {
            CameraObject.orthographicSize = 3;
        }
        if (Input.GetAxis("Mouse ScrollWheel") < 0f) // backwards
        {

        }
    }
}
