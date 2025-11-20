using UnityEngine;
using TMPro;

public class CatapultButton : MonoBehaviour
{
    [SerializeField] private Catapult _catapult;
    [SerializeField] private TMP_Text _buttonText;
    
    public void OnButtonClick()
    {
        _catapult.OnButtonClick();
        UpdateButtonText();
    }
    
    private void UpdateButtonText()
    {
        _buttonText.text = _catapult.IsLoaded ? "Метнуть снаряд!" : "Перезарядить!";
    }
}