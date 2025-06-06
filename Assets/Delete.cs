using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteBall : MonoBehaviour {

  private Rigidbody rig;

  // Use this for initialization
  void Start () {
    rig = this.GetComponent<Rigidbody>();
  }
  
  // Update is called once per frame
  void Update () {

  }

  void OnCollisionEnter(Collision collision) {
    if (collision.gameObject.tag != "Bat") {
      //Destroy(gameObject);
      rig.velocity = Vector3.zero; 
      rig.angularVelocity = Vector3.zero;
      transform.position = new Vector3(-38.97f, 0.68f, 5.39f);
      ShootBall.shootSwitch = true;    
    }
  }
}