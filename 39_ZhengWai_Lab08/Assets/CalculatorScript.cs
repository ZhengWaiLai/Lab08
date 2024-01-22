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
    public Toggle toggleRM;
    public Toggle toggleEUR;
    public Toggle toggleKRW;
    public Toggle toggleTWD;
    public InputField Amount;
    public float amount = 0f;
    public float SGDUSD_rate = 0.75f;
    public float SGDJPY_rate = 82.78f;
    public float SGDRM_rate = 3.08f;
    public float SGDEUR_rate = 0.63f;
    public float SGDKRW_rate = 881.54f;
    public float SGDTWD_rate = 20.73f;
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
        try
        {
            float amount = float.Parse(Amount.text);
            if (toggleUSD.isOn == true)
            {
                outputConvertedAmount.text = "$" + (amount * SGDUSD_rate);
            }
            else if (toggleJPY.isOn == true)
            {
                outputConvertedAmount.text = "¥" + (amount * SGDJPY_rate);
            }
            else if (toggleRM.isOn == true)
            {
                outputConvertedAmount.text = "RM" + (amount * SGDRM_rate);
            }
            else if (toggleEUR.isOn == true)
            {
                outputConvertedAmount.text = "¥" + (amount * SGDEUR_rate);
            }
            else if (toggleKRW.isOn == true)
            {
                outputConvertedAmount.text = "¥" + (amount * SGDKRW_rate);
            }
        }
        catch(System.FormatException)
        {
            DebuggingText.text = "Please Enter Valid Amount";
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
