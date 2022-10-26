using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TowerSizeView : MonoBehaviour
{
    [SerializeField] private TMP_Text _sizeView;
    [SerializeField] private Tower _tower;

    private void OnEnable()
    {
        _tower.SizeUpdated += OnSizeUpdeted;
    }

    private void OnDisable()
    {
        _tower.SizeUpdated -= OnSizeUpdeted;
    }

    private void OnSizeUpdeted(int size)
    {
        _sizeView.text = size.ToString();
    }
}
