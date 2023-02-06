using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class yönetici : MonoBehaviour
{
    [SerializeField] GameObject baslangıcButon;
    public GameObject elma;

    bool oyun_stop = false;

    public void baslatButon()
    {
        baslangıcButon.SetActive(false);
        Time.timeScale = 1.0f;
    }
    public void cikisButon()
    {
        Application.Quit(); 
    }
    public void durdur_btn()
    {
        oyun_stop = !oyun_stop;

        if(oyun_stop==true)
        {
            Time.timeScale = 0.0f;

        }
        else
        {
            Time.timeScale = 1.0f;

        }
                    
    }


    void Start()
    {
        Time.timeScale = 0.0f;
        InvokeRepeating("elmaEkle", 0.0f, 1.0f);

    }


    private void elmaEkle()
    {
        float rast = Random.Range(-3, 10);
        GameObject yeniElma =Instantiate(elma, new Vector3(rast, 9.6f, 0),Quaternion.identity );
    } 

    
}
