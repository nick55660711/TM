using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody))]
public class HorrorObject : MonoBehaviour , ITriggerEvent
{
    private Rigidbody rig;


    public virtual void TriggerEvent()
    {


    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player")) TriggerEvent();

    }


    private void Awake()
    {
        rig = GetComponent<Rigidbody>();
        rig.useGravity = false;
        rig.constraints = RigidbodyConstraints.FreezeAll;
        
    }







}
