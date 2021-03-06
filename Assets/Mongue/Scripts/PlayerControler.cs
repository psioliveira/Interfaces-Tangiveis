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
                },
                {
                    ""name"": ""northReleased"",
                    ""type"": ""Button"",
                    ""id"": ""cb0626de-1091-4747-b088-8347fbfe0187"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=1)""
                },
                {
                    ""name"": ""southReleased"",
                    ""type"": ""Button"",
                    ""id"": ""fc0bbb69-5a93-4882-b0a1-49bfa60c528e"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=1)""
                },
                {
                    ""name"": ""westReleased"",
                    ""type"": ""Button"",
                    ""id"": ""2f788a62-6eb7-43e6-98ef-d9e491c2cc51"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=1)""
                },
                {
                    ""name"": ""eastReleased"",
                    ""type"": ""Button"",
                    ""id"": ""b71bc3a3-a13e-4e66-8ada-f72bf5b73b39"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=1)""
                },
                {
                    ""name"": ""moveReleased"",
                    ""type"": ""Button"",
                    ""id"": ""da4eff6c-1201-479d-b860-c0e6e6e5b22e"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=1)""
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
                    ""id"": ""53b9bd73-2b7c-4763-be6b-29af349c6a99"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""north"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bbd2ec1a-f967-4aa7-ac64-163da417f257"",
                    ""path"": ""<Keyboard>/w"",
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
                    ""id"": ""0928b659-3152-4f05-b611-ac9ed7ebad9d"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""south"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9794b5d8-e2f3-40cc-bb02-a9f33e6190b6"",
                    ""path"": ""<Keyboard>/downArrow"",
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
                    ""id"": ""d3717f85-022e-4335-90f5-9aa7e0c22701"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""west"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2dff5989-60fa-48a1-aafd-609f0d74b9ce"",
                    ""path"": ""<Keyboard>/leftArrow"",
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
                    ""id"": ""72819196-26c8-4939-9b05-e5cd6632e7db"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""east"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5b14a8b6-9a01-4ea0-bfeb-ba32a889a83a"",
                    ""path"": ""<Keyboard>/rightArrow"",
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
                    ""id"": ""824bbaaf-cfd4-44a1-acf2-7ec7d4b0e746"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""confirm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f8b7fcd7-6c54-4ce7-b5a5-c5cce732a4cc"",
                    ""path"": ""<Keyboard>/space"",
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
                },
                {
                    ""name"": """",
                    ""id"": ""7c1d8342-76c5-4f22-a217-3b254171a277"",
                    ""path"": ""<Keyboard>/backspace"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""decline"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a68c468a-cf82-45ae-b198-e62a72a4bf43"",
                    ""path"": ""<Keyboard>/delete"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""decline"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4c7c8aa3-ccfb-4415-93ad-71bc66690a89"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""northReleased"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""068b5e84-4a9b-4a7f-a121-6cc68f9f7818"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""northReleased"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bb12d502-b6e8-4e8d-b6cf-cc1ac3446f69"",
                    ""path"": ""<HID::Arduino LLC Arduino Leonardo>/trigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""northReleased"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c9713721-8aa4-4095-960b-2150804ebae8"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""southReleased"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7134a9a9-22d5-4c33-bf9f-6ad04ca5071f"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""southReleased"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c28abd69-7c7c-410a-8693-12c96e48e212"",
                    ""path"": ""<HID::Arduino LLC Arduino Leonardo>/button2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""southReleased"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""394e1cd3-1df6-45a8-8320-efa820723f63"",
                    ""path"": ""<HID::Arduino LLC Arduino Leonardo>/button3"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""westReleased"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1b3cea18-55d2-4408-9c01-d12a712a2ff1"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""westReleased"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1cc08eca-97ef-4c16-9fe0-4d67a5ed3629"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""westReleased"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1cd4dd21-4c12-48b4-a107-5406fd900c3b"",
                    ""path"": ""<HID::Arduino LLC Arduino Leonardo>/button4"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""eastReleased"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4888c54f-d387-4b7c-a009-b1348e49c518"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""eastReleased"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""30827f42-a404-4fef-9dda-ca0cc282d152"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""eastReleased"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2c5b3d36-7b6d-4829-b80b-e86c74a50111"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""moveReleased"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6e47df9e-692b-4be9-ab89-45d36d7f27c7"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""moveReleased"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2ff988cb-f6b9-4519-bc3a-990b8c5e0472"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""moveReleased"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d828b42e-2ffb-493f-adf1-23dae7216571"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""moveReleased"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ae198c1b-3c15-4f6d-8a32-86e33ed4279a"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""moveReleased"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""236e2bd8-3f1b-4287-bbd3-b34af31d4796"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""moveReleased"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d19d9eff-1624-486d-947c-f7b753650930"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""moveReleased"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""44c14d42-0f66-4b05-9f8b-f361b665e3e2"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""moveReleased"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7a564328-602c-4c33-8594-6766d7654b8e"",
                    ""path"": ""<HID::Arduino LLC Arduino Leonardo>/button3"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""moveReleased"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""701e2e45-63a1-4ac8-a613-ad6ba4f7ce8e"",
                    ""path"": ""<HID::Arduino LLC Arduino Leonardo>/trigger"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""moveReleased"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""64a054d0-8286-41d3-8060-aa6673e80f3d"",
                    ""path"": ""<HID::Arduino LLC Arduino Leonardo>/button2"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""moveReleased"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""335f1fd4-5e97-462c-a2ac-dbcf30b73a0f"",
                    ""path"": ""<HID::Arduino LLC Arduino Leonardo>/button2"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""moveReleased"",
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
        m_PlayerControl_northReleased = m_PlayerControl.FindAction("northReleased", throwIfNotFound: true);
        m_PlayerControl_southReleased = m_PlayerControl.FindAction("southReleased", throwIfNotFound: true);
        m_PlayerControl_westReleased = m_PlayerControl.FindAction("westReleased", throwIfNotFound: true);
        m_PlayerControl_eastReleased = m_PlayerControl.FindAction("eastReleased", throwIfNotFound: true);
        m_PlayerControl_moveReleased = m_PlayerControl.FindAction("moveReleased", throwIfNotFound: true);
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
    private readonly InputAction m_PlayerControl_northReleased;
    private readonly InputAction m_PlayerControl_southReleased;
    private readonly InputAction m_PlayerControl_westReleased;
    private readonly InputAction m_PlayerControl_eastReleased;
    private readonly InputAction m_PlayerControl_moveReleased;
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
        public InputAction @northReleased => m_Wrapper.m_PlayerControl_northReleased;
        public InputAction @southReleased => m_Wrapper.m_PlayerControl_southReleased;
        public InputAction @westReleased => m_Wrapper.m_PlayerControl_westReleased;
        public InputAction @eastReleased => m_Wrapper.m_PlayerControl_eastReleased;
        public InputAction @moveReleased => m_Wrapper.m_PlayerControl_moveReleased;
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
                @northReleased.started -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnNorthReleased;
                @northReleased.performed -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnNorthReleased;
                @northReleased.canceled -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnNorthReleased;
                @southReleased.started -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnSouthReleased;
                @southReleased.performed -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnSouthReleased;
                @southReleased.canceled -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnSouthReleased;
                @westReleased.started -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnWestReleased;
                @westReleased.performed -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnWestReleased;
                @westReleased.canceled -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnWestReleased;
                @eastReleased.started -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnEastReleased;
                @eastReleased.performed -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnEastReleased;
                @eastReleased.canceled -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnEastReleased;
                @moveReleased.started -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnMoveReleased;
                @moveReleased.performed -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnMoveReleased;
                @moveReleased.canceled -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnMoveReleased;
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
                @northReleased.started += instance.OnNorthReleased;
                @northReleased.performed += instance.OnNorthReleased;
                @northReleased.canceled += instance.OnNorthReleased;
                @southReleased.started += instance.OnSouthReleased;
                @southReleased.performed += instance.OnSouthReleased;
                @southReleased.canceled += instance.OnSouthReleased;
                @westReleased.started += instance.OnWestReleased;
                @westReleased.performed += instance.OnWestReleased;
                @westReleased.canceled += instance.OnWestReleased;
                @eastReleased.started += instance.OnEastReleased;
                @eastReleased.performed += instance.OnEastReleased;
                @eastReleased.canceled += instance.OnEastReleased;
                @moveReleased.started += instance.OnMoveReleased;
                @moveReleased.performed += instance.OnMoveReleased;
                @moveReleased.canceled += instance.OnMoveReleased;
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
        void OnNorthReleased(InputAction.CallbackContext context);
        void OnSouthReleased(InputAction.CallbackContext context);
        void OnWestReleased(InputAction.CallbackContext context);
        void OnEastReleased(InputAction.CallbackContext context);
        void OnMoveReleased(InputAction.CallbackContext context);
    }
}
