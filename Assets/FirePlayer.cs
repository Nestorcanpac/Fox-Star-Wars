using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePlayer : MonoBehaviour
{
   public GameObject bullet;

   private void Start()
   {
      
   }

   private void Update()
   {
      if (Input.GetKeyDown(KeyCode.Space))
      {
         GameObject g = (GameObject)Instantiate(bullet,
            transform.position,
            Quaternion.identity
         );
         Physics2D.IgnoreCollision(g.GetComponent<Collider2D>(),
            transform.parent.GetComponent<Collider2D>());
      }
   }
}
