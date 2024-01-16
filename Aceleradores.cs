using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aceleradores : MonoBehaviour
{
    public float aceleracion = 2.5f;

    private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<FirstPersonMovement>().runSpeed *= aceleracion;
    }
    private void OnTriggerExit(Collider other)
    {
        other.GetComponent<FirstPersonMovement>().runSpeed /= aceleracion;
    }
}
