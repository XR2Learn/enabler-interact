INTERACT Change Log

# 23.09.00
### Added
- [PHYSICS] Beams can now perform auto-collisions. What a way to tie the knot!
- [PHYSICS] Add coulomb friction on beams.
- [PHYSICS] Add cylindrical and planar joints.
- [VR] You can now use Manus gloves with full body tracking. This allows ergonomics analysis with precise hands tracking.
- [EDITOR] Warn the user if we try to physicalize a "Static" object.
- [EDITOR] Ruler, axis picking and snapping tool now ignore hidden and non-pickable objects.
- [CORE] Add support for 3Dconnexion SpaceMouse Enterprise
- [EDITOR] Snapping tool can now work with empty GameObject, which can be useful to setup attach points for cable at a specific location.
- [EDITOR] Add a tool to update the project references from older Interact versions.

### Fixed

- [CORE] When building over an existing build that was compiled with older binaries, we had build issues since servers executable were not overwritten.
- [CORE] Keep server functional when solver integration fails.
- [CORE] Add meta files for *FrontCol.mat* and *Steve_Ed.mat* that used to be automatically generated when importing *art_set_square*.
- [CORE] Fix spacemouse that wasn't properly recognized.
- [CORE] Using the desktop manipulator now properly trigger Weld and snap events. We should now have a similar behavior between VR player and desktop player when using scenario keypoints.
- [CORE] Fix persistence files not being included in built executables.
- [CORE] While using DesktopManipulator, a single click made targeted rigid body attached to camera movement.
- [CORE] Fix contact arrows that were not displayed correctly in built executables.
- [CORE] DesktopManipulator ray width is now based on distance to ease visibility.
- [PHYSICS] Avoid considering disabled RigidBody as a valid parent for joints, to prevent misleading positioning teleportation at start.
- [PHYSICS] Repair `XdeDryFrictionMonitor` component to monitor friction values.
- [PHYSICS] Fix use of initialVelocity for HelicalJoint, especially during start/stop.
- [CABLE] Fix cable issue where the beam was flying away when moved with gizmo.
- [EDITOR] Fix mouse scrolling that conflicted between camera controller and Unity editor.
- [EDITOR] When undoing physicalization, XdeRigidbody and colliders were not removed.
- [EDITOR] Fix lag when using the ruler custom editor tool.
- [EDITOR] Fix ghosts parts that were appearing randomly when using snapping tool.
- [EDITOR] Fix pick axis flickering when an object had both a MeshCollider and a BoxCollider.
- [EDITOR] Set the ground as a "non-pickable" objects for default environment.
- [EDITOR] Interact Preferences windows was lagging.
- [EDITOR] Pick axis was not undoable.
- [EDITOR] Fix "Compute dynamic parameters" button that was not working.
- [EDITOR] Fix "Generate Persistence file" button that was not working in editor.
- [POINTCLOUD] Indicate that a pointcloud might be corrupted if we can detect it.
- [CAVE] Fix Cave regression that prevented replicas server to start properly.
- [VR] Remove *SelectCam* from Desktop player - not used anymore. 
- [VR] Measure tool was broken while using Fly at the same time.
- [VR] Fix laser from menu always being visible in grab mode.
- [VR] Multiples fixes for visual glitches related to VR menu.
- [VR] Fix leapmotion player rotating indefinitely.
- [VR] Fix right hand not working with leapmotion.
- [VR] Fix painter not drawing when in front of the menu.
- [VR] Fix calibrate height *NullReferenceException* on calibrate.
- [VR] Fix teleportation ray being too low when the player was not on the ground.
- [SCENARIO] Disabled steps are considered as completed dependencies.
- [SCENARIO] Add recursive ghost target display of the physical children part.
- [SCENARIO] Correct position alignment when only one or two dimensions of the interest point position are kept.

