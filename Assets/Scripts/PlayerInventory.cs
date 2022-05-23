using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerInventory : MonoBehaviour
{
    public int NumberOfUrns { get; set; }

    public AudioSource collectSound;

    public UnityEvent<PlayerInventory> OnUrnCollected;

    public void UrnCollected()
    {
        collectSound.Play();
        NumberOfUrns++;
        OnUrnCollected.Invoke(this);

        if (NumberOfUrns >= 10)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
   
    

}
