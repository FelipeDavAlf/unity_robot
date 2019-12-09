using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cuemta_historia : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject historia;
    public GameObject contexto;
    public void Comienza(){
        contexto.SetActive(true);
        historia.GetComponent<Historia>().StartCoroutine("Contar_historia");

    }
}
