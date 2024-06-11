using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public Transform target;
    public float xSpeed = 200, ySpeed = 200, mSpeed = 10;
    public float yMinLimit = 5, yMaxLimit = 50;
    public float distance = 50, minDistance = 2, maxDistance = 100;
    public bool needDamping = true;
    float damping = 5f;
    public float x = 0f;
    public float y = 0f;


    private Vector3 m_mouseMovePos;
    private Camera camera;


    private void Start()
    {
        Camera camera = GameObject.Find("Main Camera").GetComponent<Camera>();
    }
    // Update is called once per frame
    void LateUpdate()
    {


        if (target)
        {
            //鼠標點擊右鍵，圍繞target旋轉移動相機，改變視野
            if (Input.GetMouseButton(1))
            {
                x += Input.GetAxis("Mouse X") * xSpeed * 0.02f;
                y -= Input.GetAxis("Mouse Y") * ySpeed * 0.02f;


                y = ClampAngle(y, yMinLimit, yMaxLimit);
            }
            distance -= Input.GetAxis("Mouse ScrollWheel") * mSpeed;
            distance = Mathf.Clamp(distance, minDistance, maxDistance);


            Quaternion rotation = Quaternion.Euler(y, x, 0.0f);  //
            Vector3 disVector = new Vector3(0f, 0f, -distance);
            Vector3 position = rotation * disVector + target.position;
            if (needDamping)
            {
                transform.rotation = Quaternion.Lerp(transform.rotation, rotation, Time.deltaTime * damping);
                transform.position = Vector3.Lerp(transform.position, position, Time.deltaTime * damping);
            }
            else
            {
                transform.rotation = rotation;
                transform.position = position;
            }
            //鼠標點擊中鍵場景移動;
            if (Input.GetMouseButtonDown(2))
            {
                //從攝像機發出到點擊座標的射線
                //由於使用了射線檢測，所以鼠標一定要點擊到帶碰撞體的物體上，點擊位置爲空時，無效果。
                Ray ray = camera.ScreenPointToRay(Input.mousePosition);
                RaycastHit hitInfo;
                if (Physics.Raycast(ray, out hitInfo))
                {
                    m_mouseMovePos = hitInfo.point;
                }
            }
            else if (Input.GetMouseButton(2))
            {
                Vector3 p = Vector3.zero;
                Ray ray = camera.ScreenPointToRay(Input.mousePosition);//從攝像機發出到點擊座標的射線
                RaycastHit hitInfo;
                if (Physics.Raycast(ray, out hitInfo))
                {
                    p = hitInfo.point - m_mouseMovePos;
                    p.y = 0f;
                }
                //在原有的位置上，加上偏移的位置量;
                target.localPosition = target.position - p * 0.03f;


            }
        }
    }
    static float ClampAngle(float angle, float min, float max)
    {
        if (angle < -360)
            angle += 360;
        if (angle > 360)
            angle -= 360;
        return Mathf.Clamp(angle, min, max);
    }
}
