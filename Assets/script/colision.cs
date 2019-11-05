using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colision : MonoBehaviour
{
    // Start is called before the first frame update
    void OnCollisionEnter(Collision col){
        if(col.gameObject.tag=="cubo")
            Debug.Log(col.gameObject.name);
    }
   /*  void OnTriggerEnter(Collider other){
         if(other.gameObject.tag=="cubo")
            Debug.Log(other.gameObject.name);
    }*/
}
