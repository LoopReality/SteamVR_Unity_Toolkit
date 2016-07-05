using UnityEngine;
using System.Collections;

public class UI_Interactions : MonoBehaviour
{
    public void Button_Red()
    {
        Debug.Log("Red Button Clicked");
    }

    public void Button_Pink()
    {
        Debug.Log("Pink Button Clicked");
    }

    public void Toggle(bool state)
    {
        Debug.Log("The toggle state is " + (state ? "on" : "off"));
    }

    public void Dropdown(int value)
    {
        Debug.Log("Dropdown option selected was ID " + value);
    }
}