using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VardaParadisana : MonoBehaviour{
    //Mainīgajā saglabās rekstu ko raksta teksta laukā
    public string teksts;
    //Lauks, kurā ieraksta tekstu
    public GameObject ievadesLauks;
    //Kur attēlot tekstu
    public GameObject tekstaAttelosana;

    //Funkcija tiek izsaukta nospiežot pogu
    public void uzglabatTekstu()
    {
        teksts = ievadesLauks.GetComponent<Text>().text;
        tekstaAttelosana.GetComponent<Text>().text = "Sveiks "+teksts.ToUpper()+"!";
    }
}
