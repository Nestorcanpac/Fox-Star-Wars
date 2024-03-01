using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Border : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D call)
    {
        if (call.gameObject.name != "PlayerSheep")
        {
            Destroy(call.gameObject);
        }
    }
}
