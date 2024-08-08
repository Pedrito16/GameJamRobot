using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InputPass : MonoBehaviour
{
    public GameObject buttonpass;
    public GameObject inputpass;
    public GameObject doorPassWord;
    public InputField passwordInputField;
    public Text messageText;

    // Defina a senha correta aqui
    private string correctPassword = "965"; // Alterar conforme necessário

    void Start()
    {
        // Adiciona um listener ao botão de envio

        // Inicializa a mensagem de texto
        messageText.text = "";
    }

    public void OnSubmit()
    {
        string enteredPassword = passwordInputField.text;

        if (enteredPassword == correctPassword)
        {
            PerformAction();
        }
        else
        {
            // Mensagem quando a senha está errada
            passwordInputField.text = "";
            messageText.text = "Error, Tente Novamente";
        }
    }

    void PerformAction()
    {
        Destroy(doorPassWord);
        Destroy(buttonpass);
        Destroy(inputpass);
        messageText.text = "Acesso Confirmado";
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(passwordInputField.text != correctPassword)
        {
            buttonpass.SetActive(true);
            inputpass.SetActive(true);
        }
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(passwordInputField.text != correctPassword)
        {
            buttonpass.SetActive(false);
            inputpass.SetActive(false);
            messageText.text = "";
        }
    }
}
