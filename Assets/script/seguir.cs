using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seguir : MonoBehaviour
{
     GameObject tanque;
    public float speed=1;
    // Update is called once per frame
    void Start(){
        tanque=GameObject.FindGameObjectWithTag("tanque");
    }
    void Update(){
        //float distancia=Vector3.Distance(tanque.transform.position,transform.position);
        transform.position=Vector3.MoveTowards(transform.position,tanque.transform.position,speed*Time.deltaTime);
    }
}
