using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leftlane_test : MonoBehaviour
{
    int sul, speed;
    public GameObject leftlane_test1;
    // Start is called before the first frame update

    void Start()
    {
        sul = 0;
        speed = 1000;
       
        //count = Canvas.childCount;
    }

    // Update is called once per frame
    void Update()
    {
        if (sul == 1)
        {
            //menu.transform.Translate(Vector3.MoveTowards(0,0,0) * Time.deltaTime);
            //menu.transform.localPosition = Vector3.MoveTowards(leftlane_test1.transform.localPosition, new Vector3(0, -1160, 0), speed * Time.deltaTime);
            leftlane_test1.transform.localPosition = Vector3.MoveTowards(leftlane_test1.transform.localPosition, new Vector3(0, -577, 0), speed * Time.deltaTime);
        }
        if (leftlane_test1.transform.localPosition == new Vector3(0, -577, 0))
        {
            sul = 0;
        }
        //else if (sul == 2)
        //{
        //leftlane_test1.transform.localPosition = Vector3.MoveTowards(leftlane_test1.transform.localPosition, new Vector3(0, -1624, 0), speed * Time.deltaTime);
        //Transform.SetSiblingIndex(-1);
        //leftlane_test1.SetSiblingIndex(count-1);
        //}

    }
    public void click()
    {
        //Transform.SetSiblingIndex(0);
        
        //if (sul == 1)
        //{
          //  sul = 2;
        //}
        //else
        //{
            sul = 1;
        //}

    }
}
