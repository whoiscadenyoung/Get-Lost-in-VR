using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Light))]
public class FadeLight : MonoBehaviour
{
    public TMPro.TextMeshProUGUI percent;
    public float fadeSpeed = 3;
    public float currentBattery = 100;
    private Light currentLight = null;
    public float defaultIntensity = 10;
    public float defaultRange = 15;

    private void Awake()
    {
        currentLight = GetComponent<Light>();
    }


    // Update is called once per frame
    // TODO: Make the light turn completely off when the battery is dead
    void Update()
    {
        if (currentLight.isActiveAndEnabled && currentBattery > 0)
        {
            percent.text = Mathf.Round(currentBattery).ToString() + "%";
            // Update the remaining percent value based on time
            currentBattery -= fadeSpeed * Time.deltaTime;
            // We want to update intensity and range based on the currentBattery life
            currentLight.intensity = Mathf.Min(5, defaultIntensity * currentBattery / 100);
            //currentLight.range = defaultRange * currentBattery / 100;
        }
        if (currentBattery <= 10f)
        {
            percent.color = Color.red;
            currentLight.color = Color.red;
        }
        else percent.color = Color.white;
    }
    public void ResetBattery()
    {
        currentBattery = 100;
    }
}
