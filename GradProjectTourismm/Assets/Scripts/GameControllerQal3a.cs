using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControllerQal3a : MonoBehaviour
{
    public GameObject Hamza;
    public GameObject Castle;
    public MummyMovement mummymovement;
    public GameObject Ghost1;
    public GameObject Ghost2;
    public GameObject Ghost3;
    public GameObject Ghost4;
    //public GameObject Ghost5;
    public GameObject Wara2a1;
    public GameObject Wara2a2;
    public GameObject Wara2a3;
    public GameObject Soora1;
    public GameObject Soora2;
    public GameObject Soora3;
    public int PickedUP;
    public float Timer;
    public bool StartTimer = false;
    public Text canvastxt;
    public bool wongame = false;
    public AudioSource YouWinAudio;
    public GameObject YouWinImg;

    // Start is called before the first frame update
    void Start()
    {
        Timer = 55;
        PickedUP = 0;
      
        StartCoroutine(StartQal3a());
    }

    // Update is called once per frame
    void Update()
    {
        if (PickedUP == 2)
        {
            Wara2a2.SetActive(false);
            Soora1.SetActive(true);
            Soora2.SetActive(true);
            Soora3.SetActive(true);
        }

        if (Vector3.Distance(Hamza.transform.position, Castle.transform.position) <= 0.2 && PickedUP >= 4 && wongame==false)
        {
            wongame = true;
            StartCoroutine(WonGame());
        }
      
        if (StartTimer == true)
        {
            Timer -= 1 * Time.deltaTime;
        }
        if (Timer <= 0)
        {
            Timer = 0;
            StartTimer = false;
            if (wongame == false)
            {

                mummymovement.Lost();

            }

        }
        canvastxt.text = Timer.ToString("0");
    }
    IEnumerator StartQal3a()
    {
        yield return new WaitForSeconds(5.0f);
        Ghost1.SetActive(true);
        Ghost2.SetActive(true);
        Ghost3.SetActive(true);
        Ghost4.SetActive(true);
        //Ghost5.SetActive(true);
        Wara2a1.SetActive(true);
        Wara2a2.SetActive(true);
        Wara2a3.SetActive(true);
        StartTimer = true;
    }
    IEnumerator WonGame()
    {
        
        
        YouWinAudio.Play();
        YouWinImg.SetActive(true);
        
        yield return new WaitForSeconds(6.0f);
        SceneManager.LoadScene("TransitionTwo");
    }
}
