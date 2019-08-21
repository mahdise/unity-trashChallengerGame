using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class CoundownTimer : MonoBehaviour
{
   public static float currentTime = 1000f;
    public static float stratingTime = 0f;
    //public static float startingTime2 = 500f;

  


    [SerializeField] Text countdownText;


    void strat()
    {

      
        
     
        
            currentTime = stratingTime;

                
      

    }
   void Update()
    {
        
            currentTime -= 10 * Time.deltaTime;
        
   

        


        countdownText.text = currentTime.ToString("0");

        if (currentTime <= 0)
        {

            currentTime = 0;
            GameOver();

        }
       

           else if (Input.GetKey(KeyCode.M))
        {

            currentTime += 2000 * Time.deltaTime;

        }

            void GameOver()
        {


            Cursor.visible = true;
            Screen.lockCursor = false;
            SceneManager.LoadScene("gameOver_Scene");


        }
    }
}
