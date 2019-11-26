using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlCanon : MonoBehaviour
{
    public float speed = 3;
    Transform inferior_canon;
    //Transform superiro_canon;
    //public GameObject canon;
    // Start is called before the first frame update
    void Start()
    {
        inferior_canon = this.GetComponent<Transform>();
        //superiro_canon = canon.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            inferior_canon.Translate(Vector3.forward * Time.deltaTime * speed, Space.Self);
        }  else if (Input.GetKey(KeyCode.S))
        {
            inferior_canon.Translate(Vector3.back * Time.deltaTime * speed, Space.Self);
        }else if (Input.GetKey(KeyCode.A))
        {
            inferior_canon.Rotate(Vector3.down * Time.deltaTime * 100, Space.World);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            inferior_canon.Rotate(Vector3.up * Time.deltaTime * 100, Space.World);
        }

       /* if (Input.GetKey(KeyCode.Q))
        {
            superiro_canon.Rotate(Vector3.down * Time.deltaTime * 100, Space.World);
        }
        else if (Input.GetKey(KeyCode.E))
        {
            superiro_canon.Rotate(Vector3.up * Time.deltaTime * 100, Space.World);
        }*/

        
    }
}
