using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disparar : MonoBehaviour
{
    public GameObject[] bala=new GameObject[3];
    public GameObject menu;
    int[] ids;
    bool recarga=true;
    // Start is called before the first frame update
    void Start(){
        ids= menu.GetComponent<Menu_Armas>().armas_Get();
    }

    // Update is called once per frame
    void Update(){
        if(Input.GetKeyDown(KeyCode.Z)&&this.CompareTag("municion_izq")&&recarga==true){
        	//Instantiate(bala,this.transform.position, this.transform.rotation);
           Instantiate(bala[ids[0]] ,this.transform.position,this.transform.rotation);
           recarga=false;
            StartCoroutine(Recarga());
        }
        if(Input.GetKeyDown(KeyCode.X)&&this.CompareTag("municion_der")&&recarga==true){
        	//Instantiate(bala,this.transform.position, this.transform.rotation);
            Instantiate(bala[ids[1]] ,this.transform.position,this.transform.rotation);
            recarga=false;
            StartCoroutine(Recarga());
        }
    }

        IEnumerator Recarga(){
            yield return new WaitForSeconds(2);
            recarga=true;
           
    }
}
