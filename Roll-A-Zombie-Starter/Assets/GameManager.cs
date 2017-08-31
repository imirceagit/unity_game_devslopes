using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	public GameObject selectedZombie;
	public List<GameObject> zombies;
	public Vector3 defaultSize;
	public Vector3 selectedSize;
    public Text scoreText;

	private int zombiePosition = 0;
    private int score = 0;

	// Use this for initialization
	void Start () {
        SelectZombie(zombiePosition);
        scoreText.text = "Score: " + score;
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown ("left"))
			LeftKeyPressed ();
		if (Input.GetKeyDown ("right"))
			RightKeyPressed ();
		if (Input.GetKeyDown ("up"))
			UpKeyPressed ();
	}



	void SelectZombie(int position) {
		selectedZombie.transform.localScale = defaultSize;
		zombiePosition = position;
		selectedZombie = zombies [zombiePosition];
		selectedZombie.transform.localScale = selectedSize;
	}

	void LeftKeyPressed() {
		SelectLeftZombie ();
	}

	void RightKeyPressed() {
		SelectRightZombie ();
	}

	void UpKeyPressed () {
        PushZombieUp();
	}

	void SelectLeftZombie() {
		if (zombiePosition == 0)
			SelectZombie (3);
		else
			SelectZombie (--zombiePosition);
	}

	void SelectRightZombie() {
		if (zombiePosition == 3)
			SelectZombie (0);
		else
			SelectZombie (++zombiePosition);
	}

    void PushZombieUp()
    {
        Rigidbody rigidbody = selectedZombie.GetComponent<Rigidbody>();
        rigidbody.AddForce(0, 0, 10, ForceMode.Impulse);
    }

    public void AddPointToScore()
    {
        score++;
        scoreText.text = "Score: " + score;
    }
}
