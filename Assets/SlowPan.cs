using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SlowPan : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      
        
    }

    // Update is called once per frame
    public GameObject Bg;
    void Update()
    {
        Bg.transform.position += Vector3.up * Time.deltaTime * .5f;
    }
}
