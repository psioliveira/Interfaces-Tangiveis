// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/PlayerControler.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControler : IInputActionCollection, IDisposable
{
    private InputActionAsset asset;
    public @PlayerControler()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControler"",
    ""maps"": [
        {
            ""name"": ""PlayerControl"",
            ""id"": ""094200b2-d88d-4b68-a783-cfea694229e9"",
            ""actions"": [
                {
                    ""name"": ""north"",
                    ""type"": ""Button"",
                    ""id"": ""c16263ba-2292-4855-96b7-bc1ce4e1ffae"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""south"",
                    ""type"": ""Button"",
                    ""id"": ""3e983d59-2a44-41cd-b7a5-c70e947db1b9"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""west"",
                    ""type"": ""Button"",
                    ""id"": ""a5c8fb56-5f1d-4af9-955e-5ef0c80bf127"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""east"",
                    ""type"": ""Button"",
                    ""id"": ""86f6014d-424e-4968-b616-288bed380fcc"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""confirm"",
                    ""type"": ""Button"",
                    ""id"": ""559b4e91-9e44-4e7e-987f-2bc88b91e43a"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""decline"",
                    ""type"": ""Button"",
                    ""id"": ""9f581ff5-399e-40c0-9b11-7e3bedb18321"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""146c3e45-3dcf-45e4-bf7e-5bdd3d5094b1"",
                    ""path"": ""<HID::Arduino LLC Arduino Leonardo>/trigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""north"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5f8cb348-74f5-4167-90ea-79c138ec54e1"",
                    ""path"": ""<HID::Arduino LLC Arduino Leonardo>/button2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""south"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1637df9a-b49b-461e-8cd6-1d7f3f7ef6e9"",
                    ""path"": ""<HID::Arduino LLC Arduino Leonardo>/button3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""west"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""42e37cef-68b8-4ead-a4c9-a71f1af1bdea"",
                    ""path"": ""<HID::Arduino LLC Arduino Leonardo>/button4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""east"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""832980d3-1b8c-426b-8b7f-d28229f95d9d"",
                    ""path"": ""<HID::Arduino LLC Arduino Leonardo>/button5"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""confirm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""75bb9b44-a416-4917-9903-c9ca78722cff"",
                    ""path"": ""<HID::Arduino LLC Arduino Leonardo>/button6"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""decline"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayerControl
        m_PlayerControl = asset.FindActionMap("PlayerControl", throwIfNotFound: true);
        m_PlayerControl_north = m_PlayerControl.FindAction("north", throwIfNotFound: true);
        m_PlayerControl_south = m_PlayerControl.FindAction("south", throwIfNotFound: true);
        m_PlayerControl_west = m_PlayerControl.FindAction("west", throwIfNotFound: true);
        m_PlayerControl_east = m_PlayerControl.FindAction("east", throwIfNotFound: true);
        m_PlayerControl_confirm = m_PlayerControl.FindAction("confirm", throwIfNotFound: true);
        m_PlayerControl_decline = m_PlayerControl.FindAction("decline", throwIfNotFound: true);
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

    // PlayerControl
    private readonly InputActionMap m_PlayerControl;
    private IPlayerControlActions m_PlayerControlActionsCallbackInterface;
    private readonly InputAction m_PlayerControl_north;
    private readonly InputAction m_PlayerControl_south;
    private readonly InputAction m_PlayerControl_west;
    private readonly InputAction m_PlayerControl_east;
    private readonly InputAction m_PlayerControl_confirm;
    private readonly InputAction m_PlayerControl_decline;
    public struct PlayerControlActions
    {
        private @PlayerControler m_Wrapper;
        public PlayerControlActions(@PlayerControler wrapper) { m_Wrapper = wrapper; }
        public InputAction @north => m_Wrapper.m_PlayerControl_north;
        public InputAction @south => m_Wrapper.m_PlayerControl_south;
        public InputAction @west => m_Wrapper.m_PlayerControl_west;
        public InputAction @east => m_Wrapper.m_PlayerControl_east;
        public InputAction @confirm => m_Wrapper.m_PlayerControl_confirm;
        public InputAction @decline => m_Wrapper.m_PlayerControl_decline;
        public InputActionMap Get() { return m_Wrapper.m_PlayerControl; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerControlActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerControlActions instance)
        {
            if (m_Wrapper.m_PlayerControlActionsCallbackInterface != null)
            {
                @north.started -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnNorth;
                @north.performed -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnNorth;
                @north.canceled -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnNorth;
                @south.started -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnSouth;
                @south.performed -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnSouth;
                @south.canceled -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnSouth;
                @west.started -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnWest;
                @west.performed -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnWest;
                @west.canceled -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnWest;
                @east.started -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnEast;
                @east.performed -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnEast;
                @east.canceled -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnEast;
                @confirm.started -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnConfirm;
                @confirm.performed -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnConfirm;
                @confirm.canceled -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnConfirm;
                @decline.started -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnDecline;
                @decline.performed -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnDecline;
                @decline.canceled -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnDecline;
            }
            m_Wrapper.m_PlayerControlActionsCallbackInterface = instance;
            if (instance != null)
            {
                @north.started += instance.OnNorth;
                @north.performed += instance.OnNorth;
                @north.canceled += instance.OnNorth;
                @south.started += instance.OnSouth;
                @south.performed += instance.OnSouth;
                @south.canceled += instance.OnSouth;
                @west.started += instance.OnWest;
                @west.performed += instance.OnWest;
                @west.canceled += instance.OnWest;
                @east.started += instance.OnEast;
                @east.performed += instance.OnEast;
                @east.canceled += instance.OnEast;
                @confirm.started += instance.OnConfirm;
                @confirm.performed += instance.OnConfirm;
                @confirm.canceled += instance.OnConfirm;
                @decline.started += instance.OnDecline;
                @decline.performed += instance.OnDecline;
                @decline.canceled += instance.OnDecline;
            }
        }
    }
    public PlayerControlActions @PlayerControl => new PlayerControlActions(this);
    public interface IPlayerControlActions
    {
        void OnNorth(InputAction.CallbackContext context);
        void OnSouth(InputAction.CallbackContext context);
        void OnWest(InputAction.CallbackContext context);
        void OnEast(InputAction.CallbackContext context);
        void OnConfirm(InputAction.CallbackContext context);
        void OnDecline(InputAction.CallbackContext context);
    }
}
