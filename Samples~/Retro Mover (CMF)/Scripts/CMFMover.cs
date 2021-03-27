/*
 *	Copyright (c) 2021, AndtechGames
 *	All rights reserved.
 *	
 *	This source code is licensed under the BSD-style license found in the
 *	LICENSE file in the root directory of this source tree
 */

using UnityEngine;

namespace Andtech.RetroMovement {

	public class CMFMover : MonoBehaviour {
		public RetroMovementActions MovementActions { get; private set; }
#if ENABLE_INPUT_SYSTEM
		public RetroMovementActions.IMovementActions IMovementActions => characterInput;
		public RetroMovementActions.ICameraActions ICameraActions => cameraInput;
#endif
		[SerializeField]
		private RetroCharacterInput characterInput;
		[SerializeField]
		private RetroCameraInput cameraInput;

		protected virtual void OnEnable() {
			Cursor.visible = false;
			Cursor.lockState = CursorLockMode.Locked;
		}

		protected virtual void OnDisable() {
			Cursor.visible = true;
			Cursor.lockState = CursorLockMode.None;
		}

#if ENABLE_INPUT_SYSTEM
		protected virtual void Start() {
			var movementActions = new RetroMovementActions();
			movementActions.Movement.SetCallbacks(characterInput);
			movementActions.Camera.SetCallbacks(cameraInput);

			movementActions.Enable();

			MovementActions = movementActions;
		}
#endif
	}
}
