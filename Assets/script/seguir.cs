using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
public class seguir : MonoBehaviour
{
    bool detener=false;
    GameObject tanque;
    static int count=50;
    //TextMesh vida;
    GameObject vida;
    public float speed=1;

    public Animator anim;
    // Update is called once per frame
    void Start(){
        tanque=GameObject.FindGameObjectWithTag("tanque");
        //vida.name="monedas";
        vida=GameObject.Find("Vida"); //imprime la vida del personaje
        vida.gameObject.GetComponent<TextMesh>().text=string.Concat(Enumerable.Repeat("|", count));
    }
    void Update(){
        //sirve para seguir al jugador
        //Ray rayo=new Ray(this.transform.position+new Vector3(0,0.1f,0),new Vector3(30,0,90)); 
        //Debug.DrawLine(this.transform.position+new Vector3(0,0.1f,0),new Vector3(30,0,90) ,Color.yellow);
  
        //if(hit.collider.gameObject.tag!="tanque"){
            //this.transform.Rotate(new Vector3(0,30,0)*Time.deltaTime);
 
        //transform.position=Vector3.MoveTowards(transform.position,tanque.transform.position,speed*Time.deltaTime);

        Debug.DrawRay(transform.position+new Vector3(0,0.1f,0), transform.forward *15, Color.yellow);
        Ray rayo=new Ray(transform.position+new Vector3(0,0.1f,0), transform.forward ); 
        RaycastHit hit=new RaycastHit();
        if(Physics.Raycast(rayo, out hit, 15)) {
            //print(hit.distance);
            //print(hit.collider.name);
            //print(hit.collider.tag);        
           if(hit.collider.tag=="tanque"){
               anim.SetBool("girar",false);
               anim.SetBool("avanzar",true);
               detener=true;
               transform.position=Vector3.MoveTowards(transform.position,tanque.transform.position,speed*Time.deltaTime);
           }else{
               anim.SetBool("girar",true);
                anim.SetBool("avanzar",false);
                detener=false;
           }
        }else{
            anim.SetBool("girar",true);
            anim.SetBool("avanzar",false);
            detener=false;
        }
        if (!detener){
            this.transform.Rotate(new Vector3(0,-30,0)*Time.deltaTime);
        }
        
    }
    void OnCollisionEnter(Collision other){
        if(other.gameObject.tag=="tanque"){
            count--;
            //vida.gameObject.GetComponent<TextMesh>().text="";
            vida.gameObject.GetComponent<TextMesh>().text=/*vida.gameObject.GetComponent<TextMesh>().text+*/string.Concat(Enumerable.Repeat("|", count));
            if (count>10&&count<25){
                vida.gameObject.GetComponent<TextMesh>().color=Color.yellow;
            }else if(count<11){
                vida.gameObject.GetComponent<TextMesh>().color=Color.red;
            }
            if(count==0){
                    Destroy(tanque, 0);
            }
        }
    }      
}
