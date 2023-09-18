using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class RayCastTest : MonoBehaviour
{
    public GameObject Bloodfx;
    public Text Healthtext;
    public int Mainhealth;
    public GameObject Right2;
    public GameObject Wrong2;
    public GameObject Right3;
    public GameObject Wrong3;
    public GameObject YoulostImg;
    public AudioSource YoulostAudio;
    public bool Lost = false;
    public static int passed;
    public GameObject WinImg;
    public AudioSource WinSound;
    public bool WonGamee=false;
    // Start is called before the first frame update
    void Start()
    {
        passed = 0;
        Mainhealth = 50;
        StartCoroutine(SecondThirdPhase());
    }

    // Update is called once per frame
    void Update()
    {
        if (passed >= 3&& WonGamee==false)
        {
            WonGamee = true;
            StartCoroutine(WonGame());
        }
        Healthtext.text = "Health: " + Mainhealth;
        RaycastHit Hit;
        if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out Hit))
        {
            Debug.Log(Hit.transform.name);
            Hit.transform.gameObject.GetComponent<TakeDamage>().Damaged();
            Instantiate(Bloodfx, Hit.point, Quaternion.identity);
        }
    }
    IEnumerator SecondThirdPhase()
    {
        yield return new WaitForSeconds(20.0f);
        Right2.SetActive(true);
        Wrong2.SetActive(true);
        yield return new WaitForSeconds(13.0f);
        Right3.SetActive(true);
        Wrong3.SetActive(true);
    }

    public void YouLostt()
    {
        StartCoroutine(YouLost());
    }
    IEnumerator YouLost()
    {
        if (Lost == false)
        {
            YoulostImg.SetActive(true);
            YoulostAudio.Play();
            Lost = true;
            yield return new WaitForSeconds(2.5f);
            SceneManager.LoadScene("SecondScene");
        }
        
    }
    IEnumerator WonGame()
    {
        WinImg.SetActive(true);
        WinSound.Play();
        yield return new WaitForSeconds(6.0f);
        SceneManager.LoadScene("TransitionThree");
    }
}
