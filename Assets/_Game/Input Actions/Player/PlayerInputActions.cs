//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/_Game/Input Actions/Player/PlayerInputActions.inputactions
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

public partial class @PlayerInputActions : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputActions"",
    ""maps"": [
        {
            ""name"": ""Main Ship"",
            ""id"": ""b470f16f-d9e8-45ee-abfa-1367d326623c"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""f550a154-ac92-4479-a6ce-2b1325d353b6"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Aim"",
                    ""type"": ""PassThrough"",
                    ""id"": ""5e31bd29-55a8-43fc-841e-ec532c9af8a1"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""294ad2b4-d5da-4626-8068-175141d846b2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Normal Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""9efee4b3-e99e-4755-881a-59e06550a7f9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""0de0f38b-9876-4af0-96aa-1ed3a6bb5ef1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Dash"",
                    ""type"": ""Button"",
                    ""id"": ""42701a3f-20bf-44a0-920a-6ce339aca40a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ActivateShield"",
                    ""type"": ""Button"",
                    ""id"": ""9d18aec0-2117-4453-bd47-3d6800ec1e22"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""3aa46fb1-319f-4a8d-baab-57dadaf6a8af"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""9a377019-056c-4455-b047-74368c46ea99"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""ad533d46-8d51-49f9-9e9b-1dbdd6fb10de"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""a1f8580e-b0ea-4d7c-b5e9-0874248af97c"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""b74a2f57-f573-4e8f-8419-9b583b5e753c"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""5866ef8e-44b7-4614-b9bd-429d97b32a3d"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": ""StickDeadzone"",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""70fab2f6-728f-4f15-be48-8ff071f54109"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": ""StickDeadzone"",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""44e754d8-cd5d-4bd9-8eb5-6544820ecab4"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0a4657e3-6515-4cc2-be39-e25a79b5e71d"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""95c1f450-dd66-41d7-b13d-e415984a007c"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse"",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ef8c2e15-1600-493d-9893-74a0c23f02d1"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse"",
                    ""action"": ""Normal Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""11ba9f64-2934-4841-b784-aa666e9a6860"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1ed5cde9-6ae9-49f4-90bf-719a26acd31b"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""63ea503c-d1b5-4bb2-ad8f-78f8e2faefae"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""ActivateShield"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9b0865e9-4969-4c8e-8e40-0e7730695e65"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""ActivateShield"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Mouse"",
            ""bindingGroup"": ""Mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Main Ship
        m_MainShip = asset.FindActionMap("Main Ship", throwIfNotFound: true);
        m_MainShip_Movement = m_MainShip.FindAction("Movement", throwIfNotFound: true);
        m_MainShip_Aim = m_MainShip.FindAction("Aim", throwIfNotFound: true);
        m_MainShip_Pause = m_MainShip.FindAction("Pause", throwIfNotFound: true);
        m_MainShip_NormalShoot = m_MainShip.FindAction("Normal Shoot", throwIfNotFound: true);
        m_MainShip_Shoot = m_MainShip.FindAction("Shoot", throwIfNotFound: true);
        m_MainShip_Dash = m_MainShip.FindAction("Dash", throwIfNotFound: true);
        m_MainShip_ActivateShield = m_MainShip.FindAction("ActivateShield", throwIfNotFound: true);
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

    // Main Ship
    private readonly InputActionMap m_MainShip;
    private IMainShipActions m_MainShipActionsCallbackInterface;
    private readonly InputAction m_MainShip_Movement;
    private readonly InputAction m_MainShip_Aim;
    private readonly InputAction m_MainShip_Pause;
    private readonly InputAction m_MainShip_NormalShoot;
    private readonly InputAction m_MainShip_Shoot;
    private readonly InputAction m_MainShip_Dash;
    private readonly InputAction m_MainShip_ActivateShield;
    public struct MainShipActions
    {
        private @PlayerInputActions m_Wrapper;
        public MainShipActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_MainShip_Movement;
        public InputAction @Aim => m_Wrapper.m_MainShip_Aim;
        public InputAction @Pause => m_Wrapper.m_MainShip_Pause;
        public InputAction @NormalShoot => m_Wrapper.m_MainShip_NormalShoot;
        public InputAction @Shoot => m_Wrapper.m_MainShip_Shoot;
        public InputAction @Dash => m_Wrapper.m_MainShip_Dash;
        public InputAction @ActivateShield => m_Wrapper.m_MainShip_ActivateShield;
        public InputActionMap Get() { return m_Wrapper.m_MainShip; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MainShipActions set) { return set.Get(); }
        public void SetCallbacks(IMainShipActions instance)
        {
            if (m_Wrapper.m_MainShipActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_MainShipActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_MainShipActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_MainShipActionsCallbackInterface.OnMovement;
                @Aim.started -= m_Wrapper.m_MainShipActionsCallbackInterface.OnAim;
                @Aim.performed -= m_Wrapper.m_MainShipActionsCallbackInterface.OnAim;
                @Aim.canceled -= m_Wrapper.m_MainShipActionsCallbackInterface.OnAim;
                @Pause.started -= m_Wrapper.m_MainShipActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_MainShipActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_MainShipActionsCallbackInterface.OnPause;
                @NormalShoot.started -= m_Wrapper.m_MainShipActionsCallbackInterface.OnNormalShoot;
                @NormalShoot.performed -= m_Wrapper.m_MainShipActionsCallbackInterface.OnNormalShoot;
                @NormalShoot.canceled -= m_Wrapper.m_MainShipActionsCallbackInterface.OnNormalShoot;
                @Shoot.started -= m_Wrapper.m_MainShipActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_MainShipActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_MainShipActionsCallbackInterface.OnShoot;
                @Dash.started -= m_Wrapper.m_MainShipActionsCallbackInterface.OnDash;
                @Dash.performed -= m_Wrapper.m_MainShipActionsCallbackInterface.OnDash;
                @Dash.canceled -= m_Wrapper.m_MainShipActionsCallbackInterface.OnDash;
                @ActivateShield.started -= m_Wrapper.m_MainShipActionsCallbackInterface.OnActivateShield;
                @ActivateShield.performed -= m_Wrapper.m_MainShipActionsCallbackInterface.OnActivateShield;
                @ActivateShield.canceled -= m_Wrapper.m_MainShipActionsCallbackInterface.OnActivateShield;
            }
            m_Wrapper.m_MainShipActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Aim.started += instance.OnAim;
                @Aim.performed += instance.OnAim;
                @Aim.canceled += instance.OnAim;
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
                @NormalShoot.started += instance.OnNormalShoot;
                @NormalShoot.performed += instance.OnNormalShoot;
                @NormalShoot.canceled += instance.OnNormalShoot;
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
                @Dash.started += instance.OnDash;
                @Dash.performed += instance.OnDash;
                @Dash.canceled += instance.OnDash;
                @ActivateShield.started += instance.OnActivateShield;
                @ActivateShield.performed += instance.OnActivateShield;
                @ActivateShield.canceled += instance.OnActivateShield;
            }
        }
    }
    public MainShipActions @MainShip => new MainShipActions(this);
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    private int m_MouseSchemeIndex = -1;
    public InputControlScheme MouseScheme
    {
        get
        {
            if (m_MouseSchemeIndex == -1) m_MouseSchemeIndex = asset.FindControlSchemeIndex("Mouse");
            return asset.controlSchemes[m_MouseSchemeIndex];
        }
    }
    public interface IMainShipActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnAim(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
        void OnNormalShoot(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnDash(InputAction.CallbackContext context);
        void OnActivateShield(InputAction.CallbackContext context);
    }
}
