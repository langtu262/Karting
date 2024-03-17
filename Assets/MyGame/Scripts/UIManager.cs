using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI; //thư viện cho hàm Text


public class UIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI m_TextPosition;
    [SerializeField] private TextMeshProUGUI m_TextLaps;
    [SerializeField] private TextMeshProUGUI m_TextCoin;
    [SerializeField] private TextMeshProUGUI m_TextKm;

    //[SerializeField] private Text MyText; // phai su dung lagecy Text
    void Start()
    {
        StartCoroutine(UpdateCar());
    }


    // Update is called once per frame
    IEnumerator UpdateCar()
    {
        while (true)
        {
            m_TextPosition.text = GameManager.Instace.positionCar.ToString();
            m_TextLaps.text = GameManager.Instace.labsCar.ToString();
            m_TextCoin.text = GameManager.Instace.coinCar.ToString();
            m_TextKm.text = GameManager.Instace.km.ToString();
            yield return new WaitForSeconds(0.2f);
        }
    }   
}
