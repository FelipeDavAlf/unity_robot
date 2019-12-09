using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class retomar : MonoBehaviour{
    // Start is called before the first frame update
    public GameObject armas;
    GameObject historia;
    void Start(){
        historia=GameObject.Find("history");
    }
    public void remornar(){
        historia.GetComponent<Historia>().Set_contador(0);
        historia.GetComponent<Historia>().Set_historia("");
        historia.GetComponent<Historia>().StopCoroutine("Contar_historia");
        armas.SetActive(true);
    }
}
