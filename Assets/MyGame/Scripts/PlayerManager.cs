using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    // Start is called before the first frame update
    bool islapsCar;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            GameManager.Instace.SetCoinCar();
            Destroy(collision.gameObject);
        }
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Finish" && islapsCar == false)
        {
            GameManager.Instace.SetlabsCar();
            Debug.Log(GameManager.Instace.labsCar);
            islapsCar = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        Invoke("Reset", 1);
    }
    private void Reset()
    {
        islapsCar = false;
    }
}