### API Changes
- [CORE] Minimal supported version for Unity is now 2021.3.27f1.
- [PHYSICS] Mapped Joint scale and offset can be modified at runtime. When the scale is modified, the offset is also modified so as to keep the current position of the mapped joint.
- [NETWORK] Breaking change: all 'clientId' members are now removed from related components and should be replaced by a XdeIdentity next to the component (if sending data should be filtered over the network)
- [NETWORK] Developers can now choose how to send data over the network (per component), by adding a XdeIdentity component or a custom IXdePermissionFilter component on the GameObject
Add WeldAsync/UnweldAsync/ReweldAsync methods to XdeWeldableJoints.
  The old methods Weld/Unweld/Reweld now return void, please use WeldAsync/UnweldAsync/ReweldAsync if you want to await the result.
- [CORE] The body parameter of the `XdeMeshCollider` is now a read-only property (replace body by Body in your scripts).
- [CAVE] Rename master/slave by primary/replica.
- [CORE] Deprecate `UnweldWhenGrasped`. It is advised to use *Weld Object to void when detached* in `XdeAsbOperatorGraspManipulator` instead.
- [EDITOR] Remove Show contacts arrows and velocity preferences from preferences. This is still customizable in `PhysicsManager` component.

## Version 23.06.02
### Fixed
- [VR] Fix screenshot not having the same culling mask as main cam.
- [VR] Fix teleport initialization time.
- [EDITOR] Fix mouse scrolling that conflicted between camera controller and Unity editor.
- [EDITOR] Fix *Apply transform* result that was not saved properly.
- [COLLAB] Fix user selection window not adapting to screen size.
- [COLLAB] Fix *NullReferenceException* when culling other desktop players.

## Version 23.06.01
### Fixed
- [CORE] Fix missing scripts in Tutorials scenes.

## Version 23.06.00
### Added
- [EDITOR] Picking tool to get a node index on a cable and its curvature.
- [EDITOR] Snapping tool to move an object to another using geometric constraint solver.
- [PHYSICS] Enable multi-selection for physicalize.
- [PHYSICS] Custom value for the number of cables nodes, in preferences.

### Fixed
- [PHYSICS] Fix default number of nodes per meters to 50.
- [CAVE] Fix configuration file import and gamma serialization.
- [CORE] Fix missing file for Optitrack server.
- [CORE] Fix exception in Player color when there are more than 8 players.

## Version 23.03.02
### Fixed
- [CORE] Fix servers not being started properly
- [CORE] Fix ART server process not starting
- [CORE] Fix Optitrack server process not starting

## Version 23.03.01
### Fixed
- [CORE] Fix laser grab not working through VRMenu
- [CORE] Fix laser force to move in a easier way

## Version 23.03.00
### Added
- [CORE] Add interactive tutorial to get started with Interact!
learn how to add physics and behaviors on your scene.
- [VR] Add support for Manus quantum. Finger tracking reliability has been improved.
- [PHYSICS] Enable multi-selection for cable physicalization.

### Fixed
- [VR] Fix cross-section that was duplicated when used multi-times.
- [CORE] Fix Pixyz menu error when installing Pixyx package 2022.1.
- [VR] Fix laser grab being replaced by menu laser when grabbing.
- [CORE] Fix shaders errors when building an executable.
- [CORE] Fix prefabs content duplication related to Teleport.
- [CORE] Delete unused background textures.
- [CORE] Fix *NullReferenceException* when opening *Export to FBX* menu.
- [CORE] Required packages dependencies are now installed by default. It will try to use the Unity Package Manager to install those if accessible, or fallback to embedded ones if network or Unity repository are not available.
- [ERGO] Ergo panel was hiding multiplayer selection on start.
- [VR] Fix controller rumbling continuously when hovering menu move button.
- [CORE] Fix build not working when there was no player named *[Player 1]*.
- [ERGO] Remove unclickable buttons from ergo panel .

## Version 23.01.03
### Fixed
- [CORE] Fix issue on *Prefabs*, mainly related to *Fly mode*, missing references while importing the package.

## Version 23.01.02
### Fixed
- [CORE] Fix SteamVR bindings popup while importing package.
- [CORE] Fix compilation for application built with Interact.
- [ERGO] Fix physics engine that do not start automatically while using ergonomic player.

