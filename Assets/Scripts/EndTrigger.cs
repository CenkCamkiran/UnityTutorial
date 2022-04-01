using UnityEngine;

public class EndTrigger : MonoBehaviour
{

    public GameManager gameManager;

    void OnTriggerEnter(Collider other)
    {
        //FindObjectOfType<GameManager>().CompleteLevel();
        gameManager.CompleteLevel();
    }
}
