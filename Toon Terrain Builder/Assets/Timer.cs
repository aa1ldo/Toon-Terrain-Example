using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class Timer : MonoBehaviour
{
    TextMeshProUGUI clock;
    float clockTime;
    public LightingManager lightingManager;
    public TimeSpan clockTimeSpan;

    private void Start()
    {
        clock = gameObject.GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        clockTime = Mathf.Round(lightingManager.TimeOfDay * 100.0f) * 0.01f;

        clockTimeSpan = TimeSpan.FromHours(clockTime);

        clock.text = string.Format("{0:00}:{1:00}", clockTimeSpan.Hours, ((int)clockTimeSpan.Minutes / 10)*10);
    }

}
