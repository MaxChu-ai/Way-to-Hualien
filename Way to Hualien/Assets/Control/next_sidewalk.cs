using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class next_sidewalk : MonoBehaviour
{
    int sul, speed;
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
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(1200, 0, -491), speed * Time.deltaTime);
        }
        if (transform.position == new Vector3(1200, 0, -491))
        {
            sul = 0;
        }

    }
    public void Click()
    {
        sul = 1;
    }
}
