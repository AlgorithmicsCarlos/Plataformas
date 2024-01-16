using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    private float velocidad = 2.5f;
    public Transform objetivo;
    public int danoJugador = 2;
    public GameObject fireball;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Cambia el objetivo cada frame
        transform.position = Vector3.MoveTowards(transform.position, objetivo.position, velocidad * Time.deltaTime);
        //Gira al enemigo hacia el jugador
        transform.LookAt(objetivo.position);
    }
    //Hacer daño al jugador al tocarlo
    private void OnTriggerEnter(Collider other)
    {
        Player player = other.GetComponent<Player>();
        player.RecibirDano(danoJugador);
    }
}
