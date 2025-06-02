using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class first_PlayerControl : MonoBehaviour
{
    private RaycastHit hit;
    public GameObject[] _sphere;
    public GameObject[] _light;

    public Material bright_material;
    public Material dark_material;

    public GameObject text_object;

    private int i = 0;

    private void Update()
    {
        if (Physics.Raycast(transform.position, transform.forward, out hit, Mathf.Infinity))
        {
            if (hit.distance < 4.5)
            {
                switch (hit.collider.name)
                {
                    ///first room
                    case "Light1_ce":
                        i = 0;
                        Light_pochi(_sphere[i], _light[i]);
                        text_object.GetComponent<Text>().text = "Light";
                        break;
                    case "Light2_ce":
                        i = 1;
                        Light_pochi(_sphere[i], _light[i]);
                        text_object.GetComponent<Text>().text = "Light";
                        break;
                    case "Light3_ce":
                        i = 2;
                        Light_pochi(_sphere[i], _light[i]);
                        text_object.GetComponent<Text>().text = "Light";
                        break;



                    ///sencond room 1
                    case "Light_secR1_1":
                        i = 3;
                        Light_pochi(_sphere[i], _light[i]);
                        text_object.GetComponent<Text>().text = "Light";
                        break;
                    case "Light_secR1_2":
                        i = 4;
                        Light_pochi(_sphere[i], _light[i]);
                        text_object.GetComponent<Text>().text = "Light";
                        break;
                    case "Light_secR1_3":
                        i = 5;
                        Light_pochi(_sphere[i], _light[i]);
                        text_object.GetComponent<Text>().text = "Light";
                        break;
                    case "Light_secR1_4":
                        i = 6;
                        Light_pochi(_sphere[i], _light[i]);
                        text_object.GetComponent<Text>().text = "Light";
                        break;



                    ///sencond room 2
                    case "Light_secR2_1":
                        i = 7;
                        Light_pochi(_sphere[i], _light[i]);
                        text_object.GetComponent<Text>().text = "Light";
                        break;
                    case "Light_secR2_2":
                        i = 8;
                        Light_pochi(_sphere[i], _light[i]);
                        text_object.GetComponent<Text>().text = "Light";
                        break;
                    case "Light_secR2_3":
                        i = 9;
                        Light_pochi(_sphere[i], _light[i]);
                        text_object.GetComponent<Text>().text = "Light";
                        break;
                    case "Light_secR2_4":
                        i = 10;
                        Light_pochi(_sphere[i], _light[i]);
                        text_object.GetComponent<Text>().text = "Light";
                        break;



                    ///under room
                    case "Sphere1_under":
                        i = 11;
                        Light_pochi(_sphere[i], _light[i]);
                        text_object.GetComponent<Text>().text = "Light";
                        break;
                    case "Sphere2_under":
                        i = 12;
                        Light_pochi(_sphere[i], _light[i]);
                        text_object.GetComponent<Text>().text = "Light";
                        break;
                    case "Sphere3_under":
                        i = 13;
                        Light_pochi(_sphere[i], _light[i]);
                        text_object.GetComponent<Text>().text = "Light";
                        break;
                    case "Sphere4_under":
                        i = 14;
                        Light_pochi(_sphere[i], _light[i]);
                        text_object.GetComponent<Text>().text = "Light";
                        break;
                    case "Sphere5_under":
                        i = 15;
                        Light_pochi(_sphere[i], _light[i]);
                        text_object.GetComponent<Text>().text = "Light";
                        break;



                    /////////////////////////////
                    ///        Flag          ////
                    /////////////////////////////
                    case "Flag1":
                        i = 16;
                        Light_pochi(_sphere[i], _light[i]);
                        text_object.GetComponent<Text>().text = "Flag";
                        break;
                    case "Flag2":
                        i = 17;
                        Light_pochi(_sphere[i], _light[i]);
                        text_object.GetComponent<Text>().text = "Flag";
                        break;
                    case "Flag3":
                        i = 18;
                        Light_pochi(_sphere[i], _light[i]);
                        text_object.GetComponent<Text>().text = "Flag";
                        break;
                    /////////////////////////////



                    ///inner Light
                    case "Light_in_6_sub":
                        i = 19;
                        Light_pochi(_sphere[i], _light[i]);
                        text_object.GetComponent<Text>().text = "Light";
                        break;


                    case "Light_in_1":
                        i = 20;
                        Light_pochi_in(_sphere[i], _light[i], _light[i + 1]);
                        text_object.GetComponent<Text>().text = "Light";
                        break;
                    case "Light_in_2":
                        i = 21;
                        Light_pochi_in(_sphere[i], _light[i + 1], _light[i + 2]);
                        text_object.GetComponent<Text>().text = "Light";
                        break;
                    case "Light_in_3":
                        i = 22;
                        Light_pochi_in(_sphere[i], _light[i + 2], _light[i + 3]);
                        text_object.GetComponent<Text>().text = "Light";
                        break;
                    case "Light_in_4":
                        i = 23;
                        Light_pochi_in(_sphere[i], _light[i + 3], _light[i + 4]);
                        text_object.GetComponent<Text>().text = "Light";
                        break;
                    case "Light_in_5":
                        i = 24;
                        Light_pochi_in(_sphere[i], _light[i + 4], _light[i + 5]);
                        text_object.GetComponent<Text>().text = "Light";
                        break;
                    case "Light_in_6":
                        i = 25;
                        Light_pochi_in(_sphere[i], _light[i + 5], _light[i + 6]);
                        text_object.GetComponent<Text>().text = "Light";
                        break;
                    case "Light_in_7":
                        i = 26;
                        Light_pochi_in(_sphere[i], _light[i + 6], _light[i + 7]);
                        text_object.GetComponent<Text>().text = "Light";
                        break;
                    case "Light_in_8":
                        i = 27;
                        Light_pochi_in(_sphere[i], _light[i + 7], _light[i + 8]);
                        text_object.GetComponent<Text>().text = "Light";
                        break;
                    case "Light_in_9":
                        i = 28;
                        Light_pochi_in(_sphere[i], _light[i + 8], _light[i + 9]);
                        text_object.GetComponent<Text>().text = "Light";
                        break;
                    case "Light_in_10":
                        i = 29;
                        Light_pochi_in(_sphere[i], _light[i + 9], _light[i + 10]);
                        text_object.GetComponent<Text>().text = "Light";
                        break;
                    case "Light_in_11":
                        i = 30;
                        Light_pochi_in(_sphere[i], _light[i + 10], _light[i + 11]);
                        text_object.GetComponent<Text>().text = "Light";
                        break;
                    case "Light_in_12":
                        i = 31;
                        Light_pochi_in(_sphere[i], _light[i + 11], _light[i + 12]);
                        text_object.GetComponent<Text>().text = "Light";
                        break;


                    ///その他
                    case "pic_down_left":
                    case "pic_down_right":
                    case "pic_exit":
                    case "pic_under":
                    case "pic_up_right":
                        text_object.GetComponent<Text>().text = "Picture";
                        break;
                    case "pic_first":
                        text_object.GetComponent<Text>().text = "Picture = hint";
                        break;
                    case "Light_secR1_door":
                        text_object.GetComponent<Text>().text = "ほたる";
                        break;



                    ///何もない時
                    default:
                        text_object.GetComponent<Text>().text = "";
                        break;
                }
            }
            else
            {
                text_object.GetComponent<Text>().text = "";
            }
        }
    }

    void Light_pochi(GameObject _sphere, GameObject _light)
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (_light.GetComponent<Light>().range == 1)
            {
                _light.GetComponent<Light>().range = 10;
                _sphere.GetComponent<Renderer>().material = bright_material;
            }
            else
            {
                _light.GetComponent<Light>().range = 1;
                _sphere.GetComponent<Renderer>().material = dark_material;
            }
        }
    }

    void Light_pochi_in(GameObject _sphere, GameObject _lightf, GameObject _lightb)
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (_lightf.GetComponent<Light>().range == 1)
            {
                _lightf.GetComponent<Light>().range = 10;
                _lightb.GetComponent<Light>().range = 10;
                _sphere.GetComponent<Renderer>().material = bright_material;
            }
            else
            {
                _lightf.GetComponent<Light>().range = 1;
                _lightb.GetComponent<Light>().range = 1;
                _sphere.GetComponent<Renderer>().material = dark_material;
            }
        }
    }
}