using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class HealthbarUI : MonoBehaviour
{
    [SerializeField] private Image fill;
    [SerializeField] private TextMeshProUGUI lifeText;
    [SerializeField] private Gradient grad;

    public void UpdateGraphics(float currentHp, float maxHp)
    {
        lifeText.text = $"HP: {currentHp} / {maxHp}"; 
        fill.fillAmount = currentHp / maxHp;
        fill.color = grad.Evaluate(currentHp / maxHp);
    }
}
