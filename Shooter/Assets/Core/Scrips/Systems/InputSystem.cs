using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;

public class InputSystem : IInitializeSystem, IExecuteSystem
{
    readonly InputContext m_context;
    private InputEntity m_userInput;

    public InputSystem(Contexts context)
    {
        m_context = context.input;
    }

    public void Execute()
    {
        #region 键盘输入
        float tmp_Hor = Input.GetAxis("Horizontal");
        float tmp_Ver = Input.GetAxis("Vertical");
        m_userInput.ReplaceKeyDirection(new Vector2(tmp_Hor, tmp_Ver));
        #endregion

        #region 鼠标滑动输入
        float tmp_mouseX = Input.GetAxis("Mouse X");
        float tmp_mouseY = Input.GetAxis("Mouse Y");
        m_userInput.ReplaceMouseDirection(new Vector2(tmp_mouseX, tmp_mouseY));
        #endregion

        #region 鼠标点击输入
        if (Input.GetMouseButtonDown(0))
            m_userInput.ReplaceMouseLeftInput(true);
        if (Input.GetMouseButtonUp(0))
            m_userInput.ReplaceMouseLeftInput(false);

        if (Input.GetMouseButtonDown(1))
            m_userInput.ReplaceMouseRightInput(true);
        if (Input.GetMouseButtonUp(1))
            m_userInput.ReplaceMouseRightInput(false);
        #endregion

    }

    public void Initialize()
    {
        m_context.isUserInput = true;
        m_userInput = m_context.userInputEntity;
    }
}
