using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorSelect : MonoBehaviour
{
    public Dropdown ColorDropdown;
    public Dropdown SpeedDropdown;
    public Text ColorText;
    public static int color = 2;
    public static int speed = 10;

    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {

    }
    public void ChooseColor() // use in the change event for the dropdown
    {
        switch (ColorDropdown.value)
        {
            case 1:
                color = 1;
                
                break;
            case 2:
                color = 1;

                break;
            case 3:
                color = 2;
               
                break;
            default:
                color = 1;
              
                break;
        }
    }
    public void ChooseSpeed()
    {
        switch (SpeedDropdown.value)
        {
            case 1:
                speed = 2;
                break;
            case 2:
                speed = 3;
                break;
            case 3:
                speed = 4;
                break;
            default:
                speed = 3;
                break;
        }

    }
}