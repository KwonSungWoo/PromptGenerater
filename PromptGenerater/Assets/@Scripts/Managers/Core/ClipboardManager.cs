using UnityEngine;
using UnityEngine.UI;

public class ClipboardManager : MonoBehaviour
{
    public InputField inputField;

    void Update()
    {
#if UNITY_WEBGL
        // Ctrl + V 키 입력을 감지
        if (Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl))
        {
            if (Input.GetKeyDown(KeyCode.V))
            {
                PasteText(); // PasteText 메서드 호출
            }
        }
#endif
    }

    public void CopyText()
    {
#if UNITY_WEBGL
        string textToCopy = inputField.text;
        Application.ExternalCall("CopyToClipboard", textToCopy);
#endif
    }

    public void PasteText()
    {
#if UNITY_WEBGL
        Application.ExternalCall("PasteFromClipboard", gameObject.name);
#endif
    }

    // JavaScript에서 호출하는 함수
    public void OnPasteFromClipboard(string pastedText)
    {
        inputField.text = pastedText;
    }
}
