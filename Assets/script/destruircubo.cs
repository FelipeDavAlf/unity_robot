using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destruircubo : MonoBehaviour
{
  
    void OnCollisionEnter(UnityEngine.Collision other){
            if(other.gameObject.name=="Misil(Clone)"){
                Destroy(this.gameObject, 0);
            }
                
        }
}
