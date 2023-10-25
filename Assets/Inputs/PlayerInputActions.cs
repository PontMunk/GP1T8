//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.6.3
//     from Assets/Inputs/PlayerInputActions.inputactions
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

public partial class @PlayerInputActions: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputActions"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""14bcc1f7-2168-42c2-aad7-92f530c0fbc3"",
            ""actions"": [
                {
                    ""name"": ""PlayerAction"",
                    ""type"": ""Value"",
                    ""id"": ""533acc78-e13d-451a-bc52-195ca760411d"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""LightLeft"",
                    ""type"": ""Button"",
                    ""id"": ""1d8a4b54-20e6-487c-9c8d-75e129a47ab6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""LightRight"",
                    ""type"": ""Button"",
                    ""id"": ""695523ea-eef8-4053-9911-fdde4d4bb6fe"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""SliderLeft"",
                    ""type"": ""Value"",
                    ""id"": ""9a7d9394-56e6-4645-8929-c92e5b1bddce"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""SliderRight"",
                    ""type"": ""Value"",
                    ""id"": ""6bc3a032-25e0-401b-9c46-b2c014957d90"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""dpadUpRight"",
                    ""type"": ""Button"",
                    ""id"": ""ce4bc082-e68c-4344-b410-b6e3d97b0cb0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""dpadUpLeft"",
                    ""type"": ""Button"",
                    ""id"": ""c6c86628-a701-4197-bb39-80f52f7a46f4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""dpadDownRight"",
                    ""type"": ""Button"",
                    ""id"": ""83f7a69f-cb6a-4362-ac85-b05829be907e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""dpadDownLeft"",
                    ""type"": ""Button"",
                    ""id"": ""e17a4783-e306-47e3-810a-c116e24264af"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""c42d4237-00d4-49a5-ab73-845970f8d894"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerAction"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""d4505cf0-81d9-4faa-bdd2-fc107312d4e5"",
                    ""path"": ""<XInputController>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerAction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""42cb07e3-f05b-429b-8d4c-bebb0ee39d6f"",
                    ""path"": ""<XInputController>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerAction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""8df2a134-3e0a-46bc-91a7-ea1698849496"",
                    ""path"": ""<XInputController>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerAction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""00c3ef4f-3e2a-4a88-b387-cf52e1661f77"",
                    ""path"": ""<XInputController>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerAction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector from keyboard"",
                    ""id"": ""d63ee582-e182-4086-8ed7-a89f92869276"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerAction"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""01d45d93-5201-402c-9660-b260b1b07131"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerAction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""06fcd0c7-be5b-46de-97c7-eb7cefe28583"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerAction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""6658296d-809a-45ac-b81a-a8d7d4906f77"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerAction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""f91cd8e7-4065-4a04-aa25-e9f4efd00849"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerAction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""d2206420-65a9-410c-be71-88f6c663aef6"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""LightLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c991c0b6-0846-4389-8700-2d827cf63b9e"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""LightLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c3dce667-5b1e-40eb-888d-7d6c9577014c"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""LightLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7a81585e-1023-4891-bf29-67735dc7a527"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""LightRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""87ae1295-01b5-4e36-ab02-b34de9da5127"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""LightRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d0130ee7-c0a0-4513-a14b-a0d53a06c5fb"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""LightRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""de89a0e5-1325-4fc2-8cfa-539506a11236"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""LightRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""220f97ea-3ca3-43f1-b86e-5fb479a4d589"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""LightRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""587fd85d-4841-4b0c-b4f8-aa264e484ba8"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""LightRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0d67e7a0-4e69-477e-8ca2-d6ac0d76ac7b"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""SliderLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""211d59fa-1772-4eff-9fc6-24de7aac886f"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""SliderRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""95ec8d86-8243-4782-9c58-06719d0cb2db"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""dpadUpRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0c176285-45e4-4177-a9da-ac89611c83ee"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""dpadUpRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4144d3a4-7742-4430-b74c-92443a61e6cb"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""dpadDownRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ef584628-6fd9-4fa0-a17f-2d2b65bc8ea0"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""dpadDownRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f44fa6c0-1a64-4e96-82bd-d40445bb93cc"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""dpadUpLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0b308186-7ad8-4c44-a0d9-768f62971a16"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""dpadUpLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a87fb1f3-8754-4cdf-9427-88dabf36dff2"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""dpadDownLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1347cd83-420c-41a7-bbc0-d988604e8b96"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""dpadDownLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_PlayerAction = m_Player.FindAction("PlayerAction", throwIfNotFound: true);
        m_Player_LightLeft = m_Player.FindAction("LightLeft", throwIfNotFound: true);
        m_Player_LightRight = m_Player.FindAction("LightRight", throwIfNotFound: true);
        m_Player_SliderLeft = m_Player.FindAction("SliderLeft", throwIfNotFound: true);
        m_Player_SliderRight = m_Player.FindAction("SliderRight", throwIfNotFound: true);
        m_Player_dpadUpRight = m_Player.FindAction("dpadUpRight", throwIfNotFound: true);
        m_Player_dpadUpLeft = m_Player.FindAction("dpadUpLeft", throwIfNotFound: true);
        m_Player_dpadDownRight = m_Player.FindAction("dpadDownRight", throwIfNotFound: true);
        m_Player_dpadDownLeft = m_Player.FindAction("dpadDownLeft", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private List<IPlayerActions> m_PlayerActionsCallbackInterfaces = new List<IPlayerActions>();
    private readonly InputAction m_Player_PlayerAction;
    private readonly InputAction m_Player_LightLeft;
    private readonly InputAction m_Player_LightRight;
    private readonly InputAction m_Player_SliderLeft;
    private readonly InputAction m_Player_SliderRight;
    private readonly InputAction m_Player_dpadUpRight;
    private readonly InputAction m_Player_dpadUpLeft;
    private readonly InputAction m_Player_dpadDownRight;
    private readonly InputAction m_Player_dpadDownLeft;
    public struct PlayerActions
    {
        private @PlayerInputActions m_Wrapper;
        public PlayerActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @PlayerAction => m_Wrapper.m_Player_PlayerAction;
        public InputAction @LightLeft => m_Wrapper.m_Player_LightLeft;
        public InputAction @LightRight => m_Wrapper.m_Player_LightRight;
        public InputAction @SliderLeft => m_Wrapper.m_Player_SliderLeft;
        public InputAction @SliderRight => m_Wrapper.m_Player_SliderRight;
        public InputAction @dpadUpRight => m_Wrapper.m_Player_dpadUpRight;
        public InputAction @dpadUpLeft => m_Wrapper.m_Player_dpadUpLeft;
        public InputAction @dpadDownRight => m_Wrapper.m_Player_dpadDownRight;
        public InputAction @dpadDownLeft => m_Wrapper.m_Player_dpadDownLeft;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void AddCallbacks(IPlayerActions instance)
        {
            if (instance == null || m_Wrapper.m_PlayerActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlayerActionsCallbackInterfaces.Add(instance);
            @PlayerAction.started += instance.OnPlayerAction;
            @PlayerAction.performed += instance.OnPlayerAction;
            @PlayerAction.canceled += instance.OnPlayerAction;
            @LightLeft.started += instance.OnLightLeft;
            @LightLeft.performed += instance.OnLightLeft;
            @LightLeft.canceled += instance.OnLightLeft;
            @LightRight.started += instance.OnLightRight;
            @LightRight.performed += instance.OnLightRight;
            @LightRight.canceled += instance.OnLightRight;
            @SliderLeft.started += instance.OnSliderLeft;
            @SliderLeft.performed += instance.OnSliderLeft;
            @SliderLeft.canceled += instance.OnSliderLeft;
            @SliderRight.started += instance.OnSliderRight;
            @SliderRight.performed += instance.OnSliderRight;
            @SliderRight.canceled += instance.OnSliderRight;
            @dpadUpRight.started += instance.OnDpadUpRight;
            @dpadUpRight.performed += instance.OnDpadUpRight;
            @dpadUpRight.canceled += instance.OnDpadUpRight;
            @dpadUpLeft.started += instance.OnDpadUpLeft;
            @dpadUpLeft.performed += instance.OnDpadUpLeft;
            @dpadUpLeft.canceled += instance.OnDpadUpLeft;
            @dpadDownRight.started += instance.OnDpadDownRight;
            @dpadDownRight.performed += instance.OnDpadDownRight;
            @dpadDownRight.canceled += instance.OnDpadDownRight;
            @dpadDownLeft.started += instance.OnDpadDownLeft;
            @dpadDownLeft.performed += instance.OnDpadDownLeft;
            @dpadDownLeft.canceled += instance.OnDpadDownLeft;
        }

        private void UnregisterCallbacks(IPlayerActions instance)
        {
            @PlayerAction.started -= instance.OnPlayerAction;
            @PlayerAction.performed -= instance.OnPlayerAction;
            @PlayerAction.canceled -= instance.OnPlayerAction;
            @LightLeft.started -= instance.OnLightLeft;
            @LightLeft.performed -= instance.OnLightLeft;
            @LightLeft.canceled -= instance.OnLightLeft;
            @LightRight.started -= instance.OnLightRight;
            @LightRight.performed -= instance.OnLightRight;
            @LightRight.canceled -= instance.OnLightRight;
            @SliderLeft.started -= instance.OnSliderLeft;
            @SliderLeft.performed -= instance.OnSliderLeft;
            @SliderLeft.canceled -= instance.OnSliderLeft;
            @SliderRight.started -= instance.OnSliderRight;
            @SliderRight.performed -= instance.OnSliderRight;
            @SliderRight.canceled -= instance.OnSliderRight;
            @dpadUpRight.started -= instance.OnDpadUpRight;
            @dpadUpRight.performed -= instance.OnDpadUpRight;
            @dpadUpRight.canceled -= instance.OnDpadUpRight;
            @dpadUpLeft.started -= instance.OnDpadUpLeft;
            @dpadUpLeft.performed -= instance.OnDpadUpLeft;
            @dpadUpLeft.canceled -= instance.OnDpadUpLeft;
            @dpadDownRight.started -= instance.OnDpadDownRight;
            @dpadDownRight.performed -= instance.OnDpadDownRight;
            @dpadDownRight.canceled -= instance.OnDpadDownRight;
            @dpadDownLeft.started -= instance.OnDpadDownLeft;
            @dpadDownLeft.performed -= instance.OnDpadDownLeft;
            @dpadDownLeft.canceled -= instance.OnDpadDownLeft;
        }

        public void RemoveCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayerActions instance)
        {
            foreach (var item in m_Wrapper.m_PlayerActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlayerActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnPlayerAction(InputAction.CallbackContext context);
        void OnLightLeft(InputAction.CallbackContext context);
        void OnLightRight(InputAction.CallbackContext context);
        void OnSliderLeft(InputAction.CallbackContext context);
        void OnSliderRight(InputAction.CallbackContext context);
        void OnDpadUpRight(InputAction.CallbackContext context);
        void OnDpadUpLeft(InputAction.CallbackContext context);
        void OnDpadDownRight(InputAction.CallbackContext context);
        void OnDpadDownLeft(InputAction.CallbackContext context);
    }
}
