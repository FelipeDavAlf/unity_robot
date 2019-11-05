using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exploshion : MonoBehaviour
{
    public GameObject explotar;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.Z))
        {
            Instantiate(explotar, this.transform.position, this.transform.rotation);
        }
    }
}
