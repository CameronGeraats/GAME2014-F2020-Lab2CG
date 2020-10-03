using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TestButtonBehaviour : MonoBehaviour
{
    public TMP_Text SceneLabel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTestButtonPressed()
    {
        SceneLabel.text = "Test";
    }
}
