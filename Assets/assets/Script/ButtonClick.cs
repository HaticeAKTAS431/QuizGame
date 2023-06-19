using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonClick : MonoBehaviour
{
    public Text countText;
    private int count = 0;

    void Start()
    {
        countText.text = count.ToString();
    }

    public void IncrementCount()
    {
        count++;
        countText.text = count.ToString();
    }
}
