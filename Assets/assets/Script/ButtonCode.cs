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
        SceneManager.LoadScene(2);//yeni sahne y�kler
    }

    public void NickBtn(bool isTrue) //butona t�klad���nda 2. paneli a�ar
    {
        string name;
        name = nickname.text;
        Nick.text = name; //inputtan girilen de�eri texte atar (bunu kullan�c ad� olarak kaydetmemiz gerekiyor)
        
        if (isTrue)
        {
            Panelgame.gameObject.SetActive(false);
            
        }

        
       
    }
}