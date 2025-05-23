using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    private GameObject[] players;

    private void Start()
    {
        players = GetComponentsInChildren<GameObject>();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            Debug.Log("Livello completato!");
        }
        
    }
}