## Version 23.01.01
### Added
- [EDITOR] Add ability to cancel Pick Axis by pressing the escape key.

### Changed
- [EDITOR] Remove install of unused dependency.

### Fixed
- [CORE] Fix a *NullReferenceException* on ergo player.
- [CORE] Fix normalized arrow elements not being linked in Unity 2021.
- [EDITOR] Fix empty assembly definitions causing warnings.

## Version 23.01.00
### Added
- [EDITOR] Support for Pixyz 2022.1.
- [EDITOR] Multi-selection is now working for dephysicalize command.
- [CORE] Export kinematic as URDF file. URDF file compatible with ROS - Robot Operating System - can be exported.
- [ERGO] HumanManager component now has an `AvatarModes` field to choose whether you display ergonomics manikin or standard avatar.

### Changed
- [VR] Change screenshot tool orientation to be more ergonomic.
- [VR] Reduce cross-section red line border size. 

### Deleted
- [LIBRARY] Remove ButtonState.ERROR which was not used in ButtonController enum.

### Fixed
- [CORE] Remove unused mesh on industrials models.
- [CORE] Fix missing dependency when using *Export To FBX* menu.
- [CORE] Fix progressbar stuck for 2D layout import.
- [POINTCLOUD] Fix teleportation on point clouds.
- [POINTCLOUD] Fix null reference when deleting point cloud.
- [ERGO] Fix *NullReferenceException* when trying to re-calibrate through VR menu.
- [ERGO] Fix T-pose picture to have legs in the correct position.
- [ERGO] Fix inverted controllers when using Vive trackers auto-assignation.
- [ERGO] Fix Vive trackers auto-assignation when player was moved away from scene origin.
- [EDITOR] Fix url to cable documentation in cable window.
- [EDITOR] Remove a warning about missing meta files.
- [EDITOR] Now return a warning instead of an error when a geometry is missing in an URDF file.
- [EDITOR] Fix pick axis to only select visible parts when hidden layers are used.
- [EDITOR] Dephysicalize command was not removing *XdeExternalWrench* component. 
- [PHYSICS] Fix *UnweldWhenGrasped* component to work with multi-users and leap motion.

## Version 22.09.06
### Fixed
- [ERGO] Fix ergonomic manikin with Vive trackers that fails to initialize.

## Version 22.09.05
### Fixed
- [POINTCLOUD] Fix a licensing issue that prevented point cloud import.

## Version 22.09.04
### Fixed
- [CORE] Fix an exception when using Pick Axis on a shape with a collider other than a mesh collider
- [CORE] Add height calibration to VR player
- [CORE] Fix error when the 3D model is not is STL format by creating a object instead of showing an error
- [POINTCLOUD] Fix progress bar when loading a point cloud
- [IMMERSION] Fix the reset of trackers assignation in case where calibration was not set by VR Menu

### Changed
- [IMMERSION] Stay on tpose panel if assignation failed instead of canceling calibration

## Version 22.09.03
### Fixed
- [CORE] Script reimporter sometimes causes compilation errors.

## Version 22.09.02
### Fixed
- [CORE] Remove useless audio listener that generated a warning.
- [VR] Fix menu losing focus when moving too fast.
- [VR] Fix a regression while using VR player in multi-users.
- [VR] Fix menu move button that needed to be pressed twice to react.
- [VR] Menu was not bind to the right button while using Valve index knuckles.
- [CABLE] Fix crash happening when cable had degenerate triangles.
- [CABLE] Warn user when *isReadable* property has not been properly set.
- [CABLE] Fix wrong detection of some cable when winding number was not correct.
- [CABLE] Weight is now disabled by default for cable attach point.
- [COLLAB] Fix missing label on user selection popup.
- [LIBRARY] Add missing *XdeMeshCollider* on FANUC M20 prefab.

### Changed
- [CABLE] Default value is now false for *preformed* property.
- [CORE] *CameraController* values were a bit too sensitive.

