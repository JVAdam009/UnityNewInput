//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/Input/BallInputAction.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @BallInputAction : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @BallInputAction()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""BallInputAction"",
    ""maps"": [
        {
            ""name"": ""Ball"",
            ""id"": ""9921cec4-d6ae-4050-84ef-eec85568963b"",
            ""actions"": [
                {
                    ""name"": ""Bounce"",
                    ""type"": ""Button"",
                    ""id"": ""0981d895-6316-4dfb-8cab-be015a136a4b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""09bb4386-efe1-46b4-89d6-ae0448283232"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": ""Hold(duration=1),Press(behavior=1),Tap"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Bounce"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Ball
        m_Ball = asset.FindActionMap("Ball", throwIfNotFound: true);
        m_Ball_Bounce = m_Ball.FindAction("Bounce", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Ball
    private readonly InputActionMap m_Ball;
    private IBallActions m_BallActionsCallbackInterface;
    private readonly InputAction m_Ball_Bounce;
    public struct BallActions
    {
        private @BallInputAction m_Wrapper;
        public BallActions(@BallInputAction wrapper) { m_Wrapper = wrapper; }
        public InputAction @Bounce => m_Wrapper.m_Ball_Bounce;
        public InputActionMap Get() { return m_Wrapper.m_Ball; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(BallActions set) { return set.Get(); }
        public void SetCallbacks(IBallActions instance)
        {
            if (m_Wrapper.m_BallActionsCallbackInterface != null)
            {
                @Bounce.started -= m_Wrapper.m_BallActionsCallbackInterface.OnBounce;
                @Bounce.performed -= m_Wrapper.m_BallActionsCallbackInterface.OnBounce;
                @Bounce.canceled -= m_Wrapper.m_BallActionsCallbackInterface.OnBounce;
            }
            m_Wrapper.m_BallActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Bounce.started += instance.OnBounce;
                @Bounce.performed += instance.OnBounce;
                @Bounce.canceled += instance.OnBounce;
            }
        }
    }
    public BallActions @Ball => new BallActions(this);
    public interface IBallActions
    {
        void OnBounce(InputAction.CallbackContext context);
    }
}
