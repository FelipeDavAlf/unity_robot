using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instan_armas : MonoBehaviour{ 
    public GameObject menu;
    public GameObject[] arma=new GameObject[3];
    int[] ids;

    void Start(){
        GameObject padre=GameObject.Find("arma_izq");
        ids= menu.GetComponent<Menu_Armas>().armas_Get();
        /*List<Armas> arms = new List<Armas>();
        new List<Armas>().Add(new Armas{id=0,nombre_arma = "Fatty" , nombre_bala="Fatty_bullet" ,velocidad=2f,danio=5});
        new List<Armas>().Add(new Armas{id=1,nombre_arma = "Turret_OS" , nombre_bala="Fatty_bullet" ,velocidad=5f,danio=1});
        new List<Armas>().Add(new Armas{id=2,nombre_arma = "Red_Demon" , nombre_bala="Fatty_bullet" ,velocidad=3f,danio=3});
        /*foreach (var item in arms){
            Debug.Log(item);
        }*/
        if(this.CompareTag("arma_der")){
             Instantiate(arma[ids[1]] ,this.transform.position,this.transform.rotation).transform.parent=this.transform;
             
                //Instantiate(GameObject.Find(/*arms[men.ids()[1]].nombre_arma*/"Fatty"),this.transform.position,this.transform.rotation);
                //Debug.Log("instanciado der");
        }
        if(this.CompareTag("arma_izq")){
            
            Instantiate(arma[ids[0]] ,this.transform.position,this.transform.rotation).transform.parent=this.transform;
              //  Instantiate(GameObject.Find(arms[men.ids()[0]].nombre_arma),this.transform.position,this.transform.rotation);
               // Debug.Log("instanciado izqu");
        }
        
        
        //men.ids()[0];
    }

    // Update is called once per frame
    void Update(){
        
    }
}
