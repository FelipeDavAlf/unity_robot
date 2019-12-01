using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class destruircubo : MonoBehaviour{
    public int vida_enemiga=5;

    public GameObject vida;

    void Start(){//muestra la vida del enemigo
        vida.gameObject.GetComponent<TextMesh>().text=string.Concat(Enumerable.Repeat("*", vida_enemiga));
    }

     public int get_vida(){
        return vida_enemiga;
    }
    void OnCollisionEnter(UnityEngine.Collision other){
            if(other.gameObject.name=="bala"){
                vida_enemiga--;
                vida.gameObject.GetComponent<TextMesh>().text=string.Concat(Enumerable.Repeat("*", vida_enemiga));
                if(vida_enemiga<=0)
                    Destroy(this.gameObject, 0);
            }
                
        }
}
