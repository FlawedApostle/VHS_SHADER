// ================================================================================
// COPYRIGHT (C) 2026 [Samuel Fearnley]. ALL RIGHTS RESERVED.
// This shader is provided for use in projects but may not be resold or 
// redistributed as source code without express permission.
// ================================================================================
// "RenderPipeline" = "UniversalPipeline": 
// This is a "lock and key" tag. It tells Unity, "Only run this shader if the project is using URP." 
// If you tried to use this in the old Built-in pipeline, it WONT'T run.
// ================================================================================

# VHS_SHADER
This repository contains a modular, production-ready aesthetic suite for First-Person and Horror projects.

this suite provides a modular, production-ready fullscreen VHS post-processing shader built in HLSL and integrated into Unity using the Universal Render Pipeline (URP) using the modern Render Graph API. Along with a custom ScriptableRendererFeature injection system.


- The effect(s) simulates authentic analog video artifacts, including lens distortion, chromatic aberration, tracking instability, scanlines, grain, and signal corruption.

The shader is injected using the current RenderGraph API rather than legacy rendering methods, ensuring forward compatibility with Unity’s evolving rendering systems
- The system is designed with a clean separation between shader logic, editor tooling, and render pipeline injection, ensuring portability, extensibility, and compatibility with modern URP RenderGraph architecture

- Injects shader into the URP render pipeline
- Executes as a fullscreen post-processing pass [Rendering Feature - URP]
- Uses modern URP RenderGraph API
- Non-intrusive to existing rendering pipeline

Key Technical Pillars:
- Modern Injection:       Uses ScriptableRendererFeature with RenderGraph for memory-efficient post-processing.
- High-Performance HLSL:  Single-pass shader logic minimizing draw calls.
- Modular Architecture:   Detection logic is decoupled from game objects.



URP ACTIVATION CHECKLIST (REQUIRED FOR SHADERS AND RENDER FEATURES TO WORK)

STEP 1 — CREATE THE URP PIPELINE ASSET
Right click in Project window → Create → Rendering → URP → Pipeline Asset (Universal Renderer)
This creates two files:
• UniversalRenderPipelineAsset.asset
• UniversalRenderer.asset

STEP 2 — ASSIGN URP IN GRAPHICS SETTINGS (GLOBAL ACTIVATION)
Go to: Edit → Project Settings → Graphics
Find: Scriptable Render Pipeline Settings
Assign: UniversalRenderPipelineAsset.asset

This activates URP for the project.

STEP 3 — ASSIGN URP IN QUALITY SETTINGS (CRITICAL — UNITY DOES NOT DO THIS AUTOMATICALLY)
Go to: Edit → Project Settings → Quality

For EACH quality level (Low, Medium, High, etc):
Find: Render Pipeline Asset
Assign: UniversalRenderPipelineAsset.asset

THIS STEP IS REQUIRED.
If this is not set, Unity will silently use the Built-in Render Pipeline and URP shaders and renderer features will NOT run.

STEP 4 — VERIFY CAMERA IS USING URP
Select Camera in scene.
Inspector should show:
Camera → Rendering → Renderer

If this is visible, URP is active.
If not visible, URP is NOT active.

STEP 5 — ADD RENDER FEATURE TO THE URP RENDERER
Select: UniversalRenderer.asset
Inspector → Renderer Features
Click: Add Renderer Feature
Select your custom renderer feature (example: VHSFeature)
Assign the material if required.

STEP 6 — ENABLE INTERMEDIATE TEXTURE (REQUIRED FOR FULLSCREEN BLIT SHADERS)
Select: UniversalRenderer.asset
Inspector → Rendering
Set: Intermediate Texture → Always

Without this, fullscreen shader effects using Blit.hlsl may not work.

END OF CHECKLIST


