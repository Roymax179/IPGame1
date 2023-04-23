using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class Winner : MonoBehaviour
{
    // Start is called before the first frame update
     protected void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
            SceneManager.LoadScene("MainMenu");
    }
}
