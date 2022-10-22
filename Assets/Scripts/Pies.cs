using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pies : MonoBehaviour
{

    public Moving moving;
  


    private void OnTriggerStay(Collider other)
    {
        moving.salto = true;
    }

    private void OnTriggerExit(Collider other)
    {
        moving.salto = false;
    }
}