## Version 22.09.01
### Fixed
- [VR] Fix conflicts between openvr dll.
- [CORE] Fix UnassignedReferenceException on *FlyArrow* prefab.
- [CORE] Fix NullRefException happening when we instantiate prefab without a *PhysicsManager*.
- [CORE] *StartServers* should not be mandatory for a valid simulation.
- [EDITOR] Fix unwanted modifications when using multiple selection on *XdeJoint*.
- [LIBRARY] Fix redundant *LayerRef* in *OperatorPanel* prefab.
- [LICENSE] Speed up fingerprinting on Windows.
- [LICENSE] Fix a license issue happening on corporate networks with MITM proxies that intercept network traffic.
- [LICENSE] Fix a license issue when using misconfigured drivers for hard-drives.

## Version 22.09.00
### Added
- [VR] New VR menu. Menu is now interactable through a ray interaction, which make it easier to select tools.
Enabling or adding a custom button in Editor is supported. 
- [ERGO] Automatically assign a vive tracker to the body parts for OpenVR skeleton.
Vive trackers assignation is done during the calibration phase. It is no longer needed to customize trackers reference number or SteamVR ID. This behaviour can be switched off in *HumanManager* component.
- [CORE] Remove and optimize images in order to decrease package size.

### Changed
- [CORE] Application does no longer quit when escape key pressed. This was preventing an user to use *escape* key for other purpose while using custom scripting.

### Deleted
- [VR] Statistics and selection tools have not been ported to new VR menu. If those tools are critical for your usage, we advise to wait before upgrading and to contact us.

### Fixed
- [EDITOR] Fix missing images on license manager.
- [EDITOR] Resolve styling issues on license manager.
- [EDITOR] Fix performance issue when edting large hierarchy without a *PhysicsManager* in scene.
- [EDITOR] Fix *XRGeneralSettings* not being loaded when opening project for the first time.
- [EDITOR] Fix *about* menu not being properly displayed on higher DPI screens.
- [EDITOR] Record undo action when enabling or disabling objects from hierarchy.
- [VR] Fix avatar hands being wobbly.
- [VR] Fix OpenVR being always loaded by only enabling it with VR players.
- [POINTCLOUD] Fix point cloud shaders not working in single pass instanced rendering.
- [CORE] Add proper namespace to *StartServers* component.
- [CORE] Add error messages when *StartServers* is missing a connection settings.
- [ERGO] Fix documentation issue related to vive trackers positions on body.

## Version 22.05.00
### Added
- [PHYSICS] Add a component to display cable bending radius.
- [PHYSICS] Throw an event when cable exceeds the minimal bending radius specification.
- [VR] Add support for Manus Prime X gloves.
- [EDITOR] Add help link to editor tools.
- [HAPTIC] Expose absolute position for Virtuose API.

### Changed
- [EDITOR] Improve editor tools user interface. 
- [EDITOR] Replace "remove small colliders" tool by a more generic tool "Select parts under vertex limit".

### Deleted
- [SCENARIO] Remove unsupported nodes (RobotGrasp, XdeAsbRobotStep).

### Fixed
- [EDITOR] Group Parts should do nothing when only one object is selected.
- [EDITOR] Fix scene stats accounting multiple times for selection when selecting both a gameObject and its children.
- [EDITOR] Fix unhandled exception when stopping playmode with debugger attached.
- [CABLE] Remember decimation factor when reloading scene.
- [SCENARIO] Fix NullRefException in Robot move graph node.
- [SCENARIO] Fix "AddAssetToSameFile failed because the other asset is not persistent".


## Version 22.03.02
### Added
- [ERGO] Show Vive trackers to ease calibration.

### Changed
- [CORE] Change physicalized object icon.

### Fixed
- [CORE] Fix major performance issue with scene stats.
- [VR] Fix missing icon on some VR tools.
- [ERGO] Fix vive tracker player calibration when using VR menu.

