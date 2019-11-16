using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public float Slowness = 5f;


    bool gameHasEnd = false;

    public GameObject gameOverUI;

    public void EndGame() {

        if (gameHasEnd ==false)
        {
            gameHasEnd = true;
            StartCoroutine(RestartLevel());
            gameOverUI.SetActive(true);

            


            Debug.Log("EndGame");
            //Application.Quit();

       
        }
        
        
        
    }

    IEnumerator RestartLevel() {
        //before 1 seg
        Time.timeScale = 1 / Slowness;
        Time.fixedDeltaTime = Time.fixedDeltaTime / Slowness;

        yield return new WaitForSeconds(5f/Slowness);

        Time.timeScale = 1;
        Time.fixedDeltaTime = Time.fixedDeltaTime * Slowness;


        //after 1 seg
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);

    }
}
