using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class marshrut_postroit : MonoBehaviour
{
    NavMeshAgent agent;
    GameObject trransform;
    // Start is called before the first frame update
    void Start()
    {
        agent = GameObject.FindWithTag("agent").GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame

    public void do_transform()
    {
        
        agent.GetComponent<strelochka_spawn>().start_spawn = true;
        

        
    }
}
