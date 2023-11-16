using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayExample : MonoBehaviour
{
   public GameObject cube1, cube2, cube3;


   private void Update()
   {
      if (Input.GetMouseButtonDown(0))
      {
         cube1.SetActive(false);
         cube2.SetActive(false);
         cube3.SetActive(false);
      }
   }
}
