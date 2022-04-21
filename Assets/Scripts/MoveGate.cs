using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveGate : MonoBehaviour
{
    public Transform leftGate;
    public Transform rightGate;

    Quaternion leftRotation;
    Quaternion rightRotation;
    Quaternion baseRotation;

    bool opening;
    
    // Start is called before the first frame update
    void Awake()
    {
        leftRotation = Quaternion.Euler(0, -90, 0);
        rightRotation = Quaternion.Euler(0, 90, 0);
        baseRotation = Quaternion.Euler(0, 0, 0);
    }

    bool NotAtBase()
    {
        return leftGate.rotation != baseRotation || rightGate.rotation != baseRotation;
    }
    bool NotAtFinal()
    {
        return leftGate.rotation != leftRotation || rightGate.rotation != rightRotation;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.name == "XR Rig")
        {
            opening = true;
            StartCoroutine(OpenGate());
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "XR Rig")
        {
            opening = false;
            StartCoroutine(CloseGate());
        }
    }

    IEnumerator OpenGate()
    {
        while (opening && NotAtFinal())
        {
            leftGate.rotation = Quaternion.RotateTowards(leftGate.rotation, leftRotation, Time.deltaTime * 100f);
            rightGate.rotation = Quaternion.RotateTowards(rightGate.rotation, rightRotation, Time.deltaTime * 100f);
            yield return null;
        }
        opening = false;
    }

    IEnumerator CloseGate()
    {
        while (!opening && NotAtBase())
        {
            leftGate.rotation = Quaternion.RotateTowards(leftGate.rotation, baseRotation, Time.deltaTime * 100f);
            rightGate.rotation = Quaternion.RotateTowards(rightGate.rotation, baseRotation, Time.deltaTime * 100f);
            yield return null;
        }
    }
}
