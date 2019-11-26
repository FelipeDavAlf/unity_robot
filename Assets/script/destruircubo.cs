using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destruircubo : MonoBehaviour{
    static int vida_enemiga=10;

    GameObject vida;
    void OnCollisionEnter(UnityEngine.Collision other){
            if(other.gameObject.name=="Fatty_bullet(Clone)"){
                Destroy(this.gameObject, 0);
            }
                
        }
}
