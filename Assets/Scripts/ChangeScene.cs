using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    [SerializeField] private string PLAYER_TAG;

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag(PLAYER_TAG))
            SceneManager.LoadScene(1);
    }
}