## Version 22.03.01
### Changed
- [CORE] Ground is not physicalized by default anymore. It was causing issues and long physicalization time even when it was not useful for the project. It is still possible to physicalize the ground explicitly.

### Fixed
- [CORE] Non-supported Unity version popup had a wrong condition.
- [CORE] Fix warnings related to missing units on import.

## Version 22.03.00
### Added
- [HAPTIC] Add a preset for XdeScene specific to haptic.
- [CORE] Add more logs in order to pinpoint connection issues more easily.

### Fixed
- [EDITOR] Fix grouping not working when the root gameObject is a children of a parent selection.
- [CORE] NullReferenceException when testing a Unity beta build.
- [VR] Remove orientable teleport field in GUI since it was not used anymore.
- [CORE] Fix NullReferenceException when cable extremities were not setup.
- [CORE] Fix compilation error when Unity 2021 was used.

## Version 22.02.00
### Added
- [EDITOR] Rigidbody picker to easily select parent rigidbody.
- [EDITOR] Optimized pick axis and measures in editor.
- [VR] Add a TrackingMeasure component to dynamically measure the distance between two points.
- [VR] Update HBAO package to latest version.

### Fixed
- [ERGO] You can now hide or show ergonomic manikin in Runtime using "H" key.
- [EDITOR] Grouping objects which have a parent-child relationship created empty GameObject.
- [EDITOR] Prevent unwanted data change when multiselecting a value with a BoundAttribute.
- [CORE] Fix missing text in multiplayer popup.
- [CAVE] Prevent the crash of Unity when XdeZMQOpenGLWindow fails to start properly.
- [HAPTIC] For haptic manipulator, attach to center of mass by default instead of pivot point.
- [HAPTIC] Add a new mode to ignore inertial effects when using haptic manipulator.

## Version 21.12.00
### Added
- [PIXYZ] Support for Pixyz 2021.
- [VR] Laser Grab tool to be able to grab and pull physicalized objects from afar using your hands.

### Changed
- [EDITOR] "Add new player" menu to be more straightforward to use by merging HMD's to one item and with new icons.

### Fixed
- [VR] Missing references in the controller component of player prefabs.
- [VR] Measure tool not properly updating its length when pointing at an object.
- [VR] Null reference when trying to grab a root fixed joint with the desktop manipulator.
- [LICENSE] Fix an issue when trying to activate Interact with older licenses.
- [LIBRARY] Missing materials on UR10.
- [EDITOR] Null reference exceptions when trying to remove colliders from an object with no mesh.
- [EDITOR] Null reference when closing interact build panel.
- [EDITOR] OpenVR being loaded even when no HMD where in the scene.
- [EDITOR] Null reference when trying to open scenario graph in an invalid scene.
- [CAVE] Color mode not being serialized.
- [CAVE] Render texture not being serialized.

### Removed
- [EDITOR] Remove media importer.

## Version 21.08.00
### Added
- [SCENARIO] Completely revamped scenarization module.
- [SCENARIO] Add keypoint validation based on joint state.
- [SCENARIO] Add XdeAsbActionStep to trigger events between scenarios (activate, deactivate, reset).
- [CORE] Add compatibility with Unity 2020.3 LTS. Unity 2020.3 LTS is now the recommended version.
- [CORE] Add user preference to switch between imperial and metric units (Editor only).
- [VR] Grabbable property is now editable at runtime.
- [VR] Manus is now using bilateral manipulation behaviour.
- [VR] Add "Weld On Detach" option to XdeAsbOperatorGraspManipulator.
- [PHYSICS] All XdeManipulators now have Attached and Detached events.
- [PHYSICS] XdeRigidBody now has Attached and Detached events.

### Changed
- [CORE] Tune Pixyz default parameters. 
Import models with High tessellation by default, to provide better
results with "Pick Axis". Merge last level of hierarchy to reduce the number of gameobjects.

