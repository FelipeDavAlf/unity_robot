using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosionfin : MonoBehaviour
{
    public float speedbala = 3;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, 5);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * speedbala, Space.Self);
    }
}
