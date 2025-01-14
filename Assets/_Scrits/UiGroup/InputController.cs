using UnityEngine;
using TMPro;

public class InputController : MonoBehaviour


{
    public TextMeshProUGUI output;
    public TMP_InputField input;


    void Update()
    {
        output.text = input.text;
    }
}
