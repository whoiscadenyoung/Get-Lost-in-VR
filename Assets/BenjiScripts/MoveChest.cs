using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveChest : MonoBehaviour
{

    public Transform ChestLid;
    Quaternion leftRotation;
    Quaternion rightRotation;
    Quaternion baseRotation;

    bool opening;

    // Start is called before the first frame update
    void Awake()
    {
        leftRotation = Quaternion.Euler(-140, 0, 0);
        baseRotation = Quaternion.Euler(0, 0, 0);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    bool NotAtBase()
    {
        return ChestLid.rotation != baseRotation;
    }
    bool NotAtFinal()
    {
        return ChestLid.rotation != leftRotation;
    }

    private void OnTriggerEnter(Collider collider)
    {
        Debug.Log(collider.tag);
        if (collider.tag == "Player")
        {
            opening = true;
            StartCoroutine(OpenChest());
        }
    }

    private void OnTriggerExit(Collider collider)
    {
        if (collider.tag == "Player")
        {
            opening = false;
            StartCoroutine(CloseChest());
        }
    }

    IEnumerator OpenChest()
    {
        while (opening && NotAtFinal())
        {
            ChestLid.rotation = Quaternion.RotateTowards(ChestLid.rotation, leftRotation, Time.deltaTime * 500f);
            yield return null;
        }
        opening = false;
    }

    IEnumerator CloseChest()
    {
        while (!opening && NotAtBase())
        {
            ChestLid.rotation = Quaternion.RotateTowards(ChestLid.rotation, baseRotation, Time.deltaTime * 500f);
            yield return null;
        }
    }
}