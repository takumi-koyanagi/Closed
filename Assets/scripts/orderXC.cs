using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orderXC : MonoBehaviour
{

    public GameObject[] flags;
    public GameObject[] picture;


    private bool f1 = false;
    private bool f2 = false;

    // Update is called once per frame
    void Update()
    {
        if(flags[0].GetComponent<Light>().range == 10 && !f1)
        {
            picture[0].SetActive(true);
            f1 = true;
        }
        if (flags[1].GetComponent<Light>().range == 10 && !f2)
        {
            picture[1].SetActive(true);
            f2 = true;
        }
    }
}
