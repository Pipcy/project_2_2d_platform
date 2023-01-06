//2.15

using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject completeLevelUI;

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true); //enable the winpage UI when win
    }
}
