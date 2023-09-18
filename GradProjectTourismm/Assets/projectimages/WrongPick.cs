using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WrongPick : MonoBehaviour
{
    public GameObject Hamza;
    public MummyMovement RefController;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(transform.position, Hamza.transform.position) < 0.08)
        {
            RefController.Lost();
            Destroy(gameObject);
        }
    }
}
