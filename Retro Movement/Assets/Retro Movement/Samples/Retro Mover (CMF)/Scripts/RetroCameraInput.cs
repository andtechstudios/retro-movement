#pragma warning disable CS0414

using CMF;
using UnityEngine;
#if ENABLE_INPUT_SYSTEM
using UnityEngine.InputSystem;
using static RetroMovementActions;
#endif

namespace Andtech.RetroMovement {

	public class RetroCameraInput : CameraInput
#if ENABLE_INPUT_SYSTEM
		, ICameraActions
#endif
		{
		public float SensitivityX {
			get => sensitivityX;
			set => sensitivityX = value;
		}
		public float SensitivityY {
			get => sensitivityY;
			set => sensitivityY = value;
		}
		public bool InvertX {
			get => invertHorizontalInput;
			set => invertHorizontalInput = value;
		}
		public bool InvertY {
			get => invertVerticalInput;
			set => invertVerticalInput = value;
		}

		[SerializeField]
		private float sensitivityX = 1.0F;
		[SerializeField]
		private float sensitivityY = 1.0F;
		[SerializeField]
		private bool invertHorizontalInput = false;
		[SerializeField]
		private bool invertVerticalInput = false;

#if ENABLE_LEGACY_INPUT_MANAGER
		[Header("Input Settings (Legacy)")]
		[SerializeField]
		private string axisNameMouseX = "Mouse X";
		[SerializeField]
		private string axisNameMouseY = "Mouse Y";
#endif
		private Vector2 lookInput;

		public override float GetHorizontalCameraInput() {
			if (invertHorizontalInput)
				return sensitivityX * -lookInput.x;
			else
				return sensitivityX * lookInput.x;
		}

		public override float GetVerticalCameraInput() {
			if (invertVerticalInput)
				return sensitivityY * -lookInput.y;
			else
				return sensitivityY * lookInput.y;
		}


#if ENABLE_INPUT_SYSTEM
		void ICameraActions.OnLook(InputAction.CallbackContext context) => lookInput = context.ReadValue<Vector2>();
#elif ENABLE_LEGACY_INPUT_MANAGER
		protected virtual void Update() {
			lookInput.x = Input.GetAxis(axisNameMouseX);
			lookInput.y = Input.GetAxis(axisNameMouseY);
		}
#endif
	}
}