### Fixed
- [VR] Fix compatibility with single pass instanced.
- [CORE] Remove part on non-prefab item was broken.
- [LIBRARY] Fix conveyor window.
- [LIBRARY] Fix some robots joints orientation.
- [COLLAB] Fix connection issue with two desktop players.
- [PHYSICS] Beam: Correct gizmo for initial configuration.
- [PHYSICS] Fix unit joint's button behaviour when multi-selecting.
- [SCENARIO] Fix scale issue on animated ghost target.

## Version 21.05.03
### Fixed
- [ERGO] Fix regression in ergonomics calibration.
- [CORE] Fix "Apply Transform" throwing an exception on non-triangle mesh topologies.

## Version 21.05.02
### Added
- [CORE] Add ApplyTransform feature that convert a mesh with negative scale to unit scale.
This feature fixes a lot of issues related to dynamic batching, cable recognition, part target ... It is recommended that a GameObject have an unitary scale if possible.
Starting from Pixyz 2020.2.4.5, every objects are imported with negative scale. It is advised to use this ApplyTransform tool to set their transform to unit one.

### Changed
- [VR] Harmonize all prefabs' handtracker & graspmanipulators values.
- [LIBRARY] Convert all robots scale to unit scale.

### Fixed
- [VR] Add mesh collider & asb part on button for interaction with desktop manipulator.
- [CORE] Fix desktop manipulator not working with inversed normals.
- [CORE] Remove AsbPart when unphysicalize a GameObject.
- [CORE] Interact window in Unity Editor was constantly focused which leads to a performance issue.

## Version 21.05.01
### Added
- [LICENSE] User can now enter an hostname instead of IP for license server .

### Fixed
- [VR] Fix action triggered by controller while a tool was used in opposite controller.
- [POINTCLOUD] Fix missing dll issue.
- [CORE] Navigation mode was uneditable in Editor.

## Version 21.05.00
### Added
- [PHYSICS] Add a tool to compute initial configuration of a cable from CAD model.
- [EDITOR] Add a ruler tool in editor to measure distances.
- [EDITOR] Add a protactor tool in editor to measures angles.
- [VR] LeapMotion player is now using new manipulation behavior.
- [VR] Add a "None" navigation mode in order to lock navigation for a player. This is useful if you are using registration to manipulate real objects in your simulation.
- [LICENSE] For large deployment, you can now activate an Interact license from registry values.
- [LICENSE] User can now enter an hostname instead of IP for license server 

### Changed
- [CORE] Navigation mode (Teleport, fly, etc) is now a player parameter instead of global preference.

### Deleted
- [VR] Remove timer tool.

### Fixed
- [VR] Fix teleport when grasping an object.
- [POINTCLOUD] Fix missing dll issue.

## Version 21.01
### Added
- [CORE] Add importer for URDF files. Kinematics links, inertia and STL meshes are supported.
- [CORE] Add a tool to manipulate physicalized objects using desktop device.
- [CAVE] Start Optitrack server automatically according to CAVE configuration.
- [CORE] Handle multi-scenes when we build executables.
- [CORE] Handle multiselection for make grabbable.

### Changed
- [LICENSE] Remove Pixyz package from INTERACT. Pixyz is still highly recommended but not natively embedded anymore. Consider downloading it from Pixyz website.
- [CORE] Support latest Pixyz version 2020.2

### Fixed
- [VR] Fix wrong offset when using measure or teleport tool.
- [CAVE] Optitrack configuration was not serialized in VRX configuration file.
- [VR] Mode icons were not displayed.
- [PHYSICS] Interference detection with multiple submeshes was not reported correctly.
- [PHYSICS] Cable radius now taken into account.
- [COLLAB] Fix inputs that were duplicated for all users.
- [VR] Hands positions were jumping from rest pose to actual pose after teleport.
- [VR] Hands were not teleported at the right position when Manus was used.
- [VR] Fingers were sometimes in odd positions when closing the hand.
- [LICENSE] Old license system didn't deactivate tokens properly.
- [LICENSE] Trim license key to avoid activation error when copy-pasting.
- [CORE] Fix pointcloud shaders compilation with specific defines.
- [CORE] Only move desktop camera when we have focus.
- [CORE] Unphysicalize command did not remove UnitJointMonitor.
- [CORE] Avoid concatenation of "_Grouped" string multiple times.

