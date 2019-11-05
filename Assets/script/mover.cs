using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour
{
	Transform tankTransform;
    public GameObject tank;
    // Start is called before the first frame update
    void Start()
    {
        tankTransform=tank.GetComponent<Transform>();
        	StartCoroutine(Ejemplo());	
        
    }

    // Update is called once per frame
    IEnumerator Ejemplo()
    {
        while (true)
        {
            yield return new WaitForSeconds(5);
            tankTransform.Translate(Vector3.forward * Time.deltaTime * 500, Space.Self);
            yield return new WaitForSeconds(5);
            tankTransform.Translate(Vector3.left * Time.deltaTime * 500, Space.Self);
            yield return new WaitForSeconds(5);
            tankTransform.Translate(Vector3.back * Time.deltaTime * 500, Space.Self);
            yield return new WaitForSeconds(5);
            tankTransform.Translate(Vector3.right * Time.deltaTime * 500, Space.Self);

        }
    }
}
