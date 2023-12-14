//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.6.3
//     from Assets/InputAction.inputactions
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

public partial class @IA: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @IA()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputAction"",
    ""maps"": [
        {
            ""name"": ""BUZZ"",
            ""id"": ""b0386ac0-10a8-456a-b662-6632b2ab4eee"",
            ""actions"": [
                {
                    ""name"": ""dvizhenie"",
                    ""type"": ""Value"",
                    ""id"": ""2c08eb71-c51a-4c2b-9361-0833a41a400a"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""prizok"",
                    ""type"": ""Button"",
                    ""id"": ""d7a269dc-1450-4559-bfa9-fdff7f347216"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""otok"",
                    ""type"": ""Button"",
                    ""id"": ""d82d0628-3c99-47f5-9efb-03147b7d5847"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""transmode"",
                    ""type"": ""Button"",
                    ""id"": ""2009b174-28ad-4ddf-8f32-f63480660aac"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""kartofel"",
                    ""type"": ""Button"",
                    ""id"": ""964ae3ca-c448-441d-843f-742519e12c85"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""07e6aed3-d882-4fd1-8434-cb130cb06532"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""dvizhenie"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""eeba7b9e-806b-4536-ac5c-09e5e588e4b7"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""dvizhenie"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""319c770d-6106-4845-a8a1-3f25963f4d22"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""dvizhenie"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""1b0d7216-5c50-4b03-a338-a10b0b0a5351"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""dvizhenie"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""117d5908-b5c5-49d0-ba23-6bd516079870"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""dvizhenie"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""f87dbe10-a1e6-4156-a8a2-92b517125173"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""prizok"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""337c13b0-0b66-41da-acb3-422284c3f70d"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""otok"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""20f7f4ef-9a1e-43c1-b1fa-dbad34d1932c"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""transmode"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3d91ac3c-c0f0-4167-a55c-e05c36324b37"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""kartofel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""dialogesustim"",
            ""id"": ""29209ab8-84ad-4e6f-aa4e-d2cde41f0821"",
            ""actions"": [
                {
                    ""name"": ""sledush"",
                    ""type"": ""Button"",
                    ""id"": ""64a10116-fbcc-401a-907f-fa21fc8a9923"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""ef50633e-474d-470b-9524-1f07a5c48302"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""sledush"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // BUZZ
        m_BUZZ = asset.FindActionMap("BUZZ", throwIfNotFound: true);
        m_BUZZ_dvizhenie = m_BUZZ.FindAction("dvizhenie", throwIfNotFound: true);
        m_BUZZ_prizok = m_BUZZ.FindAction("prizok", throwIfNotFound: true);
        m_BUZZ_otok = m_BUZZ.FindAction("otok", throwIfNotFound: true);
        m_BUZZ_transmode = m_BUZZ.FindAction("transmode", throwIfNotFound: true);
        m_BUZZ_kartofel = m_BUZZ.FindAction("kartofel", throwIfNotFound: true);
        // dialogesustim
        m_dialogesustim = asset.FindActionMap("dialogesustim", throwIfNotFound: true);
        m_dialogesustim_sledush = m_dialogesustim.FindAction("sledush", throwIfNotFound: true);
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

    // BUZZ
    private readonly InputActionMap m_BUZZ;
    private List<IBUZZActions> m_BUZZActionsCallbackInterfaces = new List<IBUZZActions>();
    private readonly InputAction m_BUZZ_dvizhenie;
    private readonly InputAction m_BUZZ_prizok;
    private readonly InputAction m_BUZZ_otok;
    private readonly InputAction m_BUZZ_transmode;
    private readonly InputAction m_BUZZ_kartofel;
    public struct BUZZActions
    {
        private @IA m_Wrapper;
        public BUZZActions(@IA wrapper) { m_Wrapper = wrapper; }
        public InputAction @dvizhenie => m_Wrapper.m_BUZZ_dvizhenie;
        public InputAction @prizok => m_Wrapper.m_BUZZ_prizok;
        public InputAction @otok => m_Wrapper.m_BUZZ_otok;
        public InputAction @transmode => m_Wrapper.m_BUZZ_transmode;
        public InputAction @kartofel => m_Wrapper.m_BUZZ_kartofel;
        public InputActionMap Get() { return m_Wrapper.m_BUZZ; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(BUZZActions set) { return set.Get(); }
        public void AddCallbacks(IBUZZActions instance)
        {
            if (instance == null || m_Wrapper.m_BUZZActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_BUZZActionsCallbackInterfaces.Add(instance);
            @dvizhenie.started += instance.OnDvizhenie;
            @dvizhenie.performed += instance.OnDvizhenie;
            @dvizhenie.canceled += instance.OnDvizhenie;
            @prizok.started += instance.OnPrizok;
            @prizok.performed += instance.OnPrizok;
            @prizok.canceled += instance.OnPrizok;
            @otok.started += instance.OnOtok;
            @otok.performed += instance.OnOtok;
            @otok.canceled += instance.OnOtok;
            @transmode.started += instance.OnTransmode;
            @transmode.performed += instance.OnTransmode;
            @transmode.canceled += instance.OnTransmode;
            @kartofel.started += instance.OnKartofel;
            @kartofel.performed += instance.OnKartofel;
            @kartofel.canceled += instance.OnKartofel;
        }

        private void UnregisterCallbacks(IBUZZActions instance)
        {
            @dvizhenie.started -= instance.OnDvizhenie;
            @dvizhenie.performed -= instance.OnDvizhenie;
            @dvizhenie.canceled -= instance.OnDvizhenie;
            @prizok.started -= instance.OnPrizok;
            @prizok.performed -= instance.OnPrizok;
            @prizok.canceled -= instance.OnPrizok;
            @otok.started -= instance.OnOtok;
            @otok.performed -= instance.OnOtok;
            @otok.canceled -= instance.OnOtok;
            @transmode.started -= instance.OnTransmode;
            @transmode.performed -= instance.OnTransmode;
            @transmode.canceled -= instance.OnTransmode;
            @kartofel.started -= instance.OnKartofel;
            @kartofel.performed -= instance.OnKartofel;
            @kartofel.canceled -= instance.OnKartofel;
        }

        public void RemoveCallbacks(IBUZZActions instance)
        {
            if (m_Wrapper.m_BUZZActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IBUZZActions instance)
        {
            foreach (var item in m_Wrapper.m_BUZZActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_BUZZActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public BUZZActions @BUZZ => new BUZZActions(this);

    // dialogesustim
    private readonly InputActionMap m_dialogesustim;
    private List<IDialogesustimActions> m_DialogesustimActionsCallbackInterfaces = new List<IDialogesustimActions>();
    private readonly InputAction m_dialogesustim_sledush;
    public struct DialogesustimActions
    {
        private @IA m_Wrapper;
        public DialogesustimActions(@IA wrapper) { m_Wrapper = wrapper; }
        public InputAction @sledush => m_Wrapper.m_dialogesustim_sledush;
        public InputActionMap Get() { return m_Wrapper.m_dialogesustim; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DialogesustimActions set) { return set.Get(); }
        public void AddCallbacks(IDialogesustimActions instance)
        {
            if (instance == null || m_Wrapper.m_DialogesustimActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_DialogesustimActionsCallbackInterfaces.Add(instance);
            @sledush.started += instance.OnSledush;
            @sledush.performed += instance.OnSledush;
            @sledush.canceled += instance.OnSledush;
        }

        private void UnregisterCallbacks(IDialogesustimActions instance)
        {
            @sledush.started -= instance.OnSledush;
            @sledush.performed -= instance.OnSledush;
            @sledush.canceled -= instance.OnSledush;
        }

        public void RemoveCallbacks(IDialogesustimActions instance)
        {
            if (m_Wrapper.m_DialogesustimActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IDialogesustimActions instance)
        {
            foreach (var item in m_Wrapper.m_DialogesustimActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_DialogesustimActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public DialogesustimActions @dialogesustim => new DialogesustimActions(this);
    public interface IBUZZActions
    {
        void OnDvizhenie(InputAction.CallbackContext context);
        void OnPrizok(InputAction.CallbackContext context);
        void OnOtok(InputAction.CallbackContext context);
        void OnTransmode(InputAction.CallbackContext context);
        void OnKartofel(InputAction.CallbackContext context);
    }
    public interface IDialogesustimActions
    {
        void OnSledush(InputAction.CallbackContext context);
    }
}
