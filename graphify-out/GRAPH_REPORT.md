# Graph Report - C:\Users\dioge\OneDrive\Documenti\GitHub\Dungeon-Manager  (2026-07-22)

## Corpus Check
- cluster-only mode — file stats not available

## Summary
- 623 nodes · 824 edges · 72 communities (36 shown, 36 thin omitted)
- Extraction: 99% EXTRACTED · 1% INFERRED · 0% AMBIGUOUS · INFERRED: 8 edges (avg confidence: 0.8)
- Token cost: 0 input · 0 output

## Community Hubs (Navigation)
- com.unity.modules.audio
- com.unity.modules.unitywebrequest
- UIVirtualTouchZone
- com.unity.modules.imgui
- com.unity.modules.jsonserialize
- com.unity.burst
- Griglia
- com.unity.modules.physics2d
- StarterAssetsInputs
- ReadmeEditor
- com.unity.modules.uielements
- UIVirtualJoystick
- FirstPersonController
- com.unity.modules.physics
- com.unity.modules.ai
- dependencies
- BasicRigidBodyPush
- com.unity.nuget.mono-cecil
- com.unity.editorcoroutines
- com.unity.performance.profile-analyzer
- com.unity.searcher
- com.unity.settings-manager
- com.unity.test-framework.performance
- com.unity.testtools.codecoverage
- dependencies
- com.unity.ide.visualstudio
- com.unity.render-pipelines.universal-config
- com.unity.shadergraph
- com.unity.collab-proxy
- com.unity.render-pipelines.core
- dependencies
- com.unity.modules.accessibility
- com.unity.modules.wind
- com.unity.render-pipelines.universal
- com.unity.test-framework
- com.unity.modules.unitywebrequestwww
- com.unity.ai.navigation
- com.unity.cinemachine
- com.unity.collab-proxy
- com.unity.feature.development
- com.unity.inputsystem
- com.unity.modules.accessibility
- com.unity.modules.adaptiveperformance
- com.unity.modules.cloth
- com.unity.modules.screencapture
- com.unity.modules.terrainphysics
- com.unity.modules.unityanalytics
- com.unity.modules.vectorgraphics
- com.unity.modules.vehicles
- com.unity.modules.video
- com.unity.multiplayer.center
- com.unity.render-pipelines.universal
- com.unity.timeline
- com.unity.visualscripting
- com.unity.ide.rider
- com.unity.ide.visualstudio
- com.unity.modules.assetbundle
- com.unity.modules.audio
- com.unity.modules.director
- com.unity.modules.imageconversion
- com.unity.modules.imgui
- com.unity.modules.jsonserialize
- com.unity.modules.particlesystem
- com.unity.modules.physics
- com.unity.modules.physics2d
- com.unity.modules.physicscore2d
- com.unity.modules.terrain
- com.unity.modules.uielements
- com.unity.modules.unitywebrequest
- com.unity.modules.unitywebrequestaudio
- com.unity.test-framework
- com.unity.ugui

## God Nodes (most connected - your core abstractions)
1. `UIVirtualTouchZone` - 23 edges
2. `UIVirtualJoystick` - 21 edges
3. `FirstPersonController` - 18 edges
4. `com.unity.modules.jsonserialize` - 16 edges
5. `UIVirtualButton` - 14 edges
6. `ReadmeEditor` - 13 edges
7. `Griglia` - 13 edges
8. `StarterAssetsInputs` - 12 edges
9. `com.unity.modules.imgui` - 12 edges
10. `com.unity.modules.audio` - 12 edges

## Surprising Connections (you probably didn't know these)
- `FirstPersonController` --references--> `StarterAssetsInputs`  [EXTRACTED]
  Assets/StarterAssets/FirstPersonController/Scripts/FirstPersonController.cs → Assets/StarterAssets/InputSystem/StarterAssetsInputs.cs
