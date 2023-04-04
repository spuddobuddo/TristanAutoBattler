using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClick : MonoBehaviour
{
    public int click;

    public void OnButtonPress(){
        click++;
        Debug.Log("Button clicked " + click + " times.");
    }

    public int returnClick()
    {
        return click;
    }
}
