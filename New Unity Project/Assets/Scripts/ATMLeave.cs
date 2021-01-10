using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ATMLeave : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject atm;
    public float waited;
    bool atTarget;
    public GameObject locationFinal;
    void Start()
    {
        atTarget = false;
        waited = 10.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (waited < 0)
        {
            transform.position = Vector3.MoveTowards(transform.position, locationFinal.transform.position, 5f * Time.deltaTime) ;
        }
        else {
            if (atTarget)
            {
                waited = waited - Time.deltaTime;
            }
            else if (!Physics.Raycast(transform.position, atm.transform.position-transform.position, Vector3.Distance(transform.position, atm.transform.position)))
            {
                Debug.DrawRay(transform.position, atm.transform.position * Vector3.Distance(transform.position, atm.transform.position), Color.yellow);
                Debug.Log(Vector3.Distance(transform.position, atm.transform.position));
                // if (Vector3.Distance(transform.position, atm.transform.position) <= 0.3)
                //     atTarget = true;
                // else
                // {
                //     transform.position = Vector3.MoveTowards(transform.position, atm.transform.position, 5f * Time.deltaTime);
                // }
            }

        }
    }
}
