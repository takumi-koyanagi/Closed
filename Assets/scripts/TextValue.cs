using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextValue : MonoBehaviour
{

    public GameObject text_object;

    public GameObject[] flag;

    private int i;
    private int count;
    private int countOld;

    void Start()
    {
        i = 0;
        count = 0;
        countOld = 0;
    }

    // Update is called once per frame
    void Update()
    {
        countOld = count;
        count = 0;
        for (i = 0; i < 3; i++)
        {
            if (flag[i].GetComponent<Light>().range == 10)
            {
                count++;
            }
        }
        if(countOld != count)
        {
            text_object.GetComponent<Text>().text = count.ToString();
        }
    }
}
