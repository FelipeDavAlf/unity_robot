using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
public class seguir : MonoBehaviour
{
    bool detener=false;
    GameObject tanque;
   
    //TextMesh vida;
    public float speed=1.5f;

    public Animator anim;
    // Update is called once per frame
    void Start(){
        tanque=GameObject.FindGameObjectWithTag("tanque");
    }
    void Update(){
        //sirve para seguir al jugador
        Vector3 direction=tanque.transform.position-transform.position;
        Quaternion rotation=Quaternion.LookRotation(direction);


        Debug.DrawRay(transform.position+new Vector3(0,0.1f,0), transform.forward *25, Color.yellow);
        Ray rayo=new Ray(transform.position+new Vector3(0,0.1f,0), transform.forward ); 
        RaycastHit hit=new RaycastHit();
        if(Physics.Raycast(rayo, out hit, 25,1<<8)) {   
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
        if (!detener ){
            transform.rotation=Quaternion.Lerp(transform.rotation,rotation,0.9f*Time.deltaTime);
            this.transform.Translate(Vector3.forward * Time.deltaTime * 1, Space.Self);
        }
    }
         
}
