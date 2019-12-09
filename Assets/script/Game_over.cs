using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Game_over : MonoBehaviour{
    // Start is called before the first frame update
    public GameObject Game_Over;
    void Start(){
        Game_Over.SetActive(false); 
    }

    // Update is called once per frame
    void Update(){
        
    }

    public void cerrar_juego(){
        Application.Quit();
        Debug.Log("Salisteeeee");
    }
    public void Nuevo_juego(string nombre){
        SceneManager.LoadScene(nombre);
    }

    public void Reiniciar_Juego(){
        Time.timeScale=1;
        SceneManager.LoadScene(0);
    }
}
