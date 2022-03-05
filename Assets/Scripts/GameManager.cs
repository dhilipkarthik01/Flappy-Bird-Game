using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private int score;
    public Text scoreText;
    public GameObject playButton, gameOver;
    public Player player;
    public AudioSource audioSource;

    public void Awake(){
        Application.targetFrameRate = 60;
        Pause();
    }

    public void Start(){
        gameOver.SetActive(false);
    }

    public void Play(){
        score = 0;
        audioSource.Play();
        scoreText.text = score.ToString();
        playButton.SetActive(false);
        Time.timeScale = 1f;
        player.enabled = true;
        gameOver.SetActive(false);

        Pipes[] pipes = FindObjectsOfType<Pipes>();
        for(int i=0;i<pipes.Length;i++){
            Destroy(pipes[i].gameObject);
        }
    }
    public void Pause(){
        audioSource.Pause();
        Time.timeScale = 0f;
        player.enabled=false;
    }


    public void GameOver(){
        audioSource.Pause();
        gameOver.SetActive(true);
        playButton.SetActive(true);
        Pause();
    }


    public void IncreaseScore(int points = 1){
         score+=points;
         scoreText.text = score.ToString();
        
    }

    
}
