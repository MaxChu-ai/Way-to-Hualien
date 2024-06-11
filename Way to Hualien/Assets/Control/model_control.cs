using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class model_control : MonoBehaviour
{   
    int s,c;
    public GameObject bb1;
    public GameObject ba;
    public GameObject ab;
    public GameObject aa;
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
        s= 0;
        c = 0;
    }

    // Update is called once per frame
    void Update()
    {
        s = menu_up.sul_sidewalk;
        c = menu_up.sul_car;

        if (s == 0 && c == 0)
        {
            ba.SetActive(false);
            ab.SetActive(false);
            aa.SetActive(false);
            
            //pin
            roadwide.SetActive(false);
            sidewalklight.SetActive(false);
            incline.SetActive(false);
            tactilefloortile.SetActive(false);
            diagonal.SetActive(false);
            waitzoneline.SetActive(false);
            offsetlane.SetActive(false);
            sidewalkout.SetActive(false);
            sidewalkin.SetActive(false);
            bb1.SetActive(true);
            leftlane_test1.SetActive(true);
            bridge.SetActive(true);
            obstacle.SetActive(true);
            waitzone.SetActive(true);
            slowlane.SetActive(true);
            trafficlight.SetActive(true);
            changelane.SetActive(true);
            signoverload.SetActive(true);
            flashinglight.SetActive(true);
        }
        else if (s == 0 && c == 1)
        {

            ab.SetActive(false);
            aa.SetActive(false);
            bb1.SetActive(false);
            sidewalklight.SetActive(false);
            tactilefloortile.SetActive(false);
            diagonal.SetActive(false);
            sidewalkout.SetActive(false);
            sidewalkin.SetActive(false);
            leftlane_test1.SetActive(false);
            bridge.SetActive(false);
            waitzone.SetActive(false);
            slowlane.SetActive(false);
            trafficlight.SetActive(false);
            changelane.SetActive(false);
            signoverload.SetActive(false);
            flashinglight.SetActive(false);

            ba.SetActive(true);
            obstacle.SetActive(true);
            incline.SetActive(true);
            roadwide.SetActive(true);
            offsetlane.SetActive(true);
            waitzoneline.SetActive(true);
        }
        else if (s == 1 && c == 0)
        {
            ba.SetActive(false);
            aa.SetActive(false);
            bb1.SetActive(false);
            
            //pin
            roadwide.SetActive(false);
            incline.SetActive(false);
            waitzoneline.SetActive(false);
            offsetlane.SetActive(false);
            bridge.SetActive(false);
            obstacle.SetActive(false);
            slowlane.SetActive(false);
            trafficlight.SetActive(false);
            diagonal.SetActive(false);

            ab.SetActive(true);
            leftlane_test1.SetActive(true);
            waitzone.SetActive(true);
            changelane.SetActive(true);
            flashinglight.SetActive(true);
            signoverload.SetActive(true);
            sidewalkout.SetActive(true);
            sidewalkin.SetActive(true);
            sidewalklight.SetActive(true);
            tactilefloortile.SetActive(true);
        }
        else if (s == 1 && c == 1)
        {
            ba.SetActive(false);
            ab.SetActive(false);
            bb1.SetActive(false);
            
            leftlane_test1.SetActive(false);
            bridge.SetActive(false);
            obstacle.SetActive(false);
            waitzone.SetActive(false);
            slowlane.SetActive(false);
            trafficlight.SetActive(false);
            changelane.SetActive(false);
            signoverload.SetActive(false);
            flashinglight.SetActive(false);
            aa.SetActive(true);
            sidewalkout.SetActive(true);
            sidewalkin.SetActive(true);
            sidewalklight.SetActive(true);
            diagonal.SetActive(true);
            tactilefloortile.SetActive(true);
            incline.SetActive(true);
            roadwide.SetActive(true);
            offsetlane.SetActive(true);
            waitzoneline.SetActive(true);

        }
    }
}
