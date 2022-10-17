using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportTrigger : MonoBehaviour
{
    [Tooltip("The point that the player will teleport back to when they touch the trigger.")]
    [SerializeField] private Transform teleport;

    private GameManager manager;
    
    /// <summary>
    /// Awake is called before start
    /// </summary>
    private void Awake()
    {
        manager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        //detects player
        if(other.CompareTag("Player") == true)
        {
            //player teleports to the position
            other.TryGetComponent(out Pacman pacman);
            pacman.TeleportToPoistion(teleport.position);
        }
    }
}
