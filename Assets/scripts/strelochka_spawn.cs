using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class strelochka_spawn : MonoBehaviour
{
    float time;
    public GameObject Strelka;
    public  bool start_spawn;
    public float dist;
    public float timertry;
    int len;
     public GameObject[] strelki;
    public GameObject transform_pos;
    void Start()
    {
        time = timertry;
    }

    void Update()
    {
        if(start_spawn == true)
        {
          time -= Time.deltaTime;
            if(time <= 0)
            {
                
                time = timertry;
                GameObject strelka = Instantiate(Strelka, transform_pos.transform.position, transform_pos.transform.rotation);
                strelki[len] = strelka;
                len += 1;
                
            }
            dist = Vector3.Distance(gameObject.GetComponent<NavMeshAgent>().destination, gameObject.transform.position);
            if(dist <= 0.9f)
            {
                GameObject logic = GameObject.Find("logic");
                logic.GetComponent<uimanager>().postroenie.SetActive(false);
                start_spawn = false;
                logic.GetComponent<uimanager>().istransform = false;
            }
        }
       
    }
    public void clear()
    {
        for (int i = 0; i < len; i++)
        {
            Destroy(strelki[i]);

        }
    }
}
