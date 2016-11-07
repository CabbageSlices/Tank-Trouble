using UnityEngine;
using System.Collections;

public static class InputManager {

	public static bool isUpPressed(int joypadNumber) {

        return Input.GetAxis("Vertical" + joypadNumber) > 0;
    }

    public static bool isDownPressed(int joypadNumber) {

        return Input.GetAxis("Vertical" + joypadNumber) < 0;
    }

    public static bool isLeftPressed(int joypadNumber) {
        
        return Input.GetAxis("Horizontal" + joypadNumber) < 0;
    }

    public static bool isRightPressed(int joypadNumber) {

        return Input.GetAxis("Horizontal" + joypadNumber) > 0;
    }
}
