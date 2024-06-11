using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class next : MonoBehaviour

{
    int speed,sul;
    void Start()
    {
        
        speed= 1000;
        sul = 0;

    }

    // Update is called once per frame
    void Update()
    {
        if (sul == 1)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(400, 0, -491), speed * Time.deltaTime);
        }
        if (transform.position == new Vector3(400, 0, -491))
        {
            sul = 0;
        }

       
    }
    public void Click()
    {
        sul= 1;
    }
    
    
}