- `UICanvasControllerInput` --references--> `StarterAssetsInputs`  [EXTRACTED]
  Assets/StarterAssets/Mobile/Scripts/CanvasInputs/UICanvasControllerInput.cs → Assets/StarterAssets/InputSystem/StarterAssetsInputs.cs
- `PiazzamentoTrappole` --references--> `Griglia`  [EXTRACTED]
  Assets/_Scripts/PiazzamentoTrappole.cs → Assets/_Scripts/Griglia.cs
- `TestGriglia` --references--> `Griglia`  [EXTRACTED]
  Assets/_Scripts/TestGriglia.cs → Assets/_Scripts/Griglia.cs

## Import Cycles
- None detected.

## Communities (72 total, 36 thin omitted)

### Community 0 - "com.unity.modules.audio"
Cohesion: 0.04
Nodes (48): com.unity.modules.hierarchycore, dependencies, depth, source, version, dependencies, depth, source (+40 more)

### Community 1 - "com.unity.modules.unitywebrequest"
Cohesion: 0.05
Nodes (45): dependencies, depth, source, version, dependencies, depth, source, version (+37 more)

### Community 2 - "UIVirtualTouchZone"
Cohesion: 0.10
Nodes (18): BoolEvent, PointerEventData, Event, UIVirtualButton, bool, float, GameObject, PointerEventData (+10 more)

### Community 3 - "com.unity.modules.imgui"
Cohesion: 0.06
Nodes (33): com.unity.ext.nunit, com.unity.splines, dependencies, depth, source, url, version, dependencies (+25 more)

### Community 4 - "com.unity.modules.jsonserialize"
Cohesion: 0.06
Nodes (32): com.unity.modules.subsystems, dependencies, depth, source, version, dependencies, depth, source (+24 more)

### Community 5 - "com.unity.burst"
Cohesion: 0.07
Nodes (30): com.unity.burst, com.unity.collections, com.unity.mathematics, dependencies, depth, source, url, version (+22 more)

### Community 6 - "Griglia"
Cohesion: 0.12
Nodes (15): Cella, float, GameObject, Griglia, TipoCella, GameObject, PiazzamentoTrappole, TestGriglia (+7 more)

### Community 7 - "com.unity.modules.physics2d"
Cohesion: 0.07
Nodes (29): dependencies, depth, source, version, dependencies, depth, source, version (+21 more)

### Community 8 - "StarterAssetsInputs"
Cohesion: 0.14
Nodes (11): bool, Vector2, OnJump(), OnLook(), OnMove(), OnSprint(), StarterAssetsInputs, Vector2 (+3 more)

### Community 9 - "ReadmeEditor"
Cohesion: 0.11
Nodes (15): bool, float, string, ReadmeEditor, bool, string, Readme, Section (+7 more)

### Community 10 - "com.unity.modules.uielements"
Cohesion: 0.10
Nodes (21): dependencies, depth, source, url, version, depth, source, version (+13 more)

### Community 11 - "UIVirtualJoystick"
Cohesion: 0.19
Nodes (8): bool, float, PointerEventData, RectTransform, Vector2, Event, UIVirtualJoystick, IDragHandler

### Community 12 - "FirstPersonController"
Cohesion: 0.17
Nodes (6): bool, float, GameObject, LayerMask, FirstPersonController, CharacterController

### Community 13 - "com.unity.modules.physics"
Cohesion: 0.12
Nodes (16): dependencies, depth, source, version, dependencies, depth, source, version (+8 more)

### Community 14 - "com.unity.modules.ai"
Cohesion: 0.17
Nodes (12): dependencies, depth, source, url, version, dependencies, depth, source (+4 more)

### Community 15 - "dependencies"
Cohesion: 0.31
Nodes (10): com.unity.modules.xr, dependencies, com.unity.modules.ai, com.unity.modules.androidjni, com.unity.modules.animation, com.unity.modules.tilemap, com.unity.modules.ui, com.unity.modules.umbra (+2 more)

### Community 16 - "BasicRigidBodyPush"
Cohesion: 0.32
Nodes (5): BasicRigidBodyPush, bool, float, LayerMask, ControllerColliderHit

