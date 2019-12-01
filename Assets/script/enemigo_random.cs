using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemigo_random : MonoBehaviour{
    public GameObject enemigo;
  //  public GameObject vida_enemigo;
    void Start(){
        StartCoroutine(InstranciaEnemigos());
        
    }
    //Vector3 random_position= new Vector3(Random.Range(27.5,37),1,Random.Range(20,30));
    IEnumerator InstranciaEnemigos(){
        Transform tanque=GameObject.Find("tanque").GetComponentInChildren<Transform>(); 
        while(true){//instancia enemigos de manera aleatoria a lo largo del plano
                          
            Vector3 random_position= new Vector3(
                Random.Range(0,2)==0?Random.Range(tanque.position.x-5,tanque.position.x-10):Random.Range(tanque.position.x+5,tanque.position.x+10),//posicion aleatoria de enemigos en x
                this.transform.position.y,                  //posicion definida dependiendo del plano
                Random.Range(0,2)==0?Random.Range(tanque.position.z-5,tanque.position.z-10):Random.Range(tanque.position.z+5,tanque.position.z+10));                       //posicion aleatoria del enemogo en y
            Instantiate(enemigo,random_position, this.transform.rotation);
            //Instantiate(vida_enemigo,enemigo.transform.position, enemigo.transform.rotation).transform.parent=enemigo.transform;
            yield return new WaitForSeconds(5);
        }
           

    }
}
