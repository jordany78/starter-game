using UnityEngine;

public class endTrigger : MonoBehaviour
{
    public GameManager1 gameManager;

    void OnTriggerEnter ()
    {
        gameManager.CompleteLevel();
    }
}
