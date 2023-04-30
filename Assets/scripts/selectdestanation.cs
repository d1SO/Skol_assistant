using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class selectdestanation : MonoBehaviour
{
    public GameObject myDestanation;
    bool timer_start;
    int count;
    float time = 0.7f;   
   // Start is called before the first frame update
    void OnMouseDown()
    {   
        GameObject logic = GameObject.Find("logic");
        if(count != 2)
        {           
            timer_start = true;
            if (time > 0)
            {
                count = count + 1;
                if (count == 2)
                {
                    count = 0;
                    if (logic.GetComponent<uimanager>().istransform == false)
                    {
                        logic.GetComponent<uimanager>().dest = myDestanation;
                        logic.GetComponent<uimanager>().name_of_object = gameObject.name;
                        logic.GetComponent<uimanager>().sss();
                        if (logic.GetComponent<uimanager>().number_of_btn == 2)
                        {
                            logic.GetComponent<uimanager>().btn2.GetComponentInChildren<Text>().text = gameObject.transform.name;
                        }
                        if (logic.GetComponent<uimanager>().number_of_btn == 1)
                        {
                            logic.GetComponent<uimanager>().btn1.GetComponentInChildren<Text>().text = gameObject.transform.name;
                        }
                    }
                }
            }
        }       
    } 
   // Update is called once per frame
    void Update()
    {
        if(timer_start == true)
        {
            time -= Time.deltaTime;
            if(time <= 0)
            {
                count = 0;
                timer_start = false;
                time = 0.7f;
            }
        }
    }
}