## Version 20.09
### Added
- [VR] Improved manipulation: objects with different mass will behave accordingly when grabbed.
Bi-manual manipulation is now possible. Grap position has been improved, specially for constrained objects (door, robot, etc...) 
- [CORE] For desktop user, you can now use a camera that use the same commands as popular CAD software (CATIA, Solidworks, Sketchup)
- [CORE] You can group objects instead of merging them when preparing your physicalized scene.
- [PHYSICS] Add mapped joint. This is helpful to create a link between other joints using a custom relation.
- [POINTCLOUD] Add a gizmo to resize and scale when cropping pointcloud.
- [PHYSICS] Add shortcut - Shift+P - to physicalize objects.
- [UI] Add shortcut - Shift+M - to merge objects.

### Deleted
- [VR] GoTouch is no longer embedded in INTERACT package.
- [VR] 3DRudder is no longer embedded in INTERACT package.
- [VR] Removed the city environment.

### Changed
- [UI] Default manipulator is XYZTransform
- [UI] Default focus to OK button
- [CORE] You can now install Pixyz Plugin and Interact at the same time if you need advanced functions of Pixyz scene preparation.
- [CORE] Dramatically reduce the package size by removing unneeded assets and dependencies.
- [CORE] Documentation is now available online.
- [PHYSICS] Add manipulator no longer automatically physicalize object if a rigidbody is not selected.

### Fixed
- [CORE] Merge was not working reliably when several objects had the exact same name.
- [PHYSICS] Using pick axis with a prismatic joint was generating a new gameobject in the hierarchy.
- [UI] Fix NullReferenceException when using "Remove small colliders window" without selection.
- [UI] Fix NullReferenceException when using "Unphysicalize window" without selection.
- [LICENSE] Fix Pixyz button that was always disabled.
- [PHYSICS] Fix interferences detection with dilated lines.
- [VR] Update deprecated components for CAVE systems.


## Version 20.01.04f4
### Added
- [CORE] Unity 2019.4.X is now supported.
 
### Deleted
- [CORE] Disable embedded CTAA package. This should fix some performance issues with Oculus HMD.
 
### Fixed
- [CORE] License status fixed in license manager.
- [CORE] Improve support for HDRP (still in alpha, some features might not work in this rendering pipeline)
- [VR] Avatar hand manipulation fixed


## Version 20.01.04f3
### Added
- [UI] Add physicalize in contextual menu and add unphysicalize in interact menu.
- [License] You can now update your license.
- [License] Uninstall license in offline mode.
- [Physics] Add tooltip to explain our gravity vector convention.

### Deleted
- [CORE] Deleted embedded Post Processing package. This should fix compatibility with Unity Reflect and provides more flexibility to use the latest Post Processing package.
- [CORE] UseEmbeddedServer option was not working well. It is no longer available.
- [VR] Remove obsolete buttons on VR menu.

### Fixed
- [Core] Fix a critical issue that prevented building when using Unity 2019.3.9+ version. Previous versions were not affected.
- [Core] Merging of objects with specials chars was not working.
- [Core] Fix a crash sometimes happening on our reference demo. 
- [Library] Staubly TX2 robot was not working.
- [Physics] Fix right hand kinematics.
- [VR] Wrong orientation when using teleport with left hand. 
- [VR] Fix navigation in fly mode.
- [PointCloud] Crop gizmo was not rotated correctly.
- [Physics] Changes on Collision Matrix were not always saved.
- [Physics] Fix exception when using arrows with a large number of contact points.
- [Physics] User is no longer allowed to enter a negative value for timestep.
- [Ergo] Fix interaction with cotation panel.
- [Collab] First user was the only one able to interact in VR.


## Version 20.01.04

* [Misc] Add importer of XRTwin scenarios

## Version 2019.12