### Community 17 - "com.unity.nuget.mono-cecil"
Cohesion: 0.25
Nodes (8): com.unity.nuget.mono-cecil, dependencies, dependencies, depth, source, url, version, com.unity.nuget.mono-cecil

### Community 18 - "com.unity.editorcoroutines"
Cohesion: 0.29
Nodes (7): com.unity.editorcoroutines, dependencies, depth, source, url, version, com.unity.editorcoroutines

### Community 19 - "com.unity.performance.profile-analyzer"
Cohesion: 0.29
Nodes (7): com.unity.performance.profile-analyzer, dependencies, depth, source, url, version, com.unity.performance.profile-analyzer

### Community 20 - "com.unity.searcher"
Cohesion: 0.29
Nodes (7): com.unity.searcher, dependencies, depth, source, url, version, com.unity.searcher

### Community 21 - "com.unity.settings-manager"
Cohesion: 0.29
Nodes (7): com.unity.settings-manager, dependencies, depth, source, url, version, com.unity.settings-manager

### Community 22 - "com.unity.test-framework.performance"
Cohesion: 0.29
Nodes (7): com.unity.test-framework.performance, dependencies, depth, source, url, version, com.unity.test-framework.performance

### Community 23 - "com.unity.testtools.codecoverage"
Cohesion: 0.29
Nodes (7): com.unity.testtools.codecoverage, dependencies, depth, source, url, version, com.unity.testtools.codecoverage

### Community 24 - "dependencies"
Cohesion: 0.29
Nodes (6): dependencies, depth, source, version, dependencies, com.unity.modules.umbra

### Community 25 - "com.unity.ide.visualstudio"
Cohesion: 0.29
Nodes (7): dependencies, depth, source, url, version, com.unity.ide.visualstudio, com.unity.ide.visualstudio

### Community 26 - "com.unity.render-pipelines.universal-config"
Cohesion: 0.33
Nodes (6): com.unity.render-pipelines.universal-config, dependencies, depth, source, version, com.unity.render-pipelines.universal-config

### Community 27 - "com.unity.shadergraph"
Cohesion: 0.33
Nodes (6): com.unity.shadergraph, dependencies, depth, source, version, com.unity.shadergraph

### Community 28 - "com.unity.collab-proxy"
Cohesion: 0.33
Nodes (6): dependencies, depth, source, url, version, com.unity.collab-proxy

### Community 29 - "com.unity.render-pipelines.core"
Cohesion: 0.40
Nodes (5): com.unity.render-pipelines.core, depth, source, version, com.unity.render-pipelines.core

### Community 30 - "dependencies"
Cohesion: 0.40
Nodes (5): dependencies, depth, source, version, com.unity.feature.development

### Community 31 - "com.unity.modules.accessibility"
Cohesion: 0.40
Nodes (5): dependencies, depth, source, version, com.unity.modules.accessibility

### Community 32 - "com.unity.modules.wind"
Cohesion: 0.40
Nodes (5): dependencies, depth, source, version, com.unity.modules.wind

### Community 33 - "com.unity.render-pipelines.universal"
Cohesion: 0.40
Nodes (5): dependencies, depth, source, version, com.unity.render-pipelines.universal

### Community 34 - "com.unity.test-framework"
Cohesion: 0.40
Nodes (5): depth, source, version, com.unity.test-framework, com.unity.test-framework

### Community 35 - "com.unity.modules.unitywebrequestwww"
Cohesion: 0.50
Nodes (4): com.unity.modules.unitywebrequestwww, com.unity.modules.unitywebrequestassetbundle, com.unity.modules.unitywebrequesttexture, com.unity.modules.unitywebrequestwww

## Knowledge Gaps
- **309 isolated node(s):** `com.unity.ai.navigation`, `com.unity.cinemachine`, `com.unity.collab-proxy`, `com.unity.feature.development`, `com.unity.ide.rider` (+304 more)
  These have ≤1 connection - possible missing edges or undocumented components.
