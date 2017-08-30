using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GeneralScript : MonoBehaviour {

	public GameObject[] target;
	public GameObject Marker;
	public GameObject TextBox;
	public GameObject GameOverPanel;
	public Rigidbody Enemy;
	public int EnemyCount = 0;
	public int MaxEnemyCount = 3;
	public int score;
	private float timer;
	public bool GameOver = false;

	void Start(){
		score = 0;
		InvokeRepeating("SpawnEnemy", 2.0f, 2.0f);
		timer = (int)Time.timeSinceLevelLoad;
	}

	void Update(){
		//Update Score
		if ((timer > 120 && score < 10) || (score > 30))
			GameOver = true;
		Text Text = TextBox.GetComponent<Text>();
		Text.text = "Score: " + score;
		Text Timer = GameObject.Find("Timer").GetComponent<Text>();
		Timer.text = "Time: " + timer;
		EnemyCount = GameObject.FindGameObjectsWithTag("Enemy").Length;
		timer = (int)Time.timeSinceLevelLoad;
		GameOverPanel.SetActive(GameOver);

	}

	public GameObject SelectTarget(){
		GameObject CurrentTarget = target[(int)Random.Range(0, target.Length)];
		return CurrentTarget;
	}

	void SpawnEnemy(){
		if (EnemyCount < MaxEnemyCount){
			Transform SpawnLocation = SelectTarget().transform;
			Rigidbody clone;
			clone = Instantiate(Enemy, SpawnLocation.position, SpawnLocation.rotation, Marker.transform) as Rigidbody;
		}
	}

	public void RestartButtonPressed(){
		GameOver = false;
		SceneManager.LoadScene("ProjectileGame");
	}


}
