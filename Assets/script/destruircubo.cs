using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class destruircubo : MonoBehaviour{
    public int vida_enemiga=5;
    public static int puntaje;
    public GameObject vida;

    public int danio;

    void Start(){//muestra la vida del enemigo
        vida.gameObject.GetComponent<TextMesh>().text=string.Concat(Enumerable.Repeat("*", vida_enemiga));
    }

     public int get_vida(){
        return vida_enemiga;
    }
    public int Get_puntaje(){
        return puntaje;
    }
    void OnCollisionEnter(UnityEngine.Collision other){
            if(other.gameObject.name=="bala"){
                vida_enemiga-=other.gameObject.GetComponent<balascript>().danio;
                if(vida_enemiga>=0){
                    vida.gameObject.GetComponent<TextMesh>().text=string.Concat(Enumerable.Repeat("*", vida_enemiga));
                }
                Debug.Log(vida_enemiga);
                if(vida_enemiga<=0){
                    puntaje+=1;
                    Debug.Log(puntaje);
                    Destroy(this.gameObject, 0);
                }
                    
            }
                
        }
}
