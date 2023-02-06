using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ses : MonoBehaviour
{
    public AudioSource ses_dosyasi;
    void Start()
    {
        Invoke("sesi_kapat", 3.0f);
    }

    
    void sesi_kapat()
    {
        ses_dosyasi.Stop();
    }
}
