using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public int positionCar;
    public int labsCar;
    public int coinCar;
    public float km;
    private static GameManager _instace;
    public static GameManager Instace
    {
        get { return _instace; }
        set { _instace = value; }
    }

    void Start()
    {
        _instace = this;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetCoinCar()
    {
        coinCar += 5;
    }
    public void SetlabsCar()
    {
        labsCar += 1;
    }
}
