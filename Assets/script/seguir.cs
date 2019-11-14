using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class seguir : MonoBehaviour
{
    GameObject tanque;
    static int count=50;
    public TextMesh vida;
    public float speed=1;
    // Update is called once per frame
    void Start(){
        tanque=GameObject.FindGameObjectWithTag("tanque");
    }
    void Update(){
        //float distancia=Vector3.Distance(tanque.transform.position,transform.position);
        transform.position=Vector3.MoveTowards(transform.position,tanque.transform.position,speed*Time.deltaTime);
    }
    void OnCollisionEnter(Collision other){
            if(other.gameObject.name=="tanque"){
                count--;
                vida.text="Vida:";
                vida.text=vida.text+count;
                Debug.Log(vida.text);
                if(count==0){
                     Destroy(tanque, 0);
                }
            }
    }      
}
