using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class board_slowlane : MonoBehaviour
{
    int sul, speed;
    public GameObject image;
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

            image.transform.localPosition = Vector3.MoveTowards(image.transform.localPosition, new Vector3(0, -577, 0), speed * Time.deltaTime);
        }
        if (image.transform.localPosition == new Vector3(0, -577, 0))
        {
            sul = 0;
        }


    }
    public void click()
    {

        sul = 1;

    }
}
