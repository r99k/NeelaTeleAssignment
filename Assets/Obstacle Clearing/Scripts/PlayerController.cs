using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
      private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("obs1") || other.gameObject.CompareTag("obs2"))
        {
            Debug.Log("Gameover");
            GameManager.I.GameOverPanel.SetActive(true);
            GameManager.I.InGamePanel.SetActive(false);
            Helper.GameOver = true;
        }
    }
}
