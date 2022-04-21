using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSkybox : MonoBehaviour
{

    public Material dayBox;
    public Material nightBox;

    public void ChangeToNight()
    {
        if (nightBox) RenderSettings.skybox = nightBox;
    }
    public void ChangeToDay()
    {
        if (dayBox) RenderSettings.skybox = dayBox;
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Player") ChangeToNight();
    }

    private void OnTriggerExit(Collider collider)
    {
        if (collider.tag == "Player") ChangeToDay();
    }
}