- **36 thin communities (<3 nodes) omitted from report** — run `graphify query` to explore isolated nodes.

## Suggested Questions
_Questions this graph is uniquely positioned to answer:_

- **Why does `dependencies` connect `dependencies` to `com.unity.modules.audio`, `com.unity.modules.unitywebrequest`, `com.unity.modules.imgui`, `com.unity.modules.jsonserialize`, `com.unity.burst`, `com.unity.modules.physics2d`, `com.unity.modules.uielements`, `com.unity.modules.physics`, `com.unity.modules.ai`, `com.unity.nuget.mono-cecil`, `com.unity.editorcoroutines`, `com.unity.performance.profile-analyzer`, `com.unity.searcher`, `com.unity.settings-manager`, `com.unity.test-framework.performance`, `com.unity.testtools.codecoverage`, `com.unity.ide.visualstudio`, `com.unity.render-pipelines.universal-config`, `com.unity.shadergraph`, `com.unity.collab-proxy`, `com.unity.render-pipelines.core`, `dependencies`, `com.unity.modules.accessibility`, `com.unity.modules.wind`, `com.unity.render-pipelines.universal`, `com.unity.test-framework`?**
  _High betweenness centrality (0.339) - this node is a cross-community bridge._
- **Why does `dependencies` connect `dependencies` to `com.unity.modules.unitywebrequestwww`, `com.unity.ai.navigation`, `com.unity.cinemachine`, `com.unity.collab-proxy`, `com.unity.feature.development`, `com.unity.inputsystem`, `com.unity.modules.accessibility`, `com.unity.modules.adaptiveperformance`, `com.unity.modules.cloth`, `com.unity.modules.screencapture`, `com.unity.modules.terrainphysics`, `com.unity.modules.unityanalytics`, `com.unity.modules.vectorgraphics`, `com.unity.modules.vehicles`, `com.unity.modules.video`, `com.unity.multiplayer.center`, `com.unity.render-pipelines.universal`, `com.unity.timeline`, `com.unity.visualscripting`, `com.unity.ide.rider`, `com.unity.ide.visualstudio`, `com.unity.modules.assetbundle`, `com.unity.modules.audio`, `com.unity.modules.director`, `com.unity.modules.imageconversion`, `com.unity.modules.imgui`, `com.unity.modules.jsonserialize`, `com.unity.modules.particlesystem`, `com.unity.modules.physics`, `com.unity.modules.physics2d`, `com.unity.modules.physicscore2d`, `com.unity.modules.terrain`, `com.unity.modules.uielements`, `com.unity.modules.unitywebrequest`, `com.unity.modules.unitywebrequestaudio`, `com.unity.test-framework`, `com.unity.ugui`?**
  _High betweenness centrality (0.019) - this node is a cross-community bridge._
- **Why does `com.unity.modules.jsonserialize` connect `com.unity.modules.jsonserialize` to `com.unity.modules.audio`, `com.unity.modules.imgui`, `com.unity.burst`, `com.unity.modules.physics2d`, `com.unity.test-framework.performance`, `dependencies`?**
  _High betweenness centrality (0.016) - this node is a cross-community bridge._
- **What connects `com.unity.ai.navigation`, `com.unity.cinemachine`, `com.unity.collab-proxy` to the rest of the system?**
  _309 weakly-connected nodes found - possible documentation gaps or missing edges._
- **Should `com.unity.modules.audio` be split into smaller, more focused modules?**
  _Cohesion score 0.044326241134751775 - nodes in this community are weakly interconnected._
- **Should `com.unity.modules.unitywebrequest` be split into smaller, more focused modules?**
  _Cohesion score 0.048484848484848485 - nodes in this community are weakly interconnected._
- **Should `UIVirtualTouchZone` be split into smaller, more focused modules?**
  _Cohesion score 0.09759759759759759 - nodes in this community are weakly interconnected._