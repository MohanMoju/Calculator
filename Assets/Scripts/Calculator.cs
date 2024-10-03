
using System;
using System.Diagnostics;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using Debug = UnityEngine.Debug;


public class Calculator : MonoBehaviour
{
   
    public TextMeshProUGUI InputText;
    private float _result;
    private float _input1;
    private float _input2;
    private string _operation;
    private string _currentInput;
    private bool _equalIsPressed;



    public void Clicknumber(int val)
    {
      Debug.Log($" check val: {val}");
        if (!string.IsNullOrEmpty(_currentInput))
        {
            if(_currentInput.Length < 10)
            {
                _currentInput += val;
            }
        }
        else 
        {
            _currentInput = val.ToString(); 
        }
         InputText.text=$"{_currentInput}";


    }
    public void ClickOperation(string val)
    {
        Debug.Log($"ClickOperation val: {val}");
        if(_input1==0)
        {
            SetCurrentinput();
            _operation = val;
        }
        else
         {
            if(_equalIsPressed)
            {
                _equalIsPressed = false;
               _operation = val;
               _input2 = 0;

            }
            else
            {
                if (_operation.Equals(val,StringComparison.OrdinalIgnoreCase))
                {
                    Calculate();
                }
                else
                {
                    _operation = val;
                    _input2 = 0;
                }
            }
         }
         

    }
    public void ClickEqual(String val)
    {
        Debug.Log($" ClickEqual val: {val}");
        Calculate();
        _equalIsPressed = true;
    }
    private void Calculate()
    {
        if (_input1 != 0 && !string.IsNullOrEmpty(_operation))
        {
            SetCurrentinput();
            switch(_operation)
            {
             case "+":
                _result =_input1 + _input2;
                break;
            case "-":
                _result =_input1 - _input2;
                break;
            case "*":
                _result =_input1 * _input2;
                break;
            case "/":
                _result =_input1 / _input2;
                break;

            }
            InputText.SetText(_result.ToString());
            _input1 = _result;
        }
    }

    private void SetCurrentinput()
    {
      if(!string.IsNullOrEmpty(_currentInput))
      {
        if(_input1==0)
        {
            _input1 =int.Parse(_currentInput);
        }
        else
        {
            _input2 =int.Parse(_currentInput);
        }
        _currentInput = "";
      }
    }
    public void ClearInput()
    {
        _currentInput="";
        _input1=0;
        _input2=0;
        _result=0;
        InputText.SetText("");
    }

    public void Exit()
    {
        SceneManager.LoadScene(0);
    }
}    

    
    // public TMP_Dropdown mydropdown;
    // public TextMeshProUGUI textMeshPro;


    // public void Mohan(int val)
    // {
    //   if (val == 0) {
    //         textMeshPro.text = "Subtract";
    //     }
    //     if (val == 1)
    //     {
    //         textMeshPro.text = "Addition";
    //     }
    //     if (val == 2)
    //     {
    //         textMeshPro.text = "Multiply";
    //     }








    //private float _result;


    //public void Clicknumber(int val)
    //  {

    //  }

