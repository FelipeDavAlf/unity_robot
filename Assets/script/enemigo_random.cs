using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemigo_random : MonoBehaviour{
    public GameObject enemigo;
    void Start(){
        StartCoroutine(Ejemplo());
        
    }
    //Vector3 random_position= new Vector3(Random.Range(27.5,37),1,Random.Range(20,30));
    IEnumerator Ejemplo(){
        for (int i = 0; i < 50; i++){
            Vector3 random_position= new Vector3(Random.Range(0,2)==0?Random.Range(27.5f,30f):Random.Range(34.5f,37f),0.5f,Random.Range(20,30));
            Instantiate(enemigo,random_position, this.transform.rotation);
            yield return new WaitForSeconds(1);
        } 

    }
}
