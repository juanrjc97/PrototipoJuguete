
using UnityEngine;
using UnityEngine.UI; //permite escribir codigo para la interfaz de usuario

public class Score : MonoBehaviour
{
    public Transform player;

    public Text ScoreText;

     
    // Update is called once per frame
    void Update()
    {
        
        
        ScoreText.text = Time.timeSinceLevelLoad.ToString("0" + "s");

        //Time.time.ToString("0"+ "s");  con esto se mide cuanto tiempo ha pasado desde el inicio del juego 
    }
}
