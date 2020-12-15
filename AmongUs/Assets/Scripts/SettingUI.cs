using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingUI : MonoBehaviour
{
    [SerializeField]
    private Button MouseControlButton;
    [SerializeField]
    private Button KeyboardMouseButton;

    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void OnEnable()
    {
        switch (PlayerSettings.controlType)
        {
            case EControlType.Mouse:
                MouseControlButton.image.color = Color.green;
                KeyboardMouseButton.image.color = Color.white;
                break;
            case EControlType.KeyBoardMouse:
                MouseControlButton.image.color = Color.white;
                KeyboardMouseButton.image.color = Color.green;
                break;
        }
    }

    public void SetControlMode(int controlType)
    {
        PlayerSettings.controlType = (EControlType)controlType;
        switch (PlayerSettings.controlType)
        {
            case EControlType.Mouse:
                MouseControlButton.image.color = Color.green;
                KeyboardMouseButton.image.color = Color.white;
                break;

            case EControlType.KeyBoardMouse:
                MouseControlButton.image.color = Color.white;
                KeyboardMouseButton.image.color = Color.green;
                break;
        }
    }

    public void Close()
    {
        StartCoroutine(closeAfterDelay());
    }

    private IEnumerator closeAfterDelay()
    {
        animator.SetTrigger("close");
        yield return new WaitForSeconds(0.5f);
        gameObject.SetActive(false);
        animator.ResetTrigger("close");
    }

}
