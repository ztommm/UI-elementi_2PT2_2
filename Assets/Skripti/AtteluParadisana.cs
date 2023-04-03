using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AtteluParadisana : MonoBehaviour {
    public GameObject bins;
    public GameObject lacitis;
    public GameObject tante;
    public GameObject masina;
    public GameObject paKreisi;
    public GameObject paLabi;

    public void binaAttelosana(bool vertiba)
    {
        bins.SetActive(vertiba);
        paKreisi.GetComponent<Toggle>().interactable = vertiba;
        paLabi.GetComponent<Toggle>().interactable = vertiba;
    }

    public void lacaAttelosana(bool vertiba)
    {
        lacitis.SetActive(vertiba);
    }

    public void tantesAttelosana(bool vertiba)
    {
        tante.SetActive(vertiba);
    }

    public void masinasAttelosana(bool vertiba)
    {
        masina.SetActive(vertiba);
    }

    public void PaKreisiBins()
    {
        bins.transform.localScale = new Vector2(1, 1);
    }

    public void PaLabiBins()
    {
        bins.transform.localScale = new Vector2(-1, 1);
    }



}
