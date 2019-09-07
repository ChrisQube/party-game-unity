// GENERATED AUTOMATICALLY FROM 'Assets/Input/PlayerControls.inputactions'

using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class PlayerControls : IInputActionCollection
{
    private InputActionAsset asset;
    public PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""Player1"",
            ""id"": ""9d11a9c9-9947-40f9-91a6-bc4a36e8b314"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Button"",
                    ""id"": ""f365d74f-156e-46f3-b59c-e9b75d53e66b"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Action"",
                    ""type"": ""Button"",
                    ""id"": ""4183f63d-6b79-496c-bad1-b9c9e6fe490e"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""301f628e-4ff1-4d33-82a8-3fd81ecb11b2"",
                    ""path"": ""<HID::GameStop PS4 Fun Controller>/stick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Keys"",
                    ""id"": ""236dcf01-76be-4412-b279-8adad2cc7904"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""bfaa0fc6-dd2f-49c5-8a5d-a2537a48a8f6"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""eacc4d35-30ad-426e-aed2-9e8d2ef67efd"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""baa9d75f-73a9-4baf-bcd9-073a1e1348ec"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""c0fa8f90-7afa-4bb6-be7d-4898ff951df7"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""d10180b1-7972-4bf6-b142-f58985375b7c"",
                    ""path"": ""<HID::GameStop PS4 Fun Controller>/button2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Player2"",
            ""id"": ""39625fb7-f5d0-4087-a080-c5763a0d69e3"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Button"",
                    ""id"": ""e2c77b9d-63ff-4436-b297-2dbb8786e921"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""ccb50b31-ef4b-4498-b205-f7ae35be5b24"",
                    ""path"": ""<DualShockGamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Keys"",
                    ""id"": ""aba5a9ce-44fc-4c7a-af34-aad4f404e792"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""9d621951-7654-41c8-9a03-75c3c55f366c"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""4c95da38-4b5b-4c3d-b803-fbf97641056a"",
                    ""path"": ""<Keyboard>/k"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""3bb20cbc-0510-4c0a-bb5b-e05ce5f761b7"",
                    ""path"": ""<Keyboard>/j"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""923859ed-caf7-4c5e-8664-462943b856a5"",
                    ""path"": ""<Keyboard>/l"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Player3"",
            ""id"": ""d2531a50-878d-46a8-86cf-8da50162a398"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Button"",
                    ""id"": ""cfc6e6cd-5c63-4634-9583-5736e43becb3"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Keys"",
                    ""id"": ""4513a86a-36b8-4e29-9345-c8d2cc61f5ad"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""7d6bb73e-7dd7-45b0-8191-9e0819b62278"",
                    ""path"": ""<Keyboard>/t"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""c7dac7c7-93b3-4b23-b99e-660149aa2e87"",
                    ""path"": ""<Keyboard>/g"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""d0a723f6-96ab-46ae-a2eb-c2d8bb5b6f1f"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""aa327250-ba48-42f1-93d1-51dabc662d2b"",
                    ""path"": ""<Keyboard>/h"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Player4"",
            ""id"": ""302a7d59-fb75-4aef-86bb-a6217ae9a831"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Button"",
                    ""id"": ""214d30e2-734d-4c0c-9fd7-bcfa83073228"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Keys"",
                    ""id"": ""9eb6c52f-ed1b-47d7-9da3-e9dcacd95752"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""c972e011-8563-4320-b04a-11033eed11d8"",
                    ""path"": ""<Keyboard>/rightShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""44f16cef-c1e0-483d-83b5-0ac05451b22e"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""acd16e3a-6f21-486d-b656-180510401bbe"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""58610cdc-7eac-4607-bfda-b3c4b141e84a"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""a2e57c0f-6f3d-4f61-b321-ca65901e32a8"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""0beb005d-c79e-4d1a-9ca3-53c54b492c02"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""ae0b241e-8f9a-4d36-bdaf-b6a844c48b93"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""91e65d21-13c8-4681-904d-9a390069a570"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""4a2fbb81-9647-4eb2-8329-8734519f552d"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player1
        m_Player1 = asset.GetActionMap("Player1");
        m_Player1_Move = m_Player1.GetAction("Move");
        m_Player1_Action = m_Player1.GetAction("Action");
        // Player2
        m_Player2 = asset.GetActionMap("Player2");
        m_Player2_Move = m_Player2.GetAction("Move");
        // Player3
        m_Player3 = asset.GetActionMap("Player3");
        m_Player3_Move = m_Player3.GetAction("Move");
        // Player4
        m_Player4 = asset.GetActionMap("Player4");
        m_Player4_Move = m_Player4.GetAction("Move");
    }

    ~PlayerControls()
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

    // Player1
    private readonly InputActionMap m_Player1;
    private IPlayer1Actions m_Player1ActionsCallbackInterface;
    private readonly InputAction m_Player1_Move;
    private readonly InputAction m_Player1_Action;
    public struct Player1Actions
    {
        private PlayerControls m_Wrapper;
        public Player1Actions(PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Player1_Move;
        public InputAction @Action => m_Wrapper.m_Player1_Action;
        public InputActionMap Get() { return m_Wrapper.m_Player1; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Player1Actions set) { return set.Get(); }
        public void SetCallbacks(IPlayer1Actions instance)
        {
            if (m_Wrapper.m_Player1ActionsCallbackInterface != null)
            {
                Move.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnMove;
                Move.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnMove;
                Move.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnMove;
                Action.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnAction;
                Action.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnAction;
                Action.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnAction;
            }
            m_Wrapper.m_Player1ActionsCallbackInterface = instance;
            if (instance != null)
            {
                Move.started += instance.OnMove;
                Move.performed += instance.OnMove;
                Move.canceled += instance.OnMove;
                Action.started += instance.OnAction;
                Action.performed += instance.OnAction;
                Action.canceled += instance.OnAction;
            }
        }
    }
    public Player1Actions @Player1 => new Player1Actions(this);

    // Player2
    private readonly InputActionMap m_Player2;
    private IPlayer2Actions m_Player2ActionsCallbackInterface;
    private readonly InputAction m_Player2_Move;
    public struct Player2Actions
    {
        private PlayerControls m_Wrapper;
        public Player2Actions(PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Player2_Move;
        public InputActionMap Get() { return m_Wrapper.m_Player2; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Player2Actions set) { return set.Get(); }
        public void SetCallbacks(IPlayer2Actions instance)
        {
            if (m_Wrapper.m_Player2ActionsCallbackInterface != null)
            {
                Move.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnMove;
                Move.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnMove;
                Move.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnMove;
            }
            m_Wrapper.m_Player2ActionsCallbackInterface = instance;
            if (instance != null)
            {
                Move.started += instance.OnMove;
                Move.performed += instance.OnMove;
                Move.canceled += instance.OnMove;
            }
        }
    }
    public Player2Actions @Player2 => new Player2Actions(this);

    // Player3
    private readonly InputActionMap m_Player3;
    private IPlayer3Actions m_Player3ActionsCallbackInterface;
    private readonly InputAction m_Player3_Move;
    public struct Player3Actions
    {
        private PlayerControls m_Wrapper;
        public Player3Actions(PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Player3_Move;
        public InputActionMap Get() { return m_Wrapper.m_Player3; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Player3Actions set) { return set.Get(); }
        public void SetCallbacks(IPlayer3Actions instance)
        {
            if (m_Wrapper.m_Player3ActionsCallbackInterface != null)
            {
                Move.started -= m_Wrapper.m_Player3ActionsCallbackInterface.OnMove;
                Move.performed -= m_Wrapper.m_Player3ActionsCallbackInterface.OnMove;
                Move.canceled -= m_Wrapper.m_Player3ActionsCallbackInterface.OnMove;
            }
            m_Wrapper.m_Player3ActionsCallbackInterface = instance;
            if (instance != null)
            {
                Move.started += instance.OnMove;
                Move.performed += instance.OnMove;
                Move.canceled += instance.OnMove;
            }
        }
    }
    public Player3Actions @Player3 => new Player3Actions(this);

    // Player4
    private readonly InputActionMap m_Player4;
    private IPlayer4Actions m_Player4ActionsCallbackInterface;
    private readonly InputAction m_Player4_Move;
    public struct Player4Actions
    {
        private PlayerControls m_Wrapper;
        public Player4Actions(PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Player4_Move;
        public InputActionMap Get() { return m_Wrapper.m_Player4; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Player4Actions set) { return set.Get(); }
        public void SetCallbacks(IPlayer4Actions instance)
        {
            if (m_Wrapper.m_Player4ActionsCallbackInterface != null)
            {
                Move.started -= m_Wrapper.m_Player4ActionsCallbackInterface.OnMove;
                Move.performed -= m_Wrapper.m_Player4ActionsCallbackInterface.OnMove;
                Move.canceled -= m_Wrapper.m_Player4ActionsCallbackInterface.OnMove;
            }
            m_Wrapper.m_Player4ActionsCallbackInterface = instance;
            if (instance != null)
            {
                Move.started += instance.OnMove;
                Move.performed += instance.OnMove;
                Move.canceled += instance.OnMove;
            }
        }
    }
    public Player4Actions @Player4 => new Player4Actions(this);
    public interface IPlayer1Actions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnAction(InputAction.CallbackContext context);
    }
    public interface IPlayer2Actions
    {
        void OnMove(InputAction.CallbackContext context);
    }
    public interface IPlayer3Actions
    {
        void OnMove(InputAction.CallbackContext context);
    }
    public interface IPlayer4Actions
    {
        void OnMove(InputAction.CallbackContext context);
    }
}
