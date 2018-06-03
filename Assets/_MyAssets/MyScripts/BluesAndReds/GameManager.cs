using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class GameManager : MonoBehaviour 
{

	public int TBalls = 4;
	private int nBallsRed=0;
	private int nBallsBlue=0;

	public GameObject Trigger1;
	public GameObject Trigger2;
	public GameObject Hole;

	public float resetDelay = 1f;
	public Text scoreB;
	public Text scoreR;
	public Text Level;
	//public GameObject gameOver;
	public GameObject youWon;

	public static GameManager instance = null;

	//public int level = 1;
	// Use this for initialization
	void Awake () 
	{

		if (instance == null)
		{
			//DontDestroyOnLoad(gameObject);
			instance = this;
		}
		else if (instance != this)
			Destroy (gameObject);
		//Sets this to not be destroyed when reloading scene


	}

	//This is called each time a scene is loaded.
	void OnLevelWasLoaded(int index)
	{
		//Add one to our level number.
//		level++;
//		Debug.Log("level" +level);
		TBalls = PlayerPrefs.GetInt("TBalls");
		Debug.Log("TBalls" +TBalls);
		Level.text = "Level: " + (TBalls/2);

		//Call InitGame to initialize our level.
		//InitGame();
	}


	public void Reset()
	{
		Time.timeScale = 1f;
		Application.LoadLevel(Application.loadedLevel);
		PlayerPrefs.SetInt("TBalls", TBalls);


	}

	void CheckGameOver()
	{
		scoreR.text = "Red: " + nBallsRed;
		scoreB.text = "Blue: " + nBallsBlue;
		if (nBallsBlue == TBalls/2 && nBallsRed == TBalls/2 )
		{
			Hole.SetActive(true);
			youWon.SetActive(true);
			Time.timeScale = .25f;
			TBalls = TBalls+2;

			Invoke ("Reset", resetDelay);

		}
	}

	public void AddRedBall()
	{
		nBallsRed++;
		CheckGameOver();
	}

	public void SubRedBall()
	{
		nBallsRed--;
		CheckGameOver();
	}

	public void AddBlueBall()
	{
		nBallsBlue++;
		CheckGameOver();
	}

	public void SubBlueBall()
	{
		nBallsBlue--;
		CheckGameOver();
	}





}
