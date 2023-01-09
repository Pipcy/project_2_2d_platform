//2.15

using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;
    public bool win = false;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
            win = true;
            gameManager.CompleteLevel();
            
            

            
    }

}
