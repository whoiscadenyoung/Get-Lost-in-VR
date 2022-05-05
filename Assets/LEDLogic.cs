using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
public class LEDLogic : MonoBehaviour
{
    public bool lightToggle;
    public Light lightComp;

    // Start is called before the first frame update
    void Start()
    {
        lightComp = this.gameObject.AddComponent<Light>();
        lightComp.color = Color.blue;
        lightComp.intensity = 0L;
        lightToggle = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (lightToggle && other.gameObject.tag == "Player")
        {
            lightToggle.intensity = 5L;
            lightToggle = !lightToggle;
        } 
        if (!lightToggle && other.gameObject.tag == "Player")
        {
            lightToggle.intensity = 0L;
            lightToggle = !lightToggle;
        }
    }
}

*/