using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    //bool goingup = true;
    void Update()
    {
        // Gets the local scale of a game object
        //vector3 objectScale = transform.localScale;
        // spins it proportionally such that one rotation is 4 seconds
        transform.Rotate(0, Time.deltaTime * 20, 0); // 360 degrees / 4 seconds / ~30 frames = 4
        // bounces up and down
        
    }
}
