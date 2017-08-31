using UnityEngine;
using System.Collections;

public class Tile : MonoBehaviour
{
    public GameManager gameManager;
    public AudioClip hit;
    private AudioSource audioSource;

    // Use this for initialization
    void Start()
    {
        audioSource.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        gameManager.AddPointToScore();
        audioSource.PlayOneShot(hit);
    }
}
