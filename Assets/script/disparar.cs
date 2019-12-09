using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disparar : MonoBehaviour
{
    public GameObject[] bala=new GameObject[3];
    public GameObject menu;
    int[] ids;
    bool recarga=true;
    public int[] tiempo={3,4,5};

    public AudioClip canon;
    public AudioSource sonido;

    void Start(){
        ids= menu.GetComponent<Menu_Armas>().armas_Get();
        sonido=GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update(){
        if(Input.GetKeyDown(KeyCode.Z)&&this.CompareTag("municion_izq")&&recarga==true){//si preciona "z" dispara con el cañon izquerdo
           Instantiate(bala[ids[0]] ,this.transform.position,this.transform.rotation);
            sonido.PlayOneShot(canon);
           recarga=false;
            StartCoroutine(Recargaizq());
        }
        if(Input.GetKeyDown(KeyCode.X)&&this.CompareTag("municion_der")&&recarga==true){//si preciona "x" dispara con el cañon derecho
            Instantiate(bala[ids[1]] ,this.transform.position,this.transform.rotation);
            sonido.PlayOneShot(canon);
            recarga=false;
            StartCoroutine(Recargader());
        }
    }

    IEnumerator Recargaizq(){
        yield return new WaitForSeconds(tiempo[ids[0]]);
        recarga=true;  
    }
    IEnumerator Recargader(){
        yield return new WaitForSeconds(tiempo[ids[0]]);
        recarga=true;  
    }
}
