using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;
using UnityEngine.Events;

[System.Serializable]
public class ShaderParameterFloat
{
    public Material targetMaterial;
    public string shaderParameterName;

    public UnityEvent onValueChange;

    [ShowInInspector, ShowIf("CanSetMaterialParameter")] 
    public float value 
    { 
        get 
        {
            return CanSetMaterialParameter() ? targetMaterial.GetFloat(shaderParameterName) : -9999;
        }
        set 
        {
            if (CanSetMaterialParameter())
            {
                onValueChange?.Invoke();
                targetMaterial?.SetFloat(shaderParameterName, value);
            }
        }
    }

    public ShaderParameterFloat(Material material, string shaderParameterName, float startingValue)
    {
        targetMaterial = material;
        this.shaderParameterName = shaderParameterName;
        value = startingValue;
    }

    private bool CanSetMaterialParameter()
    {
        return targetMaterial != null && targetMaterial.HasProperty(shaderParameterName);
    }
}

[System.Serializable]
public class ShaderParameterInt
{
    public Material targetMaterial;
    public string shaderParameterName;

    public UnityEvent onValueChange;

    [ShowInInspector, ShowIf("CanSetMaterialParameter")]
    public int value {
        get {
            return CanSetMaterialParameter() ? targetMaterial.GetInt(shaderParameterName) : -9999;
        }
        set {
            if (targetMaterial != null && targetMaterial.HasProperty(shaderParameterName))
            {
                onValueChange?.Invoke();
                targetMaterial?.SetInt(shaderParameterName, value);
            }
        }
    }

    public ShaderParameterInt(Material material, string shaderParameterName, int startingValue)
    {
        targetMaterial = material;
        this.shaderParameterName = shaderParameterName;
        value = startingValue;
    }

    private bool CanSetMaterialParameter()
    {
        return targetMaterial != null && targetMaterial.HasProperty(shaderParameterName);
    }
}

[System.Serializable]
public class ShaderParameterTexture
{
    public Material targetMaterial;
    public string shaderParameterName;

    public UnityEvent onValueChange;

    [ShowInInspector, ShowIf("CanSetMaterialParameter")]
    public Texture value {
        get {
            return CanSetMaterialParameter() ? targetMaterial.GetTexture(shaderParameterName) : null;
        }
        set {
            if (CanSetMaterialParameter())
            {
                onValueChange?.Invoke();
                targetMaterial?.SetTexture(shaderParameterName, value);
            }
        }
    }

    public ShaderParameterTexture(Material material, string shaderParameterName, Texture startingValue)
    {
        targetMaterial = material;
        this.shaderParameterName = shaderParameterName;
        value = startingValue;
    }

    private bool CanSetMaterialParameter()
    {
        return targetMaterial != null && targetMaterial.HasProperty(shaderParameterName);
    }
}

[System.Serializable]
public class ShaderParameterColor
{
    public Material targetMaterial;
    public string shaderParameterName;

    public UnityEvent onValueChange;

    [ShowInInspector, ShowIf("CanSetMaterialParameter")]
    public Color value {
        get {
            return CanSetMaterialParameter() ? targetMaterial.GetColor(shaderParameterName) : Color.clear;
        }
        set {
            if (CanSetMaterialParameter())
            {
                onValueChange?.Invoke();
                targetMaterial?.SetColor(shaderParameterName, value);
            }
        }
    }

    public ShaderParameterColor(Material material, string shaderParameterName, Color startingValue)
    {
        targetMaterial = material;
        this.shaderParameterName = shaderParameterName;
        value = startingValue;
    }

    private bool CanSetMaterialParameter() {
        return targetMaterial != null && targetMaterial.HasProperty(shaderParameterName);
    }

}