* [Core] New collaboration framework (XSM2)
* [Core] Ability to import media (images, video, pdf)
* [Core] Added new teleportation mode (fly-over)
* [Core] Ability to load and export CAVE configuration files
* [Core] Updated SteamVR 
* [Core] Updated XDE physics engine
* [VR] New user type : controllers with virtual hands
* [Graphics] Optimized rendering for better performance (HBAO, CTAA, triplanar shader)
* [Physics] New feature : joint axis detection
* [Physics] New feature : remove small colliders on an assembly (screws, bolts)
* [Physics] Add diagnostic tool to check scene conformity
* [UI] Create external camera
* [UI] Possibility to assign collision layers when physicalizing part
* [Misc] Add importer of XRTwin scenarios
* [Library] Add awesome materials in the library
* [Fix] Merge parts with line boundaries


## Version 2019.06

* [Graphics] Add Object and polygon counters (Scene stats)
* [UI] Customization of the hierarchy window
* [Core] Compatibility with Unity 2018.3
* [Core] Updated PiXYZ 2019.1
* [Core] Updated XDE 19.04
* [Core] Ability to import 2D drawings (layout)
* [Physics] Add unphysicalize command (right click)
* [Physics] Add keyboard type manipulator
* [Physics] Possibility to define custom attach points for cables
* [Scenario] Possibility to define actuators
* [PointCloud] Add convex decomposition (convert mesh to convex mesh)
* [PointCloud] We now import .ply format
* [Library] Add Sick lidar scanner
* [Ergo] Improve body tracking and add ergonomics cotation panel
* [Misc] Add bug reporter and automatic support tickets


## Version 2018.12

* [UI] Redesign Editor interfaces
* [Core] Add Assembly module allowing to build assembly scenario
* [Physics] Update XDE (18.11)
* [Physics] Add ball joint
* [Physics] Add material library for friction
* [Physics] Add cable configuration window
* [Physics] Add spring and joint effort
* [Physics] Add sound on collision (CollisionSound component)
* [Physics] Add Transform manipulator
* [PointCloud] Cutting plane, Measures and Teleport now compatible with pointclouds
* [PointCloud] Cut and Crop point cloud in Editor
* [PointCloud] Interference detection pointcloud/CAD
* [VR] Multi mode now possible (ex: cutting plane and screenshots)
* [VR] Paint brush tool
* [Ergo] Add support for ART Human
* [Robot] Ability to import/export native FANUC programs
* [Robot] Visual helpers (ghosts) for programming robots
* [Robot] Add Staubli TX2 90L
* [Misc] MultiPlayer : User selection pop up

## Version 2018.06

* Integrate Unity FBX Exporter
* Add tracking devices (ART, OptiTrack, SpaceMouse, ViveTrackers)
* Add Merge part options (by material and by name)
* Add UR3 and UR5 robots in library
* Add measure X,Y,Z
* Export notes in report when simulation stops
* Add ABB IRB 6700 to library


## Version 2018.03

* Update XDE (18.01)
* Update PiXYZ (1.5.8.29)
* Add support for Windows Mixed Reality Headsets
* Add compatibility with 3DRudder Motion Controller
* Add Factory and city environments
* Improve Point cloud importer (>5 billion)
* Add part grabber with controller
* Add directional teleporter
* Add assign material for multiple part
* Improve performance of selection effect

## Version 2018.01

* Add screenshot functionality
* Add stopwatch in toolbox
* Add loading screen while physics is initializing
* Now supporting GoTouchVR haptic fingers
* Improve virtual keyboard and notes
* Enable cutting plane with Standard Shader
* Bug Fix Point cloud visualizer

## Version 2017.11

* Update XDE 17.10
* Import large point clouds
* Add Measure feature
* Add Sawyer robot in Industrial Library
* Desktop Player : Display view of other player with num keys
* Better Leap/Vive colocalization
* Fix Stat Display stereo settings


## Version 2017.08

* Add Part Manipulator
* Add Part explosion
* Add Manipulator feature
* Add Culling Mask for head (avoid seeing the inside of the skull)
