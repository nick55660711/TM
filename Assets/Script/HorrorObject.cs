using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorrorObject : MonoBehaviour , ITriggerEvent
{


    public virtual void TriggerEvent()
    {

        print("去死吧 by Reim");

    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player")) TriggerEvent();

    }










}
