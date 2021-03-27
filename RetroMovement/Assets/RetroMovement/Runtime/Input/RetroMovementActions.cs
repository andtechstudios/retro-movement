// GENERATED AUTOMATICALLY FROM 'Assets/Retro Movement/Runtime/Input/RetroMovementActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @RetroMovementActions : IInputActionCollection, IDisposable {
	public InputActionAsset asset { get; }
	public @RetroMovementActions() {
		asset = InputActionAsset.FromJson(@"{
    ""name"": ""RetroMovementActions"",
    ""maps"": [
        {
            ""name"": ""Movement"",
            ""id"": ""5358e8a3-52a8-4ba6-a833-c7e6ca5b7d86"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""88360514-7776-4562-a6cf-7565bb47caa7"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""9e49f74d-c835-49df-850d-caa23897ca33"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Crouch"",
                    ""type"": ""Button"",
                    ""id"": ""cc65681f-e34c-4c90-9ce7-e07616810716"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Sprint"",
                    ""type"": ""Button"",
                    ""id"": ""ed8902f7-4540-402f-a77c-3662043f3630"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""62b953d4-4760-4cf1-a60a-6baae23c5f62"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Desktop"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4de443b4-a1c8-4a5d-817e-5589a9254b32"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""95f116bf-9633-493c-b01b-14faa77d4579"",
                    ""path"": ""2DVector(mode=1)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Up"",
                    ""id"": ""b8366aa5-0c3b-45e2-aad2-312ab66f1893"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Desktop"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Down"",
                    ""id"": ""ba33eb6f-71f3-4cfe-bbc5-8c2b01f65c2f"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Desktop"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Left"",
                    ""id"": ""40e1bc42-3652-43ad-89d8-a38a7fe0331c"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Desktop"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Right"",
                    ""id"": ""0a853853-f578-4d71-96aa-09514025568c"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Desktop"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""269a6783-a84d-4ed4-bf31-976f141d6e01"",
                    ""path"": ""2DVector(mode=1)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""e8bae448-4a16-4d21-b393-6655900196c7"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""44d467eb-74ae-475e-bd07-b2225f6461c4"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""105e17cd-7957-4bd1-9934-1bde768c1fed"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""ec21cf14-ba08-4d31-98c5-a85b82565235"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""3f6ab10b-e152-48a5-954a-4943eb5620fa"",
                    ""path"": ""<Keyboard>/ctrl"",
                    ""interactions"": ""Hold"",
                    ""processors"": """",
                    ""groups"": ""Desktop"",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c45665e6-c296-4083-ad4a-cd3fda76b052"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": ""Hold"",
                    ""processors"": """",
                    ""groups"": ""Desktop"",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d2fd24bc-17be-45f8-a3a9-6d22c5e37707"",
                    ""path"": ""<Gamepad>/leftStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Camera"",
            ""id"": ""c5e47e9b-2ed7-4610-90d9-b2b51a7570fc"",
            ""actions"": [
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""8f3c8af7-84c3-4046-b3da-55b87d924009"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""374c30d1-a7d3-49d2-9559-74cfb5da9af0"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Desktop"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""223ce922-f910-4817-be0a-92d4c06f39f9"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": ""ScaleVector2(x=5.5,y=5.5)"",
                    ""groups"": ""Joystick"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Desktop"",
            ""bindingGroup"": ""Desktop"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Joystick"",
            ""bindingGroup"": ""Joystick"",
            ""devices"": []
        }
    ]
}");
		// Movement
		m_Movement = asset.FindActionMap("Movement", throwIfNotFound: true);
		m_Movement_Move = m_Movement.FindAction("Move", throwIfNotFound: true);
		m_Movement_Jump = m_Movement.FindAction("Jump", throwIfNotFound: true);
		m_Movement_Crouch = m_Movement.FindAction("Crouch", throwIfNotFound: true);
		m_Movement_Sprint = m_Movement.FindAction("Sprint", throwIfNotFound: true);
		// Camera
		m_Camera = asset.FindActionMap("Camera", throwIfNotFound: true);
		m_Camera_Look = m_Camera.FindAction("Look", throwIfNotFound: true);
	}

	public void Dispose() {
		UnityEngine.Object.Destroy(asset);
	}

	public InputBinding? bindingMask {
		get => asset.bindingMask;
		set => asset.bindingMask = value;
	}

	public ReadOnlyArray<InputDevice>? devices {
		get => asset.devices;
		set => asset.devices = value;
	}

	public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

	public bool Contains(InputAction action) {
		return asset.Contains(action);
	}

	public IEnumerator<InputAction> GetEnumerator() {
		return asset.GetEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator() {
		return GetEnumerator();
	}

	public void Enable() {
		asset.Enable();
	}

	public void Disable() {
		asset.Disable();
	}

	// Movement
	private readonly InputActionMap m_Movement;
	private IMovementActions m_MovementActionsCallbackInterface;
	private readonly InputAction m_Movement_Move;
	private readonly InputAction m_Movement_Jump;
	private readonly InputAction m_Movement_Crouch;
	private readonly InputAction m_Movement_Sprint;
	public struct MovementActions {
		private @RetroMovementActions m_Wrapper;
		public MovementActions(@RetroMovementActions wrapper) { m_Wrapper = wrapper; }
		public InputAction @Move => m_Wrapper.m_Movement_Move;
		public InputAction @Jump => m_Wrapper.m_Movement_Jump;
		public InputAction @Crouch => m_Wrapper.m_Movement_Crouch;
		public InputAction @Sprint => m_Wrapper.m_Movement_Sprint;
		public InputActionMap Get() { return m_Wrapper.m_Movement; }
		public void Enable() { Get().Enable(); }
		public void Disable() { Get().Disable(); }
		public bool enabled => Get().enabled;
		public static implicit operator InputActionMap(MovementActions set) { return set.Get(); }
		public void SetCallbacks(IMovementActions instance) {
			if (m_Wrapper.m_MovementActionsCallbackInterface != null) {
				@Move.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnMove;
				@Move.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnMove;
				@Move.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnMove;
				@Jump.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnJump;
				@Jump.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnJump;
				@Jump.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnJump;
				@Crouch.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnCrouch;
				@Crouch.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnCrouch;
				@Crouch.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnCrouch;
				@Sprint.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnSprint;
				@Sprint.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnSprint;
				@Sprint.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnSprint;
			}
			m_Wrapper.m_MovementActionsCallbackInterface = instance;
			if (instance != null) {
				@Move.started += instance.OnMove;
				@Move.performed += instance.OnMove;
				@Move.canceled += instance.OnMove;
				@Jump.started += instance.OnJump;
				@Jump.performed += instance.OnJump;
				@Jump.canceled += instance.OnJump;
				@Crouch.started += instance.OnCrouch;
				@Crouch.performed += instance.OnCrouch;
				@Crouch.canceled += instance.OnCrouch;
				@Sprint.started += instance.OnSprint;
				@Sprint.performed += instance.OnSprint;
				@Sprint.canceled += instance.OnSprint;
			}
		}
	}
	public MovementActions @Movement => new MovementActions(this);

	// Camera
	private readonly InputActionMap m_Camera;
	private ICameraActions m_CameraActionsCallbackInterface;
	private readonly InputAction m_Camera_Look;
	public struct CameraActions {
		private @RetroMovementActions m_Wrapper;
		public CameraActions(@RetroMovementActions wrapper) { m_Wrapper = wrapper; }
		public InputAction @Look => m_Wrapper.m_Camera_Look;
		public InputActionMap Get() { return m_Wrapper.m_Camera; }
		public void Enable() { Get().Enable(); }
		public void Disable() { Get().Disable(); }
		public bool enabled => Get().enabled;
		public static implicit operator InputActionMap(CameraActions set) { return set.Get(); }
		public void SetCallbacks(ICameraActions instance) {
			if (m_Wrapper.m_CameraActionsCallbackInterface != null) {
				@Look.started -= m_Wrapper.m_CameraActionsCallbackInterface.OnLook;
				@Look.performed -= m_Wrapper.m_CameraActionsCallbackInterface.OnLook;
				@Look.canceled -= m_Wrapper.m_CameraActionsCallbackInterface.OnLook;
			}
			m_Wrapper.m_CameraActionsCallbackInterface = instance;
			if (instance != null) {
				@Look.started += instance.OnLook;
				@Look.performed += instance.OnLook;
				@Look.canceled += instance.OnLook;
			}
		}
	}
	public CameraActions @Camera => new CameraActions(this);
	private int m_DesktopSchemeIndex = -1;
	public InputControlScheme DesktopScheme {
		get {
			if (m_DesktopSchemeIndex == -1) m_DesktopSchemeIndex = asset.FindControlSchemeIndex("Desktop");
			return asset.controlSchemes[m_DesktopSchemeIndex];
		}
	}
	private int m_JoystickSchemeIndex = -1;
	public InputControlScheme JoystickScheme {
		get {
			if (m_JoystickSchemeIndex == -1) m_JoystickSchemeIndex = asset.FindControlSchemeIndex("Joystick");
			return asset.controlSchemes[m_JoystickSchemeIndex];
		}
	}
	public interface IMovementActions {
		void OnMove(InputAction.CallbackContext context);
		void OnJump(InputAction.CallbackContext context);
		void OnCrouch(InputAction.CallbackContext context);
		void OnSprint(InputAction.CallbackContext context);
	}
	public interface ICameraActions {
		void OnLook(InputAction.CallbackContext context);
	}
}
