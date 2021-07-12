using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalonKontrolcu : MonoBehaviour
{
    public GameObject patlama;
    OyunKontrolcu oyunkontrolscripti; //nesne oluşturma

    void Start()
    {
        oyunkontrolscripti=GameObject.Find("GameObject").GetComponent<OyunKontrolcu>();
    }

    void OnMouseDown()
    {
        GameObject go= Instantiate(patlama, transform.position,transform.rotation) as GameObject;
        Destroy(this.gameObject);
        Destroy(go,0.3f);
        oyunkontrolscripti.BalonEkle();
    }
}
