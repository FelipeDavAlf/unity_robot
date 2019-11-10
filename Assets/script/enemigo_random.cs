using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemigo_random : MonoBehaviour{
    public GameObject enemigo;
    void Start(){
        for (int i = 0; i < 20; i++){
            Vector3 random_position= new Vector3(Random.Range(28,37),1,Random.Range(20,30));
            Instantiate(enemigo,random_position, this.transform.rotation);
        }
        
            
    }
}
