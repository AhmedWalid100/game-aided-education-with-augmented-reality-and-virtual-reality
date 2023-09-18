using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransitionsScr : MonoBehaviour
{
    public AudioSource First;
    public AudioSource Second;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void FirstStart()
    {
        SceneManager.LoadScene("SecondScene");
    }
    public void SecondStart()
    {
        SceneManager.LoadScene("ThirdScene");
    }
    public void MainStart()
    {
        SceneManager.LoadScene("MainScene");
    }
    public void FirstTut()
    {
        First.Play();
    }
    public void SecondTut()
    {
        Second.Play();
    }
}
