using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Historia : MonoBehaviour{
    string historia="Eres el ultimo sobreviviente\n"+ 
                    "de tu brigada de reconocimiento\n"+
                    "en este paramo desconocido,\n" +
                    "has que tus camaradas descansen\n"+ 
                    "en paz, envia cuanto enemigo\n"+
                    "te encuentres como ofrenda!!!";
    int contador=0;
    void Start(){
        this.gameObject.GetComponent<Text>().text="";
        StartCoroutine(Contar_historia());
        
    }
    public void Set_contador(int cont){
        contador=cont;
    }
    public void Set_historia(string hist){
        this.gameObject.GetComponent<Text>().text=hist;
    }
    public string Get_historia(){
        return historia;
    }

    IEnumerator Contar_historia(){
        while(contador<historia.Length){
            this.gameObject.GetComponent<Text>().text=this.gameObject.GetComponent<Text>().text+historia[contador];
            yield return new WaitForSeconds(0.1f);
            contador++;
        }
        
    }
}
