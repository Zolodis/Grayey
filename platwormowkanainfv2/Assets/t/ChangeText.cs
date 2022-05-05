using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[DisallowMultipleComponent]
public class ChangeText : MonoBehaviour
{
    [SerializeField]Text textComponent;
    // Start is called before the first frame update
    void Start()
    {
        UpdateText(1000);
    }

    // Update is called once per frame
    public void UpdateText(int score)
    {
        textComponent.text = score.ToString();
    }
}
