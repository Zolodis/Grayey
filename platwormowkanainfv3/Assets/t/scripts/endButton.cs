using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class endButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("Button").GetComponentInChildren<Text>().text = "Gratulacje, jeszcze raz?";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            LoadNextLevel();
        }
    }

    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
