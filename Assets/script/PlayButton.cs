using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
   public void PlayGames()
    {
        Debug.Log("Playgame was pressed");
        SceneManager.LoadScene("Game");
    }
}
