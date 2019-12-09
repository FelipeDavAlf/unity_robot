using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System.Linq;
using UnityEngine;
public class controlCanon : MonoBehaviour
{
    public int puntaje=0;
    public float speed = 5;
    Transform inferior_canon;
    int vida_jugador=50;
    GameObject vida;
    bool zona_segura=true;
    GameObject fuera_arena;
    public GameObject muy_daniado;
    bool danio=true;
    public GameObject Game_Over;
    public GameObject lose_background;
    public GameObject exposion;

    void Start(){
        inferior_canon = this.GetComponent<Transform>();
        //superiro_canon = canon.GetComponent<Transform>();
        vida=GameObject.Find("Vida"); //imprime la vida del personaje
        vida.gameObject.GetComponent<TextMesh>().text=string.Concat(Enumerable.Repeat("|", vida_jugador));
        fuera_arena=GameObject.Find("Canvas");
        fuera_arena.gameObject.GetComponent<Canvas>();
        
    }

    // Update is called once per frame
    void Update(){
        if (Input.GetKey(KeyCode.W)){//permite que el tanque vaya hacia delante
            inferior_canon.Translate(Vector3.forward * Time.deltaTime * speed, Space.Self);
        }  else if (Input.GetKey(KeyCode.S)){//permite que el tanque vaya hacia atras
            inferior_canon.Translate(Vector3.back * Time.deltaTime * speed, Space.Self);

        }
         if (Input.GetKey(KeyCode.A)){//permite que el tanque gire hacia la izquierda
            inferior_canon.Rotate(Vector3.down * Time.deltaTime * 150, Space.World);
        }else if (Input.GetKey(KeyCode.D)){//permite que el tanque gire hacia la derecha
            inferior_canon.Rotate(Vector3.up * Time.deltaTime * 150, Space.World);
        }
       
    }

    public int Get_puntaje(){
        return puntaje;
    }

    void MostrarVida(){
        if (vida_jugador>10&&vida_jugador<26)//cambia el color de la vida en amarillo
            vida.gameObject.GetComponent<TextMesh>().color=Color.yellow;
        else if(vida_jugador<11&&danio){//cambia el color de la vida en rojo
            vida.gameObject.GetComponent<TextMesh>().color=Color.red; 
            Instantiate(muy_daniado,this.transform.position,this.transform.rotation).transform.parent=this.transform; 
            danio=false;
        }
        if(vida_jugador<=0){////el jugador murio
            Time.timeScale=0;
            lose_background.gameObject.GetComponent<AudioSource>();
            Game_Over.SetActive(true);    
        }
    }
    void OnCollisionEnter(Collision other){//colision con enemigo
        if(other.gameObject.name=="aracnido(Clone)"){//si el jugador choca contra el enemigo
            puntaje+=1;
            Debug.Log(puntaje);
            other.gameObject.GetComponent<Animator>().SetTrigger("atacar");//animacion de atacar
            
            int danio_enemigo=other.gameObject.GetComponent<destruircubo>().vida_enemiga;
            vida_jugador-=danio_enemigo;//daño en base a la vida del enemigo

            if(vida_jugador>=0)
                vida.gameObject.GetComponent<TextMesh>().text=string.Concat(Enumerable.Repeat("|", vida_jugador));
            else
                vida.gameObject.GetComponent<TextMesh>().text="";

            MostrarVida();//llama a la funcion para cambiar el color del puntaje

            
            Destroy(other.gameObject,0.2f);//destruye al enemigo
            Destroy(Instantiate(exposion,other.transform.position,other.transform.rotation).gameObject,1f);//destruye la explosion            
            
        }
        if (other.gameObject.name=="Arena"){///si entra a la arena para de dañar al jugador
            fuera_arena.GetComponentInChildren<Image>().color=Color.clear;
            zona_segura=true;
            StopCoroutine(BajaVida());
        }
        
    } 

    void OnCollisionExit(Collision other){//si sale de la arena se hara daño
        if(other.gameObject.name=="Arena"){
            fuera_arena.GetComponentInChildren<Image>().color=Color.magenta;
            zona_segura=false;
            StartCoroutine(BajaVida());
            
        }
    }

    IEnumerator BajaVida(){///baja vida por segundos
        while(!zona_segura){
            Debug.Log(vida_jugador);
            vida_jugador--;
            MostrarVida();
            yield return new WaitForSeconds(1);
        }
        
    }
}
