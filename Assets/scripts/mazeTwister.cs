using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// これはmazeにアタッチする
/// </summary>

public class mazeTwister : MonoBehaviour
{

    public GameObject rightUpFlag1;
    public GameObject rightUpFlag2;

    public GameObject rightDownFlag1;
    public GameObject rightDownFlag2;
    /// 壁側
    public GameObject rightDownFlag3;

    public GameObject secondSphere;
    public GameObject secondLightF;
    public GameObject secondLightB;

    public Material bright_material;
    public Material dark_material;

    private bool lightON = false;

    private float x;

    
    void Start()
    {
        x = 0;
    }

    // Update is called once per frame
    void Update()
    {
        ///rihgtUp
        if ((rightUpFlag1.GetComponent<Light>().range == 1) && (rightUpFlag2.GetComponent<Light>().range == 1) && (rightDownFlag2.GetComponent<Light>().range != 1))
        {
            if (x < 90)
            {
                Debug.Log("plus");
                x += 1;
                transform.rotation = Quaternion.Euler(x,0,0);
            }
            else if(!lightON)
            {
                Debug.Log("Ok. light");
                secondLightF.GetComponent<Light>().range = 10;
                secondLightB.GetComponent<Light>().range = 10;
                secondSphere.GetComponent<Renderer>().material = bright_material;
                lightON = !lightON;
            }
        } 
        ///rightDown
        else if ((rightDownFlag1.GetComponent<Light>().range == 1) && (rightDownFlag2.GetComponent<Light>().range == 1) && (rightDownFlag3.GetComponent<Light>().range == 10) && (rightUpFlag2.GetComponent<Light>().range != 1))
        {
            if (x > -90)
            {
                Debug.Log("strange!!!" + this.transform.eulerAngles.x);
                x -= 1;
                transform.rotation = Quaternion.Euler(x, 0, 0);
            }
        }
        else
        {
            if (lightON)
            {
                Debug.Log("ok. lightoff");
                secondLightF.GetComponent<Light>().range = 1;
                secondLightB.GetComponent<Light>().range = 1;
                secondSphere.GetComponent<Renderer>().material = dark_material;
                lightON = !lightON;
            }
            if (x > 0)
            {
                Debug.Log("new Rote minus" + x);
                x -= 1;
                transform.rotation = Quaternion.Euler(x, 0, 0);
            }
            else if(x < 0)
            {
                Debug.Log("new Rote minus" + x);
                x += 1;
                transform.rotation = Quaternion.Euler(x, 0, 0);
            }
        }
    }
}
