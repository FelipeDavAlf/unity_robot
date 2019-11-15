using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update() {
        
    }
    public void jugar(string nombre){
        SceneManager.LoadScene(nombre);
    }

    public void cerrar_juego(){
        Application.Quit();
        Debug.Log("Salisteeeee");
    }
}
