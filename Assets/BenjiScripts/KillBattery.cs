using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillBattery : MonoBehaviour
{
    public GameObject light;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "lightsource_Flashlight")
        {
            Destroy(this.gameObject);
            light = other.gameObject;
            FadeLight logic = light.GetComponent("Fade Light") as FadeLight;
            logic.currentBattery = 100;
        }
        

    }
}
