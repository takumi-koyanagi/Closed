using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class exit_end : MonoBehaviour
{

    ///this is script
    public GameObject invalid_script_obj;

    public GameObject[] flags;

    private bool f = true;

    public GameObject _wall;

    // Update is called once per frame
    public void OnDetectObject(Collider collider)
    {
        if (f&&(collider.CompareTag("Player")))
        {
            Debug.Log("sucess_exit");
            f = false;
            invalid_script_obj.GetComponent<firstAction>().enabled = false;
            _wall.SetActive(true);
        }
        else if((collider.CompareTag("Player"))&&(flags[0].GetComponent<Light>().range == 10) && (flags[1].GetComponent<Light>().range == 10) && (flags[2].GetComponent<Light>().range == 10))
        {
            Debug.Log("clear!");
            Invoke("finalSe", 1.5f);
        }
    }

    private void finalSe()
    {
        SceneManager.LoadScene("GameOver");
    }
}
