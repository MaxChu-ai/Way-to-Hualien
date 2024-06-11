using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class next_offsetleftturnlane : MonoBehaviour
{
    int sul;
    //int speed;
    // Start is called before the first frame update
    void Start()
    {
        sul = 0;
        //speed = 10000;
    }

    // Update is called once per frame
    void Update()
    {
        if (sul == 1)
        {
            //transform.position = Vector3.MoveTowards(transform.position, new Vector3(400, 0, -491), speed * Time.deltaTime);
            transform.position = new Vector3(400, 0, -491);
        }
        if (transform.position == new Vector3(400, 0, -491))
        {
            sul = 0;
        }

    }
    public void Click()
    {
        sul = 1;
    }
}
