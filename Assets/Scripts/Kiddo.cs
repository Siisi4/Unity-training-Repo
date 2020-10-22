using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Kiddo : MonoBehaviour
{
    
    public GameObject mother;
    public GameObject kiddo;
    public Transform ici;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    if (mother.transform.localScale.y > 4.24f)
    {
        Vector3 position = ici.position;
        Quaternion rotation = ici.rotation;
        Instantiate(kiddo, position, rotation);
    }
        
        
    }
}
