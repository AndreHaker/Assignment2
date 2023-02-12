using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropDownSpeed : MonoBehaviour
{
    public Dropdown ddspeed;
    public static int speed;
    // Start is called before the first frame update
    void Start()
    {
        ddspeed.onValueChanged.AddListener(delegate
        {
            ddSpeedValueChanged(ddspeed);
        });
    }

    public void ddSpeedValueChanged(Dropdown sender)
    {
        speed = sender.value;
        Debug.Log("You have selected this :" + sender.value);
        Debug.Log(speed);
    }
}
