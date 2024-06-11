using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class menu_up : MonoBehaviour
{
    int sul, speed;
    public GameObject menu;   
    private Button sidewalkbtn;
    private Button carbtn;
    public Sprite car;
    public Sprite car_blue;
    public Sprite sidewalk;
    public Sprite sidewalk_blue;
    public static int sul_sidewalk, sul_car;
    // Start is called before the first frame update

    void Start()
    {
        sul = 0;
        sul_sidewalk = 0;
        sul_car = 0;
        speed = 1000;
        sidewalkbtn = GameObject.Find("sidewalk").GetComponent<Button>();
        sidewalkbtn.onClick.AddListener(
            delegate () { onsidewalkclick(); }
            );
        carbtn = GameObject.Find("lane").GetComponent<Button>();
        carbtn.onClick.AddListener(
            delegate () { oncarclick(); }
            );
    }

    // Update is called once per frame
    void Update()
    {
        if (sul == 1)
        {
            //menu.transform.Translate(Vector3.MoveTowards(0,0,0) * Time.deltaTime);
            menu.transform.localPosition = Vector3.MoveTowards(menu.transform.localPosition, new Vector3(0, -1018, 0), speed * Time.deltaTime);
        }
        else if (sul == 2)
        {
            menu.transform.localPosition = Vector3.MoveTowards(menu.transform.localPosition, new Vector3(0, -1160, 0), speed * Time.deltaTime);
        }

    }
    public void click()
    {
        if (sul==1)
        {
            sul = 2;
        } 
        else 
        {
            sul= 1;
        }
    }
    public void onsidewalkclick()
    {   if (sul_sidewalk == 0)
        { sidewalkbtn.GetComponent<Image>().sprite = sidewalk_blue;
            sul_sidewalk = 1;
            
        }
        else if(sul_sidewalk == 1) {
            sidewalkbtn.GetComponent<Image>().sprite = sidewalk;
            sul_sidewalk = 0;
        }
        sul = 2;
        

    }
    public void oncarclick()
    {
        if (sul_car == 0)
        {
            carbtn.GetComponent<Image>().sprite = car_blue;
            sul_car = 1;
        }
        else if (sul_car == 1)
        {
            carbtn.GetComponent<Image>().sprite = car;
            sul_car = 0;
        }
        sul = 2;
        
    }
    
}
