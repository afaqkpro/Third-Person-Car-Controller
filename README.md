
# Unity Third-Person Car Controller with Enter/Exit System

This Unity project implements a third-person car controller with an interactive enter/exit system. Players can enter and exit the car, with the camera and car controller adjusting accordingly. The player can switch between driving and walking by pressing specific keys.

## Features
- Third-Person Car Controller: Allows the player to drive a car with basic controls.
- Enter/Exit Car: Players can enter and exit the car using keypresses.
- Camera Switching: When the player enters the car, the camera switches to a car-view. Exiting the car switches it back to the player-view.
- Car Controller Integration: The car's movement is controlled by the CarController script when the player is inside.

## How to Use


1. **Add the CarController Script**: Ensure your car has a CarController script attached to it. This is responsible for the car's movement.

2. **Add the EnterExitScript**: Attach the EnterExitScript to your player character or any relevant object in your scene that will handle car entry/exit interactions.

3. **Assign References**: In the EnterExitScript, assign the following public variables:
   - **pCarController**: Drag and drop the car's CarController component here.
   - **CarCam**: Assign the camera that will follow the car when the player enters it.
   - **PlayerCamera**: Assign the camera that follows the player when they are not in the car.
   - **car**: Assign the car's transform to this field.

4. **Tagging the Player**: Make sure the player GameObject is tagged with Player, as the script searches for it by this tag.

5. **Control Keys**:
   - **K**: Press this key when near the car to enter the car.
   - **L**: Press this key while in the car to exit the car.

### How It Works

- **Entering the Car**: When the player presses the K key while standing near the car, the player's transform becomes a child of the car, and the player character is hidden. The camera switches to the car view, and the car controller is enabled, allowing the player to drive the car.
  
- **Exiting the Car**: When the player presses the L key while inside the car, the player exits the car, the camera switches back to the player’s third-person view, and the car controller is disabled.

### Optional: Audio Effects
You can enable sound effects for the car engine and door animations by uncommenting the following lines in the script:
- carEngine.enabled: Toggle car engine sound.
- openCloseDoor.Play(): Play a door opening/closing sound.
