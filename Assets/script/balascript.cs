using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balascript : MonoBehaviour
{
	public float speedbala=3;
    public GameObject explotar;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, 3); 

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up* Time.deltaTime*speedbala,Space.Self);
    }
    void OnCollisionEnter(UnityEngine.Collision other){
             //   Instantiate(explotar , this.transform.position, this.transform.rotation);
                Destroy(Instantiate(explotar , this.transform.position, this.transform.rotation),2);
                Destroy(this.gameObject, 0);                
        }
}
