using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour
{

    public GameObject Explosion;
    public GameObject PlayerExplosion;
    public int ScoreValue;
    private GameController _gameController;

    private void Start()
    {
        var gameControllerObject = GameObject.FindWithTag("GameController");
        if (gameControllerObject != null)
        {
            _gameController = gameControllerObject.GetComponent<GameController>();
        }
        if (gameControllerObject == null)
        {
            Debug.Log("Cannot find 'GameController' script");
        }
    }


    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Boundary"))
        {
            return;
        }
        Instantiate(Explosion, transform.position, transform.rotation);
        if (other.CompareTag("Player"))
        {
            Instantiate(PlayerExplosion, other.transform.position, other.transform.rotation);

            _gameController.GameOver();
            

        }
        Destroy(other.gameObject);
        Destroy(gameObject);
        _gameController.AddScore(ScoreValue);

    }
}
