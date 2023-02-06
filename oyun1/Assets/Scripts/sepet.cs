using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class sepet : MonoBehaviour
{

    public float hiz;

    int skor = 0;
    

    TextMeshProUGUI skor_txt;
    public AudioSource ses_dosyasi;
    public AudioClip pat_sesi;
    
    private void Start()
    {
        skor_txt = GameObject.Find("Canvas/skor_txt").GetComponent<TextMeshProUGUI>();
    }
    
    
    private void OnCollisionEnter(Collision collision)//çarpma fonksiyonu
    {
        if (collision.gameObject.tag == "elma")
        {
            ses_dosyasi.PlayOneShot(pat_sesi);
            skor += 10;
           // Debug.Log(skor.ToString());
            skor_txt.text = skor.ToString();

            Destroy(collision.gameObject);
        }
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(hiz * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-hiz * Time.deltaTime, 0, 0);
        }
        
    }
}
