using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Light))]
public class FadeLight : MonoBehaviour
{
    public TMPro.TextMeshProUGUI percent;
    private Light currentLight = null;
    private int percentValue;

    private void Awake()
    {
        currentLight = GetComponent<Light>();
    }


    // Update is called once per frame
    void Update()
    {
        if (currentLight.isActiveAndEnabled)
        {
            percentValue = int.Parse(percent.text.Substring(0, percent.text.Length - 2));
        }
    }
}
