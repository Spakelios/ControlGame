using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimationController : MonoBehaviour
{
    public Button _button;
    public Image sprites;
  
    public void kellie()
    {
        sprites.color = Color.white;
      _button.interactable = true;
    }
    
    public void kellie2()
    {
        sprites.color = Color.black;
        _button.interactable = false;
    }
}
