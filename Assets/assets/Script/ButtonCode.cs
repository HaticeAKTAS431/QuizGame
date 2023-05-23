using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class ButtonCode : MonoBehaviour
{
    public GameObject Panelgame;
    public GameObject PanelGame1;

    public InputField nickname;
    public Text Nick;

    public void NextScene()
    {
        SceneManager.LoadScene(2);//yeni sahne yükler
    }

    public void NickBtn(bool isTrue) //butona týkladýðýnda 2. paneli açar
    {
        string name;
        name = nickname.text;
        Nick.text = name; //inputtan girilen deðeri texte atar (bunu kullanýc adý olarak kaydetmemiz gerekiyor)
        
        if (isTrue)
        {
            Panelgame.gameObject.SetActive(false);
            
        }

        
       
    }
}