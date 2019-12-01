using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu_Armas : MonoBehaviour
{
    int num_armas=0;
    static bool[] armas=new bool [3]; 
    GameObject boton_jugar;
    // Start is called before the first frame update 
    void Start(){
        /*foreach (var item in armas){
            Debug.Log(item);
        }*/
        if (this.CompareTag("menu")){
            boton_jugar=GameObject.Find("Jugar");
            if (boton_jugar!=null){
                boton_jugar.gameObject.GetComponent<Button>().interactable=false;
            }
        }
            
            
    }

    public int[] armas_Get(){
        int[] id=new int[2];
        int cont=0;
        for (int i = 0; i < armas.Length; i++){
            if(armas[i]){
                id[cont]=i;
                cont++;
            }
                
        }
        return id;
    }
    public void jugar(string nombre){
        
        SceneManager.LoadScene(nombre);
    }

    public void cerrar_juego(){
        Application.Quit();
        Debug.Log("Salisteeeee");
    }

    public void Comprobar_armas(){
            num_armas=0;
        if(GameObject.Find("Arma1").GetComponent<Toggle>().isOn)
            armas[0]=true;
        else
            armas[0]=false;
        if(GameObject.Find("Arma2").GetComponent<Toggle>().isOn)
            armas[1]=true;
        else
            armas[1]=false;
        if(GameObject.Find("Arma3").GetComponent<Toggle>().isOn)
            armas[2]=true; 
        else
            armas[2]=false;  
        foreach (bool item in armas){
            if(item)
                num_armas++;
        }
        if (boton_jugar!=null){
            if (num_armas==2){
                boton_jugar.gameObject.GetComponent<Button>().interactable=true;
            }else{
                boton_jugar.gameObject.GetComponent<Button>().interactable=false;
            }
        }
    }
}
