using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickManager : MonoBehaviour
{
    public static ClickManager instance;

    public Text clickText;

    public Player player;
    int click = 0;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        click = player.getClicks();
        clickText.text = "CLICKS: " + click.ToString();
    }

    // Update is called once per frame
    public void addClick(int x)
    {
        click += x;
        clickText.text = "CLICKS: " + click.ToString();
    }

    public void removeClick(int x)
    {
        click -= x;
        clickText.text = "CLICKS: " + click.ToString();
    }
    public int returnClick()
    {
        Debug.Log("Clicks:" + click);
        return click;
    }
}
