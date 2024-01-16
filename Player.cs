using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Player : MonoBehaviour
{
    //Vida del jugador
    private int vida = 10;

    public GameObject fireballPrefab;

    public Transform attackPoint;
    public void RecibirDano(int dano)
    {
       vida -= dano;
        print("La vida es: " + vida);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(fireballPrefab,
      attackPoint.
      position, attackPoint.
      rotation);
        }
    }
}
