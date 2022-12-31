using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IconSelect : MonoBehaviour
{
    public GameObject[] classIcons;
    public int selectedIcon = 0;

    public void NextIcon()
    {
        classIcons[selectedIcon].SetActive(false);
        selectedIcon = (selectedIcon +1) % classIcons.Length;
        classIcons[selectedIcon].SetActive(true);
    }

    public void PreviousIcon()
    {
        classIcons[selectedIcon].SetActive(false);
        selectedIcon--;
        if(selectedIcon < 0)
        {
            selectedIcon += classIcons.Length;
        }
        classIcons[selectedIcon].SetActive(true);
    }

    public void StartGame()
    {
        PlayerPrefs.SetInt("selectedIcon", selectedIcon);
        SceneManager.LoadScene(1, LoadSceneMode.Single);
    }

}
