using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlappyBird : MonoBehaviour
{
    public Rigidbody2D rg;
    public float speed;
    public GameObject gameover;
    private void Start(){
        Time.timeScale=1;
        rg = GetComponent<Rigidbody2D>();
    }
    private void Update(){
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space)){
            rg.AddForce(Vector2.up*speed);
        }
    }
    public void resetGame(){
        SceneManager.LoadScene(0);
    }
    void GameOver(){
        Time.timeScale = 0;
        gameover.SetActive(true);
    }
    private void OnCollisionEnter2D(Collision2D collision) {
        GameOver();
    }
}
