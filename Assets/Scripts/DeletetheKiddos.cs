using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeletetheKiddos : MonoBehaviour
{
    private GameObject kids;
    void OnTriggerEnter(Collider other)
    {
        if (other == kids)
        {
            Destroy(kids);
        }
        
    }

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        kids = GameObject.FindGameObjectWithTag("kids");
    }
}
