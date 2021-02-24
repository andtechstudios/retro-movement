/*
 *	Copyright (c) 2020, AndrewMJordan
 *	All rights reserved.
 *	
 *	This source code is licensed under the BSD-style license found in the
 *	LICENSE file in the root directory of this source tree
 */

#pragma warning disable CS0414

using CMF;
using UnityEngine;
#if ENABLE_INPUT_SYSTEM
using UnityEngine.InputSystem;
using static RetroMovementActions;
#endif

namespace Andtech.RetroMovement {

	public class RetroCharacterInput : CharacterInput
#if ENABLE_INPUT_SYSTEM
		, IMovementActions
#endif
		{
#if ENABLE_LEGACY_INPUT_MANAGER
		[Header("Input Settings (Legacy)")]
		[SerializeField]
		private string axisNameHorizontal = "Horizontal";
		[SerializeField]
		private string axisNameVertical = "Vertical";
		[SerializeField]
		private string buttonNameJump = "Jump";
		[SerializeField]
		private string buttonNameSprint = "Sprint";
		[SerializeField]
		private string buttonNameCrouch = "Crouch";
#endif

		private Vector2 movementInput;
		private bool requestedJump;
		private bool requestedSprint;
		private bool requestedCrouch;

		public bool IsSprintKeyPressed() => requestedSprint;

		public override float GetHorizontalMovementInput() => movementInput.x;

		public override float GetVerticalMovementInput() => movementInput.y;

		public override bool IsJumpKeyPressed() => requestedJump;

#if ENABLE_INPUT_SYSTEM
		void IMovementActions.OnMove(InputAction.CallbackContext context) => movementInput = context.ReadValue<Vector2>();

		void IMovementActions.OnJump(InputAction.CallbackContext context) => requestedJump = context.ReadValueAsButton();

		void IMovementActions.OnCrouch(InputAction.CallbackContext context) => requestedCrouch = context.ReadValueAsButton();

		void IMovementActions.OnSprint(InputAction.CallbackContext context) => requestedSprint = context.ReadValueAsButton();
#elif ENABLE_LEGACY_INPUT_MANAGER
		protected virtual void Update() {
			movementInput.x = Input.GetAxis(axisNameHorizontal);
			movementInput.y = Input.GetAxis(axisNameVertical);
			requestedJump = Input.GetButton(buttonNameJump);
			requestedSprint = Input.GetButton(buttonNameSprint);
			requestedCrouch = Input.GetButton(buttonNameCrouch);
		}
#endif
	}
}
