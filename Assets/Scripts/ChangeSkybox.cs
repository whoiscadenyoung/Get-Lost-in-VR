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

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "XR Rig") ChangeToNight();
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "XR Rig") ChangeToDay();
    }
}
