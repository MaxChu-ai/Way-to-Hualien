using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Text;

public class down : MonoBehaviour
{
    int sul, speed;
    int b1, b2, b3, b4, b5,b6,b7,b8,b9,bb;
    public GameObject leftlane_test1;
    public GameObject bridge;
    public GameObject obstacle;
    public GameObject waitzone;
    public GameObject slowlane;
    public GameObject trafficlight;
    public GameObject changelane;
    public GameObject signoverload;
    public GameObject flashinglight;
    //after
    public GameObject roadwide;
    public GameObject sidewalklight;
    public GameObject incline;
    public GameObject tactilefloortile;
    public GameObject diagonal;
    public GameObject waitzoneline;
    public GameObject offsetlane;
    public GameObject sidewalkout;
    public GameObject sidewalkin;

   


    // Start is called before the first frame update
    void Start()
    {
        sul = 0;
        speed = 1000;
        bb = 0;
    }

    // Update is called once per frame
    void Update()
    {
        b1 = Convert.ToInt32((leftlane_test1.transform.localPosition == bridge.transform.localPosition) ? 1 : 0);
        b2 = Convert.ToInt32((obstacle.transform.localPosition == waitzone.transform.localPosition) ? 1 : 0);
        b3 = Convert.ToInt32((slowlane.transform.localPosition == trafficlight.transform.localPosition) ? 1 : 0);
        b4 = Convert.ToInt32((changelane.transform.localPosition == signoverload.transform.localPosition) ? 1 : 0);
        b5 = Convert.ToInt32((flashinglight.transform.localPosition == roadwide.transform.localPosition) ? 1 : 0);
        b6 = Convert.ToInt32((sidewalklight.transform.localPosition == incline.transform.localPosition) ? 1 : 0);
        b7 = Convert.ToInt32((tactilefloortile.transform.localPosition == diagonal.transform.localPosition) ? 1 : 0);
        b8 = Convert.ToInt32((waitzoneline.transform.localPosition == offsetlane.transform.localPosition) ? 1 : 0);
        b9 = Convert.ToInt32((sidewalkout.transform.localPosition == sidewalkin.transform.localPosition) ? 1 : 0);
        bb = b1 + 2 * b2 + 4 * b3 + 8 * b4 + 16 * b5+ 32 * b6 + 64 *b7 +128 *b8 + 256 * b9;


        if (sul == 1)
        {
            leftlane_test1.transform.localPosition = Vector3.MoveTowards(leftlane_test1.transform.localPosition, new Vector3(0, -1624, 0), speed * Time.deltaTime);
            bridge.transform.localPosition = Vector3.MoveTowards(bridge.transform.localPosition, new Vector3(0, -1624, 0), speed * Time.deltaTime);
            obstacle.transform.localPosition = Vector3.MoveTowards(obstacle.transform.localPosition, new Vector3(0, -1624, 0), speed * Time.deltaTime);
            waitzone.transform.localPosition = Vector3.MoveTowards(waitzone.transform.localPosition, new Vector3(0, -1624, 0), speed * Time.deltaTime);
            slowlane.transform.localPosition = Vector3.MoveTowards(slowlane.transform.localPosition, new Vector3(0, -1624, 0), speed * Time.deltaTime);
            trafficlight.transform.localPosition = Vector3.MoveTowards(trafficlight.transform.localPosition, new Vector3(0, -1624, 0), speed * Time.deltaTime);
            changelane.transform.localPosition = Vector3.MoveTowards(changelane.transform.localPosition, new Vector3(0, -1624, 0), speed * Time.deltaTime);
            signoverload.transform.localPosition = Vector3.MoveTowards(signoverload.transform.localPosition, new Vector3(0, -1624, 0), speed * Time.deltaTime);
            flashinglight.transform.localPosition = Vector3.MoveTowards(flashinglight.transform.localPosition, new Vector3(0, -1624, 0), speed * Time.deltaTime);
            roadwide.transform.localPosition = Vector3.MoveTowards(roadwide.transform.localPosition, new Vector3(0, -1624, 0), speed * Time.deltaTime);
            sidewalklight.transform.localPosition = Vector3.MoveTowards(sidewalklight.transform.localPosition, new Vector3(0, -1624, 0), speed * Time.deltaTime);
            incline.transform.localPosition = Vector3.MoveTowards(incline.transform.localPosition, new Vector3(0, -1624, 0), speed * Time.deltaTime);
            tactilefloortile.transform.localPosition = Vector3.MoveTowards(tactilefloortile.transform.localPosition, new Vector3(0, -1624, 0), speed * Time.deltaTime);
            diagonal.transform.localPosition = Vector3.MoveTowards(diagonal.transform.localPosition, new Vector3(0, -1624, 0), speed * Time.deltaTime);
            waitzoneline.transform.localPosition = Vector3.MoveTowards(waitzoneline.transform.localPosition, new Vector3(0, -1624, 0), speed * Time.deltaTime);
            offsetlane.transform.localPosition = Vector3.MoveTowards(offsetlane.transform.localPosition, new Vector3(0, -1624, 0), speed * Time.deltaTime);
            sidewalkin.transform.localPosition = Vector3.MoveTowards(sidewalkin.transform.localPosition, new Vector3(0, -1624, 0), speed * Time.deltaTime);
            sidewalkout.transform.localPosition = Vector3.MoveTowards(sidewalkout.transform.localPosition, new Vector3(0, -1624, 0), speed * Time.deltaTime);
        }
        if (bb==511)
        {
            sul = 0;
        }
        


    }
    public void click()
    {
        //Transform.SetSiblingIndex(0);
        
        sul = 1; 
        
        
    }
}
