using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Button : MonoBehaviour
{
    [SerializeField]
    Text _text;

    int _scroe = 0;
    public void OnBUttonClicked()
    {
        _scroe++;
        _text.text = $"점수 : {_scroe}";
    }
}
