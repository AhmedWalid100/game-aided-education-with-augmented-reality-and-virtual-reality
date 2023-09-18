using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class amoodScript : MonoBehaviour
{

    public GameObject firstamood;
    public GameObject secondamood;
    public GameObject thirdamood;
    public GameObject fourthamood;
    public GameObject fifthamood;
    public GameObject Correct3;
    public GameObject Correct4;
    public GameObject Wrong3;
    public GameObject Wrong4;
    public GameObject Wrong1;
    public GameObject Wrong2;
    public int condition=0;
    public bool isDone = false;
    public bool wonGame = false;
    public AudioSource YouWin;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (condition == 1)
        {
            firstamood.SetActive(false);
            secondamood.SetActive(true);
        }
        if (condition == 2)
        {
            secondamood.SetActive(false);
            thirdamood.SetActive(true);
        }
        if (condition == 3)
        {
            thirdamood.SetActive(false);
            fourthamood.SetActive(true);
        }
        if (condition == 4 && wonGame==false)
        {
            fourthamood.SetActive(false);
            fifthamood.SetActive(true);
            wonGame = true;
            StartCoroutine(YouWonTheGame());

        }
        if (condition == 2&&isDone==false)
        {
            StartCoroutine(Secondphase());
            isDone = true;
        }
    }
    IEnumerator Secondphase()
    {
        
        Wrong1.SetActive(false);
        Wrong2.SetActive(false);
        yield return new WaitForSeconds(3.0f);
        Wrong3.SetActive(true);
        Wrong4.SetActive(true);
        Correct3.SetActive(true);
        Correct4.SetActive(true);
    }
    IEnumerator YouWonTheGame()
    {
        YouWin.Play();
        yield return new WaitForSeconds(4.0f);
        SceneManager.LoadScene("LastScene");
    }
}
