using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveLevel : MonoBehaviour
{
    public int sceneIndex;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            SceneManager.LoadScene(sceneIndex, LoadSceneMode.Single);
        }
    }
}
