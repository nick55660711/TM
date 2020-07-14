using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorrorMove : HorrorObject
{

    public Transform move;
    public Transform target;
    public float speed;



    public override void TriggerEvent()
    {
        StartCoroutine(Move());
    }

    private IEnumerator Move()
    {
        float dis = Vector3.Distance(move.position, target.position);

        while (dis >= 0.2f)
        {
            move.position = Vector3.Lerp(move.position, target.position, Time.deltaTime * 0.5f * speed);
            yield return null;
        }


    }



}
