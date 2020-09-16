using System;
using UnityEngine;

public class ValuePoint : MonoBehaviour
{
   public int value;

   private void OnTriggerEnter(Collider other)
   {
      value++;
      print (value);
   }
}
