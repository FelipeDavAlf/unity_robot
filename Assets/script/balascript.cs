﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balascript : MonoBehaviour
{
	public float speedbala=1;
  //  public int tiempo=1;
    public int danio;
    public GameObject explotar;
    // Start is called before the first frame update
    void Start(){
        this.gameObject.name="bala";
        Destroy(this.gameObject, 3); 
    }

    // Update is called once per frame
    void Update(){
        transform.Translate(Vector3.forward* Time.deltaTime*speedbala,Space.Self);
    }
    void OnCollisionEnter(Collision other){       
        if(other.gameObject.name=="aracnido(Clone)"){
            Destroy(Instantiate(explotar , this.transform.position, this.transform.rotation),2);
            Destroy(this.gameObject, 0);    
        }            
    }
}
