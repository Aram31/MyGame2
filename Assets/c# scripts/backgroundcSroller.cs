using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundcSroller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      transform.position += new Vector3(-2 * Time.deltaTime, 0);
      if(transform.position.x < -14.86)
      {
        transform.position = new Vector3(+14.86f, transform.position.y);
      } 
    }
}
