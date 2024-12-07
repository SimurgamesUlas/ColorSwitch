using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{
    public float jumpForce;
    public Rigidbody2D rb; 
    public string currentColor;
    public Color ColorGreen;
    public Color ColorYellow;
    public Color ColorBlue;
    public Color ColorPink;

    public SpriteRenderer sr;
    public int star;
    public TextMeshProUGUI StarText;
    void Start(){

       RandomColor(); 
    }
    void OnTriggerEnter2D(Collider2D col){
        if(col.tag == "Star"){
            star++;
            StarText.text = star.ToString();
            Destroy(col.gameObject);
            return;
        }
        if(col.tag == "ColorChanger"){
            RandomColor();
            Destroy(col.gameObject);
            return;
        }
        if(col.tag != currentColor){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

  
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0) || Input.touchCount > 0){
            rb.velocity = Vector2.up * jumpForce;

        }
    }
      void RandomColor(){
        int  index = UnityEngine.Random.Range(0,4);
        switch(index){
            case 0: currentColor = "Green";
            sr.color = ColorGreen;
                break;
            case 1: currentColor = "Yellow";
            sr.color = ColorYellow;
                break;
            case 2: currentColor = "Blue";
            sr.color = ColorBlue;
                break;
            case 3: currentColor = "Pink";
            sr.color = ColorPink;
                break;


        }
    }
}
