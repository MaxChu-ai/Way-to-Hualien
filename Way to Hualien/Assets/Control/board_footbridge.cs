using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class board_footbridge : MonoBehaviour
{
    int sul, speed;
    public GameObject bridge;
    // Start is called before the first frame update

    void Start()
    {
        sul = 0;
        speed = 1000;

    }

    // Update is called once per frame
    void Update()
    {
        if (sul == 1)
        {

            bridge.transform.localPosition = Vector3.MoveTowards(bridge.transform.localPosition, new Vector3(0, -577, 0), speed * Time.deltaTime);
        }
        if (bridge.transform.localPosition == new Vector3(0, -577, 0))
        {
            sul = 0;
        }


    }
    public void click()
    {

        sul = 1;

    }
}
