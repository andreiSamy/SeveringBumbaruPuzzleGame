using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerKill : MonoBehaviour
{

    [SerializeField] private Transform player;
    public int Respawn;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) { 
        
            SceneManager.LoadScene(Respawn);
        Debug.Log("Amasdasd");
        }
    }

}
