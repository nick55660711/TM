using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorrorRotate : HorrorObject
{
    public Transform rota;

    public float angle = 120;
    public float speed = 10;

    public override void TriggerEvent()
    {
        StartCoroutine(Rotate());
    }

    private IEnumerator Rotate()
    {
        GetComponentInChildren<BoxCollider>().enabled = false;
        float y = rota.localEulerAngles.y;
        float targetY = y + angle;
        while(y< targetY)
        {
            rota.localEulerAngles += Vector3.up * Time.deltaTime* speed;
            y -= Time.deltaTime * speed;
            yield return null;
        }
    }


}
