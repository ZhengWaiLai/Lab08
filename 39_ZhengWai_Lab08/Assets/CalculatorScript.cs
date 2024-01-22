using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CalculatorScript : MonoBehaviour
{
    public InputField outputConvertedAmount;
    public Text DebuggingText;
    public Toggle toggleUSD;
    public Toggle toggleJPY;
    public InputField Amount;
    public float amount = 0f;
    public float SGDUSD_rate = 0.75f;
    public float SGDJPY_rate = 82.78f;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void Converted()
    {
        float amount = float.Parse(Amount.text);
        if (toggleUSD.isOn == true && toggleJPY.isOn == false)
        {
            outputConvertedAmount.text = "$" + (amount * SGDUSD_rate);
        }
        else if (toggleJPY.isOn == true && toggleUSD.isOn == false)
        {
            outputConvertedAmount.text = "¥" + (amount * SGDJPY_rate);
        }
        else if (toggleJPY.isOn == true && toggleUSD.isOn == true)
        {
            DebuggingText.text = "please select only one currency";
        }
    }

    public void Clear()
    {
        outputConvertedAmount.text = "";
        Amount.text = "";
        toggleUSD.isOn = false;
        toggleJPY.isOn = false;
    }
}
