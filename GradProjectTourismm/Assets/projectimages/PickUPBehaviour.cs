using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUPBehaviour : MonoBehaviour
{
    public GameObject Hamza;
    public GameControllerQal3a RefController;
    public AudioSource Pickupsound;
    public GameObject CollectEffect;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(transform.position, Hamza.transform.position) < 0.08)
        {
            RefController.PickedUP = RefController.PickedUP + 1;
            Pickupsound.Play();
            Instantiate(CollectEffect, transform.position, transform.rotation);
            gameObject.SetActive(false);
        }
    }
}
