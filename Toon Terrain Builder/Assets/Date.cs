using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Date : MonoBehaviour
{
    TextMeshProUGUI text;
    public Timer timer;
    string day;
    bool newDay = false;

    void Start()
    {
        text = gameObject.GetComponent<TextMeshProUGUI>();
        day = "???";
    }

    void Update()
    {
        text.text = "Day " + day;
    }
}
