using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firstAction : MonoBehaviour
{
    /// <summary>
    /// pointLightのやつ
    /// </summary>
    public GameObject _light;
    /// <summary>
    /// 消す壁
    /// </summary>
    public GameObject _wall;

    private bool f = true;

    // Update is called once per frame
    void Update()
    {
        if (f&&(_light.GetComponent<Light>().range == 1))
        {
            Debug.Log("sucess");
            f = false;
            _wall.SetActive(false);

        }
    }
}
