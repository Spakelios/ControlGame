// GENERATED AUTOMATICALLY FROM 'Assets/Jo Stuff/Scripts/Taiko Drum Test.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @TaikoDrumTest : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @TaikoDrumTest()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Taiko Drum Test"",
    ""maps"": [
        {
            ""name"": ""Drum"",
            ""id"": ""78f617e7-2d6e-4e6b-862d-7e78da2af7ac"",
            ""actions"": [
                {
                    ""name"": ""Left Face"",
                    ""type"": ""Button"",
                    ""id"": ""d0257cc2-4d43-429b-b0d1-78045c5210d0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Right Face"",
                    ""type"": ""Button"",
                    ""id"": ""da49963c-c9e6-4e95-b9e6-21f3620007ae"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Left Rim"",
                    ""type"": ""Button"",
                    ""id"": ""2044264b-fac5-457b-891c-2ea18ed66b4e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Right Rim"",
                    ""type"": ""Button"",
                    ""id"": ""3f57dd13-73c0-448a-a1d2-e2dece87f502"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""a7eae793-6e01-4fa2-9338-67484f5975b6"",
                    ""path"": ""<HID::HORI CO.,LTD. Taiko Controller>/button11"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left Face"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0998bfae-1145-4153-9cb1-4bfdf15fbb07"",
                    ""path"": ""<HID::HORI CO.,LTD. Taiko Controller>/button12"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right Face"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fcd84621-8f16-4dc7-86d2-ae38deab025f"",
                    ""path"": ""<HID::HORI CO.,LTD. Taiko Controller>/button7"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left Rim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""76dcee50-614d-4631-b25b-863c28507e98"",
                    ""path"": ""<HID::HORI CO.,LTD. Taiko Controller>/button8"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right Rim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Drum
        m_Drum = asset.FindActionMap("Drum", throwIfNotFound: true);
        m_Drum_LeftFace = m_Drum.FindAction("Left Face", throwIfNotFound: true);
        m_Drum_RightFace = m_Drum.FindAction("Right Face", throwIfNotFound: true);
        m_Drum_LeftRim = m_Drum.FindAction("Left Rim", throwIfNotFound: true);
        m_Drum_RightRim = m_Drum.FindAction("Right Rim", throwIfNotFound: true);
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

    // Drum
    private readonly InputActionMap m_Drum;
    private IDrumActions m_DrumActionsCallbackInterface;
    private readonly InputAction m_Drum_LeftFace;
    private readonly InputAction m_Drum_RightFace;
    private readonly InputAction m_Drum_LeftRim;
    private readonly InputAction m_Drum_RightRim;
    public struct DrumActions
    {
        private @TaikoDrumTest m_Wrapper;
        public DrumActions(@TaikoDrumTest wrapper) { m_Wrapper = wrapper; }
        public InputAction @LeftFace => m_Wrapper.m_Drum_LeftFace;
        public InputAction @RightFace => m_Wrapper.m_Drum_RightFace;
        public InputAction @LeftRim => m_Wrapper.m_Drum_LeftRim;
        public InputAction @RightRim => m_Wrapper.m_Drum_RightRim;
        public InputActionMap Get() { return m_Wrapper.m_Drum; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DrumActions set) { return set.Get(); }
        public void SetCallbacks(IDrumActions instance)
        {
            if (m_Wrapper.m_DrumActionsCallbackInterface != null)
            {
                @LeftFace.started -= m_Wrapper.m_DrumActionsCallbackInterface.OnLeftFace;
                @LeftFace.performed -= m_Wrapper.m_DrumActionsCallbackInterface.OnLeftFace;
                @LeftFace.canceled -= m_Wrapper.m_DrumActionsCallbackInterface.OnLeftFace;
                @RightFace.started -= m_Wrapper.m_DrumActionsCallbackInterface.OnRightFace;
                @RightFace.performed -= m_Wrapper.m_DrumActionsCallbackInterface.OnRightFace;
                @RightFace.canceled -= m_Wrapper.m_DrumActionsCallbackInterface.OnRightFace;
                @LeftRim.started -= m_Wrapper.m_DrumActionsCallbackInterface.OnLeftRim;
                @LeftRim.performed -= m_Wrapper.m_DrumActionsCallbackInterface.OnLeftRim;
                @LeftRim.canceled -= m_Wrapper.m_DrumActionsCallbackInterface.OnLeftRim;
                @RightRim.started -= m_Wrapper.m_DrumActionsCallbackInterface.OnRightRim;
                @RightRim.performed -= m_Wrapper.m_DrumActionsCallbackInterface.OnRightRim;
                @RightRim.canceled -= m_Wrapper.m_DrumActionsCallbackInterface.OnRightRim;
            }
            m_Wrapper.m_DrumActionsCallbackInterface = instance;
            if (instance != null)
            {
                @LeftFace.started += instance.OnLeftFace;
                @LeftFace.performed += instance.OnLeftFace;
                @LeftFace.canceled += instance.OnLeftFace;
                @RightFace.started += instance.OnRightFace;
                @RightFace.performed += instance.OnRightFace;
                @RightFace.canceled += instance.OnRightFace;
                @LeftRim.started += instance.OnLeftRim;
                @LeftRim.performed += instance.OnLeftRim;
                @LeftRim.canceled += instance.OnLeftRim;
                @RightRim.started += instance.OnRightRim;
                @RightRim.performed += instance.OnRightRim;
                @RightRim.canceled += instance.OnRightRim;
            }
        }
    }
    public DrumActions @Drum => new DrumActions(this);
    public interface IDrumActions
    {
        void OnLeftFace(InputAction.CallbackContext context);
        void OnRightFace(InputAction.CallbackContext context);
        void OnLeftRim(InputAction.CallbackContext context);
        void OnRightRim(InputAction.CallbackContext context);
    }
}
