using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] TMPro.TextMeshProUGUI scoreText;
    [SerializeField] float restartDelay; 

    private bool gameHasEnded = false; 

    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = player.position.z.ToString("0"); 
    }

    public void EndGame()
    {
        if(!gameHasEnded)
        {
            gameHasEnded = true;

            Invoke("Restart", restartDelay); 
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
