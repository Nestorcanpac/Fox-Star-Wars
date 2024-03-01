using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDamage : MonoBehaviour
{
   private void OnCollisionEnter2D(Collision2D coll)
   {
      if (coll.gameObject.tag=="ship")
      {
         Destroy(coll.gameObject);
      }
      Destroy(gameObject);
   }
}
