﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DeadZone : MonoBehaviour {

  public Text scorePlayerText;
  public Text scoreEnemyText;

  int scorePlayerQuantity;
  int scoreEnemyQuantity;

  private void OnTriggerEnter2D (Collider2D collision){
    if (gameObject.tag == "Left") {
      scoreEnemyQuantity++;
      UpdateScoreLabel(scoreEnemyText, scoreEnemyQuantity);
    } else if (gameObject.tag == "Right") {
      scorePlayerQuantity++;
      UpdateScoreLabel(scorePlayerText, scorePlayerQuantity);      
    }
  }

  void UpdateScoreLabel(Text label, int score) {
    label.text = score.ToString();
  }
}
