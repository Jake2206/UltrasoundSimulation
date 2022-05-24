## Ultrasound Training Simulation

Created with advisement from Dr. Steven Feiner, Dr. Robert Maniker, and Dr. David Kessler

![yayy](yayy.png)

## Development platform

Deployment platform: Oculus Quest (1 or 2, but only tested on 2)
Tools:
Unity 2019.4.38f1.
Oculus Integration
MRTK v2.5.3
XR Plugin management v3.2.17
Post Processing v3.0.3

In order to build and deploy the project, please ensure that you are running Unity 2019.4.38f1 with Android build support installed.
-Turn on developer mode on the Quest
-Open the Oculus mobile app
-Select your Quest from the Devices menu
-Select Developer Mode and toggle it to true
-Connect the Oculus Quest to your computer
-Open the project in Unity 2019.4.38f1
-Open File → Build Settings and ensure that the following options are selected
	-Scenes: Scene/mainScene
	-Target: Android
	-Run Device: <Your Quest>
-Select Build And Run


## Mobile platforms, OS versions, and device names (and server platform, if any)

Oculus Quest

## Project directory overview

The main scene is at: Assets/Scenes/mainScene
The scripts are at: Assets/Scripts and Assets
The probe package is at: Assets/Scenes/ProbePackage

## Video demo
[YouTube Video Demo](https://youtu.be/UDimmVQ6zYE)

## Usage guide
Probe
-- Switch probe types: Switch Probe button on the ultrasound screen.

Image Panel
-- Grab and drag with the pointer or virtual hand (for the pointer pinch forefinger and thumb together to grab).

Teleport
-- Make a backwards L with your left hand and aim the pointer that appears.
-- Confirm: pull your forefinger towards your palm.

Travel
-- Walk around with your body


## Credit
The body model was borrowed from https://github.com/hoodlm/affordable-medical-ultrasound-training-simulator


