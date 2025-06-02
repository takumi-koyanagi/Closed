﻿using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[RequireComponent(typeof (Button))]
public class StartButton : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        var button = GetComponent<Button>();
        button.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("SampleScene");
        });
    }
}
