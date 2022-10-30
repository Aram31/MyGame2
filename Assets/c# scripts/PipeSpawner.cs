using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject Pipes;
    void Start()
    {
      StartCoroutine(Spawner());  
    }

 IEnumerator Spawner()
 {
    while(true)
    {
        yield return new WaitForSeconds(2);
        float rand = Random.Range(-0.72f, 3.63f);
        GameObject newPipes = Instantiate(Pipes, new Vector3(4, rand, 0), Quaternion.identity);
        Destroy(newPipes, 10);
    }
 }
}
