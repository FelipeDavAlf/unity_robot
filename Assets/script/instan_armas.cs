using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instan_armas : MonoBehaviour{ 
    public GameObject menu;
    public GameObject[] arma=new GameObject[3];
    int[] ids;

    void Start(){
        ids= menu.GetComponent<Menu_Armas>().armas_Get();//returna los ids de las armas 
        if(this.CompareTag("arma_der")){
             Instantiate(arma[ids[1]] ,this.transform.position,this.transform.rotation).transform.parent=this.transform;
        }
        if(this.CompareTag("arma_izq")){         
            Instantiate(arma[ids[0]] ,this.transform.position,this.transform.rotation).transform.parent=this.transform;
        } 
    }


}
