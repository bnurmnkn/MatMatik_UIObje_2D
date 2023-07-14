using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Kod : MonoBehaviour
{
    
    //public int sonuc;
  
    public TMP_InputField InputField1;
    public TMP_InputField InputField2;
    public TextMeshProUGUI sonucText;
    public TextMeshProUGUI sonuchata;
    

    void Start()
    {
        InputField1.onValidateInput += ValidateNumericInput;
        InputField2.onValidateInput += ValidateNumericInput;
    }

    
    void Update()
    {
        
    }
    private char ValidateNumericInput(string text, int charIndex, char addedChar)
    {
        if (!char.IsDigit(addedChar))
        {
            addedChar = '\0';
            sonuchata.text="!!!Harf Girilmez!!!";
        }
        return addedChar;
    }

    
    public void butTopla()
    {
      float sayi1=float.Parse(InputField1.text);
      float sayi2=float.Parse(InputField2.text);
      sonucText.text=(sayi1+sayi2).ToString();

    }
    public void butCikar()
    {
      float sayi1=float.Parse(InputField1.text);
      float sayi2=float.Parse(InputField2.text);
      sonucText.text=(sayi1-sayi2).ToString();
    }
    public void butCarp()
    {
      float sayi1=float.Parse(InputField1.text);
      float sayi2=float.Parse(InputField2.text);
      sonucText.text=(sayi1*sayi2).ToString();
    }
    public void butBol()
    {
      float sayi1=float.Parse(InputField1.text);
      float sayi2=float.Parse(InputField2.text);
      if(sayi2 == 0)
      {
        sonuchata.text="Paydaya 0 Yazilmaz!";
      }
      sonucText.text=(sayi1/sayi2).ToString();
      
    }
    public void buttemizle()
    {
      InputField1.text = "";
      InputField2.text = "";
      sonucText.text="";
      sonuchata.text="";
      //errorMessageText.text = string.Empty;

    }
}
