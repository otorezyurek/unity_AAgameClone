using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
	bool isGameOver;

	public Spinner spinner;
	public Spawner spawner;

	public Animator animator;

	public Text scoreText;
	public Button playAgainButton;
	int score;
	public void GameEnd()
	{
		if (isGameOver == true)
		{
			return;
		}

		spinner.enabled = false;
		spawner.enabled = false;

		animator.SetTrigger("GameOver");

		isGameOver = true;

		playAgainButton.gameObject.SetActive(true);

        print("GAME END");
	}

	public void Restart()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}

	public void ScoreCounter()
	{
		if(isGameOver == false) 
		{
			score += 1;
			scoreText.text = score.ToString();
		}
		
	}
}
