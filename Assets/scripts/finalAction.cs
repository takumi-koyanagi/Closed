using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class finalAction : MonoBehaviour
{
    public GameObject text_object;

    public GameObject[] deleteObj;///first room,door

    public GameObject[] flag;

    private int i;
    private int count;
    private bool ch = false;

    void Start()
    {
        i = 0;
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        count = 0;
        for (i = 0; i < 3; i++)
        {
            if (flag[i].GetComponent<Light>().range == 10)
            {
                count++;
            }
        }
        if ((count == 3)&&!ch)
        {
            text_object.GetComponent<Text>().text = "Go to exit !";
            deleteObj[0].SetActive(false); 
            deleteObj[1].SetActive(false);
            deleteObj[2].SetActive(false);
            ch = true;
        }
    }
}