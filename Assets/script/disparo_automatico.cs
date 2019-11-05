using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disparo_automatico : MonoBehaviour
{
    public GameObject bala;   
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Ejemplo());
    }
    IEnumerator Ejemplo()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            Instantiate(bala, this.transform.position, this.transform.rotation);
        }
    }
    
}
