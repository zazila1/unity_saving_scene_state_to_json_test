﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIDropdown : MonoBehaviour
{
    [SerializeField] private Dropdown _Dropdown;
    [SerializeField] private JsonSerializationController _JsonSerializationController;
    
    
    
    void Start()
    {
        _JsonSerializationController.OnSetsUpdate += UpdateList;
        
        //_Dropdown.onValueChanged.AddListener(S);
    }

    private void UpdateList(List<int> ids)
    {
        _Dropdown.options.Clear();

        foreach (var id in ids)
        {
            _Dropdown.options.Add(new Dropdown.OptionData(id.ToString()));
        }
    }
    
    
}
