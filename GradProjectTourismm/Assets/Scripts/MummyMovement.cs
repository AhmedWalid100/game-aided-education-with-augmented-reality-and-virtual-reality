using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MummyMovement : MonoBehaviour
{
    public bool UP;
    public float posit;
    public Transform UPMummy;
    public Transform DOWNMummy;
    public GameObject Hamza;
    public GameObject YouLostimg;
    public AudioSource Youlostsound;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Vector3.Distance(transform.position, Hamza.transform.position));

        if (Vector3.Distance(transform.position, Hamza.transform.position) < 0.095)
        {
            Debug.Log("Bom");
            StartCoroutine(YouLost());
        }
        if (Vector3.Distance(transform.position, UPMummy.position) < 0.02)
        {
            UP = false;
        }
        if (Vector3.Distance(transform.position, DOWNMummy.position) < 0.02)
        {
            UP = true;
        }
        if (UP == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, UPMummy.position, 0.2f * Time.deltaTime);
            transform.LookAt(UPMummy);
        }
        if (UP == false)
        {
            transform.position = Vector3.MoveTowards(transform.position, DOWNMummy.position, 0.2f * Time.deltaTime);
            transform.LookAt(DOWNMummy);
        }


    }
    public void Lost()
    {
        StartCoroutine(YouLost());
    }
    IEnumerator YouLost()
    {
        YouLostimg.SetActive(true);
        Youlostsound.Play();
        yield return new WaitForSeconds(2.2f);
        
        SceneManager.LoadScene("MainScene");
    }
}
