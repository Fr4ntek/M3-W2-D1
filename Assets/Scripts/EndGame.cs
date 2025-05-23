using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    private int countPlayer = 0;
    private List<Player> players;

    private void Start()
    {
        players = new List<Player>();
        players.AddRange(FindObjectsOfType<Player>());
        Debug.Log($"Numero di Player presenti in scena: {players.Count}");
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            countPlayer++;
            Debug.Log($"{countPlayer} Player entrato");
        }
        if(countPlayer == players.Count)
        {
            Debug.Log("Tutti i player sono all'interno. Livello completato!");
        }
        
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            countPlayer--;
            Debug.Log("Player uscito");
        }
    }
}
