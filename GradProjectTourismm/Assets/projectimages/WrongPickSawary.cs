using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WrongPickSawary : MonoBehaviour
{
    public GameObject amood;
    public GameObject Explodeeffect;
    public GameObject losecanvas;
    public AudioSource loseaudio;
    public AudioSource explodedaudio;
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
            Instantiate(Explodeeffect, transform.position, transform.rotation);
            explodedaudio.Play();
            StartCoroutine(Exploded());
        }


    }
    IEnumerator Exploded()
    {
        yield return new WaitForSeconds(2.0f);
        losecanvas.SetActive(true);
        loseaudio.Play();
        yield return new WaitForSeconds(1.4f);
        SceneManager.LoadScene("ThirdScene");

    }
}
