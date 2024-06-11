using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class WS_CameraMove : MonoBehaviour
{

    public float rotation_H_speed = 1;
    public float rotation_V_speed = 1;
    void Start(){

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(2))
        {
            this.transform.Translate(new Vector3(-Input.GetAxis("Mouse X") * rotation_H_speed, -Input.GetAxis("Mouse Y") * rotation_V_speed, 0f));
        }

        if (Input.GetAxis("Mouse ScrollWheel") != 0)
        {
            if (Camera.main.fieldOfView <=70&&Camera.main.fieldOfView>=10)
            {
                Camera.main.fieldOfView -= Input.GetAxis("Mouse ScrollWheel") * Time.deltaTime * 5000;
                if (Camera.main.fieldOfView > 69)
                {
                    Camera.main.fieldOfView = 69;
                }
                if (Camera.main.fieldOfView < 11)
                {
                    Camera.main.fieldOfView = 11;
                }
            }
        }
    }
}
