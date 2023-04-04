using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickManager : MonoBehaviour
{
    public static ClickManager instance;

    public Text clickText;

    int click = 0;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        clickText.text = "CLICKS: " + click.ToString();
    }

    // Update is called once per frame
    public void addClick()
    {
        click++;
        clickText.text = "CLICKS: " + click.ToString();
    }
}