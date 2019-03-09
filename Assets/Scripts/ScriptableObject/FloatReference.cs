using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class FloatRefrence
{
    public bool UseConstant = false;
    public float ConstantValue = 0f;
    public FloatVariable Variable;
    public float Value
    {
        get { return UseConstant ? ConstantValue : Variable.Value; }
    }
}
