using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class puntaje : MonoBehaviour{

    public GameObject puntaje_jugador;
    public GameObject puntaje_enemigo;
    void Start(){
        int jugador=puntaje_jugador.GetComponent<controlCanon>().Get_puntaje();
        int enemigo=puntaje_enemigo.GetComponent<destruircubo>().Get_puntaje();
        int puntaje_final=jugador+enemigo;
        this.GetComponentInChildren<Text>().text= this.GetComponentInChildren<Text>().text+" "+puntaje_final;
    }
    
    // Update is called once per frame
}
