using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rayo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.E)) {
        	Debug.DrawRay(transform.position, transform.up * 100, Color.yellow);
        	Ray ray = new Ray(transform.position, transform.up);
        	RaycastHit hit;
        	if(Physics.Raycast(ray, out hit, 1000)) {
        		print(hit.distance);
        		print(hit.collider.name);
        	}
        }
    }
}
