using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class uimanager : MonoBehaviour
{
    public int number_of_btn = 0;
    public string name_of_object;
    public GameObject dest;
    public GameObject btn1;
    public GameObject btn2;
    public GameObject finish_dest;
     public GameObject start_dest;
    GameObject agent;
    public bool isUI;
    public GameObject postroenie;
     public bool istransform;
    public string bool_name;
    public string trigger_name;
    int i;
    bool CAN;
    void Start()
    {
        Application.targetFrameRate = 120;
         agent = GameObject.FindWithTag("agent");
    }

    public void start_pos()
    {
        number_of_btn = 1;
    }
    public void last_pos()
    {
        number_of_btn = 2;
    }
    
     public void sss()
    {
        if (istransform  == false)
        {
            if(number_of_btn == 1)
                    {
                        start_dest = dest;
                    }
                    if (number_of_btn == 2)
                    {                

                        if(isUI == true)
                        {
                            isUI = false;
                        }
                        else
                        {        

                         finish_dest = dest;

                        }
            
                    }
        }
        
    }
     public  void start_transform()
    {
        agent.GetComponent<strelochka_spawn>().clear();
        agent.GetComponent<strelochka_spawn>().start_spawn = true;
        agent.GetComponent<NavMeshAgent>().Warp(start_dest.transform.position);
        agent.GetComponent<NavMeshAgent>().destination = finish_dest.transform.position;
        postroenie.SetActive(true);
        istransform = true;
        CAN = true;


    }
    public void reload_scene(string sceneNane)
    {
        SceneManager.LoadScene(sceneNane);
    }
    public void destanation_from_search(GameObject obj)
    {
        isUI = true;
       
        if (number_of_btn == 1)
        {
            dest = obj;
            btn1.GetComponentInChildren<Text>().text = obj.transform.parent.name;
            start_dest = dest;

        }
        if (number_of_btn == 2)
        {
            btn2.GetComponentInChildren<Text>().text = obj.transform.parent.name;

            finish_dest = obj;
        }
    }
   public  void setSibilling( RectTransform transform )
    {
        transform.SetAsLastSibling();
    }


    public void BoolSet(Animator animator)
    {
       if(i == 0)
        {
            animator.SetBool(bool_name, true);
            i = i + 1;
        }
        else
        {
            animator.SetTrigger(trigger_name);
        }


    }

    private void Update()
    {
        if(CAN == true)
        {
        float dist = Vector3.Distance(agent.transform.position, start_dest.transform.position);
        print(dist);
        }
        
    }
}
