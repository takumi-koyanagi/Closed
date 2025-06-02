using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floorDrop : MonoBehaviour
{

    public GameObject[] Lights;
    public GameObject[] stairs;///初期値状態false
    public GameObject Flag3_light_state;
    public GameObject DropFloor;

    private bool Active = true;
    private bool flag = false;
    private bool end = false;

    void Update()
    {
        if(!end && !flag&&(Flag3_light_state.GetComponent<Light>().range == 10))
        {
            stairs[0].SetActive(true);
            stairs[1].SetActive(true);
            stairs[2].SetActive(true);
            stairs[3].SetActive(true);
            stairs[4].SetActive(true);
            DropFloor.SetActive(false);
            Active = false;
            flag = true;
        }
    }

    public void outfloorSub(Collider collider)
    {
        ///番号は企画書にもとずく
        if ((Lights[0].GetComponent<Light>().range != 1) && 
            (Lights[1].GetComponent<Light>().range != 1) && 
            (Lights[2].GetComponent<Light>().range != 1) &&
            (Lights[3].GetComponent<Light>().range == 1) &&
            (Lights[4].GetComponent<Light>().range == 1) &&
            (Lights[5].GetComponent<Light>().range != 1) &&
            (Lights[6].GetComponent<Light>().range == 1) &&
            (Lights[7].GetComponent<Light>().range == 1) &&
            (Lights[8].GetComponent<Light>().range == 1) &&
            (Lights[9].GetComponent<Light>().range == 1) &&
            (Lights[10].GetComponent<Light>().range != 1) &&
            (Lights[11].GetComponent<Light>().range == 1) &&
            (Lights[12].GetComponent<Light>().range != 1) && Active && (collider.CompareTag("Player")) &&
            (Flag3_light_state.GetComponent<Light>().range == 1) && !end)
        {
            DropFloor.SetActive(false);
            Active = false;
        }
        else if(!end && flag && (Flag3_light_state.GetComponent<Light>().range == 10))
        {
            DropFloor.SetActive(true);
            Active = true;
            end = true;
        }
    }

    public void onfloor(Collider collider)
    {
        if(!Active && (collider.CompareTag("Player")) && !flag && !end)
        {
            DropFloor.SetActive(true);
            Active = true;
        }
    }
}