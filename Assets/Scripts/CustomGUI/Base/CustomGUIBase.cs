using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum E_Style_OnOff
{
    On,
    Off
}

public class CustomGUIBase : MonoBehaviour
{
    public CustomGUIPos guiPos;

    public GUIContent content;

    public GUIStyle style;

    public E_Style_OnOff styleOnOrOff = E_Style_OnOff.Off;

    public void DrawGUI()
    {
        switch (styleOnOrOff)
        {
            case E_Style_OnOff.On:
                StyleOnDraw();
                break;
            case E_Style_OnOff.Off:
                StyleOffDraw();
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }

    protected virtual void StyleOnDraw()
    {
        //GUI.Button(guiPos.Pos, content, style);
    }

    protected virtual void StyleOffDraw()
    {
        //GUI.Button(guiPos.Pos, content);
    }
}