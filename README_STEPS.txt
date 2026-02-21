VHS_NOTES_CHECKLIST

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


