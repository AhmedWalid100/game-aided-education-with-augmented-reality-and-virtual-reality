using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class TakeDamage : MonoBehaviour
{
    public int health;
    public bool Correct;
    public RayCastTest MainScr;
    public GameObject Ref;
    public AudioSource ExplosionAudio;
    public GameObject Explosionfx;
    // Start is called before the first frame update
    void Start()
    {
        health = 50;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(0.02f*Time.deltaTime, 0, 0);
        //Debug.Log(Vector3.Distance(Ref.transform.position, transform.position));
        if (health < 0 && Correct==true)
        {
            MainScr.YouLostt();
            Destroy(this.gameObject);
            
            
        }
        if (health < 0 && Correct == false)
        {
            ExplosionAudio.Play();
            Instantiate(Explosionfx, transform.position, transform.rotation);
            Destroy(this.gameObject);
        }
        if (Vector3.Distance(Ref.transform.position, transform.position) < 0.13 && Correct == false)
        {
            MainScr.YouLostt();
            //MainScr.Mainhealth = MainScr.Mainhealth - 25;
            Destroy(this.gameObject);
        }
        if (Vector3.Distance(Ref.transform.position, transform.position) < 0.13 && Correct == true)
        {
            RayCastTest.passed = RayCastTest.passed + 1;
            Destroy(this.gameObject);
        }

    }
    public void Damaged()
    {
        health = health - 1;

    }
}
