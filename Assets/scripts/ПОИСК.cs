using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ПОИСК : MonoBehaviour
{
    public GameObject[] blocks;
    public  GameObject Поисковая_строка;
    public string text;
    public GameObject[] включить;
    public int сколько_заполнено = 0;
     public GameObject[] pivot;

    int i;
    int a;
    int b = 0;


    public void Search()
    {
        b = 0;
        сколько_заполнено = 0;
        if (включить[0] != null)
        {
            for (a = 0; a < включить.Length; a++)
            {
                if (включить[a] != null)
                {
                    включить[a].SetActive(false);
                }

            }
            включить = new GameObject[5];
        }

        text = Поисковая_строка.GetComponent<Text>().text.ToString();
        for (i = 0; i < blocks.Length; i++)
        {
            if (blocks[i].GetComponent<Информацияэ>().Номер_класса == text | blocks[i].GetComponent<Информацияэ>().Номер_кабинета == text | blocks[i].GetComponent<Информацияэ>().Фамилия_учителя == text)
            {

                blocks[i].SetActive(true);

                    blocks[i].transform.position = pivot[сколько_заполнено ].transform.position;
               
                включить[b] = blocks[i];
                b++;
                сколько_заполнено++;

            }


        }
    }
}
