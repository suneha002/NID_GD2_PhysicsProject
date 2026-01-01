
// using UnityEngine;

// public class GameManager : MonoBehaviour
// {
//    public static GameManager Instance;
//    public int score;
//    public int maxLives=5;
//    int currentLives;
//     // Start is called once before the first execution of Update after the MonoBehaviour is created
//     // void Awake()
//     // {
//     //     if(Instance== null)
//     //     {
//     //         Instance= this;
//     //     }
//     //     else
//     //     {
//     //         Destroy(gameObject);
//     //     }
//     //     currentLives= maxLives;
//     // }

//     // Update is called once per frame
//     public void BubbleHit()
//     {
//        score+=10;
//        Debug.Log("Score:" + score); 
//     }
//     public void CanHit()
//     {
//         currentLives--;
//         Debug.Log("Lives left:"+ currentLives);
//         if (currentLives <= 0)
//         {
//             GameOver();
//         }
//     }
//     void GameOver()
//     {
//         Debug.Log("GAME OVER");
//         Time.timeScale=0f;
//     }
// }
