using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropDownColor : MonoBehaviour
{
    public Dropdown ddColor;
    public static int color;
    // Start is called before the first frame update
    void Start()
    {
        ddColor.onValueChanged.AddListener(delegate
        {
            ddColorValueChanged(ddColor);
        });
    }

    public void ddColorValueChanged(Dropdown sender)
    {
        color = sender.value;
        Debug.Log("You have selected this :" + sender.value);
        Debug.Log(color);
    }
}
