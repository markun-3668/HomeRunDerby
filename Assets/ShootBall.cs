using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShootBall : MonoBehaviour {

  private float timer = 0.0f;
  private float timeLimit = 1.0f;
  public static bool  shootSwitch;
  public int score = 0;
  public Text scoreText;
  public Text clearText;


  // Use this for initialization
  void Start () {
    shootSwitch = true;
    score = 0;
    scoreText.text = "0";
    clearText.text = "";
  }
  
  // Update is called once per frame
  void Update () {
      if(shootSwitch) {
        timer += Time.deltaTime;
      }

      if((timer > timeLimit) & shootSwitch) {
        clearText.text = "";
        float z = 140; // force strength;
        Rigidbody rigidbody = GetComponent<Rigidbody>();
        rigidbody.AddForce(-z, 0, 22);

        timer = 0.0f;
        shootSwitch = false;
      }

      if(score == 10) {
          shootSwitch = false;
          clearText.text = "Clear!!!!";
      }
  }
  void OnCollisionEnter(Collision collision) {
      if (collision.gameObject.tag == "Wall") {
        clearText.text = "Home Run!";
        score += 1;
        scoreText.text = "" + score.ToString();
      }
    } 
}