using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DropDownSize : MonoBehaviour
{
    public Dropdown ddSize;
    public static int size;
    // Start is called before the first frame update
    void Start()
    {
        ddSize.onValueChanged.AddListener(delegate
        {
            ddSizeValueChanged(ddSize);
        });
    }

    public void ddSizeValueChanged(Dropdown sender)
    {
        size = sender.value;
        Debug.Log("You have selected this :" + sender.value);
        Debug.Log(size);
    }
}
