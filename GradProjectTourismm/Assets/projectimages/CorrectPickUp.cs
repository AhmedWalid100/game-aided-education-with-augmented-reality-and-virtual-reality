using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorrectPickUp : MonoBehaviour
{
    public GameObject amood;
    public amoodScript amoodScr;
    public GameObject effectstar;
    public AudioSource CollectAudio;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    void OnTriggerEnter(Collider other)
    {
        

        if (other.gameObject.tag == "amood")
        {
            amoodScr.condition = amoodScr.condition + 1;
            Instantiate(effectstar, transform.position, transform.rotation);
            gameObject.SetActive(false);
            CollectAudio.Play();
        }
            
        
    }

}
