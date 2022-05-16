using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillBattery : MonoBehaviour
{
    public FadeLight logic;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Flashlight")
        {
            Destroy(this.gameObject);
            Debug.Log("Other fadelight = " + logic.currentBattery);
            //logic = other.gameObject.GetComponent<FadeLight>() as FadeLight;
            logic.currentBattery = 100;
        }
        

    }
}
