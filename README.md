# Unity-VisionLib-echoAR-demo-Model-Tracking
Demo that tracks 3D Models with Unity, VisionLib, and echoAR.

## Register
Don't have an API key? Make sure to register for FREE at [echoAR](https://console.echoar.xyz/#/auth/register).

## Setup
* Download and install the VisionLib SDK in a new Unity project.
* Follow the instructions on our [doumention page](https://docs.echoar.xyz/unity/adding-ar-capabilities) to [set your API key](https://docs.echoar.xyz/unity/adding-ar-capabilities#3-set-you-api-key).
* Add the mini car model to the [console](https://docs.echoar.xyz/quickstart/add-a-3d-model) from the [Models](https://github.com/echoARxyz/Unity-ARFoundation-echoAR-demo-Living-Room-TV/tree/master/assets) folder.
* Overwrite the existing _echoAR/CustomBehavior.cs script with the new [CustomBehavior](https://github.com/echoARxyz/Unity-ARFoundation-echoAR-demo-Living-Room-TV/blob/master/CustomBehavior.cs) file.
* Set up a Model Tracking scene using [VisionLib's] (https://visionlib.com/documentation/vl_unity_s_d_k_model_tracker_tutorial/) instructions, using carEcho.vl and ModelTrackingScript.cs in the Scripts folder instead of TutorialModelTracker.vl and Tutorial.cs.
* Tag the VLCamera Object as MainCamera in your scene.
* Print out and build VisionLib's car target to test the model tracking.


## Run
* [Build and run the AR application](https://docs.echoar.xyz/unity/adding-ar-capabilities#4-build-and-run-the-ar-application).


## Learn more
Refer to our [documentation](https://docs.echoar.xyz/unity/) to learn more about how to use Unity, AR Foundation, and echoAR.

## Support
Feel free to reach out at [support@echoAR.xyz](mailto:support@echoAR.xyz) or join our [support channel on Slack](https://join.slack.com/t/echoar/shared_invite/enQtNTg4NjI5NjM3OTc1LWU1M2M2MTNlNTM3NGY1YTUxYmY3ZDNjNTc3YjA5M2QyNGZiOTgzMjVmZWZmZmFjNGJjYTcxZjhhNzk3YjNhNjE). 

## Screenshots
![console](/screenshots/echoAR_Console.png)
![screenshot](/screenshots/Screenshot.gif)
