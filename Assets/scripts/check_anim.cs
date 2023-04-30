using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class check_anim : MonoBehaviour
{
    float timer;
    public GameObject Start_scene;
    public string scene;
    // Start is called before the first frame update
    void Start()
    {
        timer = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            SceneManager.LoadScene(scene);
        }
    }
}
