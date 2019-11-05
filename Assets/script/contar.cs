using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class contar : MonoBehaviour{
    static int count;
    public TextMesh puntaje;
    void OnTriggerEnter(Collider other){
         if(other.gameObject.tag=="tanque"){
            count++;
            puntaje.text="Monedas:";
            puntaje.text=puntaje.text+count;
            Destroy(this.gameObject, 0);
         }
            
    }
}
