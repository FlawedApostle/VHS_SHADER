===============================================================================
FRINGE LOGIC – VHS FINAL MASTER SHADER
Documentation & User Guide
===============================================================================

Author: Fringe Logic  
Pipeline: Universal Render Pipeline (URP)  
Shader Name: VHS_Effects/VHS_Final_Master  
Version: 1.0  
===============================================================================

INTRODUCTION
------------
The Fringe Logic VHS Final Master shader is a full‑stack analog distortion
pipeline designed to emulate the visual artifacts of damaged VHS tapes,
consumer camcorders, and degraded CRT playback. The shader is built for URP
and uses a modular toggle‑based system, allowing users to enable or disable
individual effects without modifying the source code.

This shader is intended for:
- Analog horror projects
- Retro aesthetics
- Stylized glitch effects
- UI overlays and post‑processing
- Cutscenes and cinematic distortion

The shader is applied as a fullscreen blit effect through a custom renderer
feature (injector). All effects operate in screen‑space.

===============================================================================
FEATURE OVERVIEW
-------------------------------------------------------------------------------

1. BLACKOUT
   - Random full‑frame blackouts simulating tape dropout.
   - Adjustable blackout probability.

2. FISHEYE LENS DISTORTION
   - Hybrid real + polynomial projection.
   - Adjustable bulge, zoom, and distortion strength.

3. RADIAL DSLR‑STYLE BLUR
   - Blur increases toward the edges.
   - Adjustable radius, falloff power, and strength.

4. BORDER VIGNETTE
   - Adjustable edge darkness and smoothness.

5. CHROMATIC ABERRATION (FLARE)
   - Radial flare based on distance from center.
   - Adjustable intensity and power curve.

6. CONSTANT RGB SPLIT
   - Independent R/G/B horizontal offsets.

7. COLOR BLEEDING (TAPE LAG)
   - Horizontal smear simulating misaligned tape heads.
   - Adjustable bleed amount and per‑channel intensity.

8. GLITCH BAND (HEAD CLOGGING)
   - Scrolling horizontal distortion bands.
   - Adjustable speed, thickness, spacing, and color tint.

9. RGB BURST EVENTS
   - Randomized color bursts with optional scrolling.
   - Adjustable size, frequency, brightness, and color.

10. STATIC GRAIN (BW)
    - High‑frequency monochrome noise.

11. COLOR GRAIN (FUZZY RGB)
    - Chunky chromatic noise with adjustable RGB balance.

12. SCANLINES
    - Adjustable density, speed, rotation, and sine‑warp.

13. SCANLINE WARP
    - Additional warping layer for unstable playback.

14. SCREEN FLICKER
    - Random brightness modulation.

15. VERTICAL JUMP
    - Sudden vertical displacement simulating tape misfeed.

16. FRAME JITTER
    - Micro‑shakes on both axes.

===============================================================================
USAGE INSTRUCTIONS
-------------------------------------------------------------------------------

1. Add the custom renderer feature (injector) to your URP Renderer.
2. Assign the “VHS_Final_Master” material to the injector.
3. Press Play — the effect will be visible immediately.
4. Adjust parameters directly in the material inspector.
5. Use toggles to enable or disable individual effects.

No scripting is required unless you want runtime control.

===============================================================================
DEMO SCENE SETUP
-------------------------------------------------------------------------------

The demo scene included in the package is designed to show the effect
immediately when entering Play mode.

The scene contains:
- A camera with the VHS injector already assigned.
- A simple test object/environment.
- The VHS shader material with several effects enabled.

This allows reviewers and users to see the effect without any setup.

===============================================================================
FOLDER STRUCTURE
-------------------------------------------------------------------------------

FringeLogic_VHS/
    Documentation/
        FringeLogic_VHS_Manual.pdf
    Demo/
        VHS_DemoScene.unity
    Shaders/
        VHS_Final_Master.shader
    Materials/
        VHS_Master.mat
    Scripts/
        VHSInjector.cs
        VHSInspector.cs
    Textures/
    Prefabs/

===============================================================================
SUPPORT
-------------------------------------------------------------------------------

For support, updates, or inquiries:
Email: your-email-here
GitHub Portfolio: https://yourusername.github.io/

===============================================================================
END OF DOCUMENT
===============================================================================









===============================================================================
DESCRIPTION
===============================================================================

VHS FINAL MASTER – Analog Horror & Retro Distortion Suite (URP)

Bring authentic VHS, CRT, and analog horror distortion to your Unity project with the Fringe Logic VHS Final Master shader. This is a complete, modular, screen‑space effect designed for URP, featuring a full stack of retro artifacts, tape damage, lens distortion, glitch bands, scanlines, color bleeding, grain, jitter, and more.

Perfect for:
• Analog horror
• Retro aesthetics
• Found‑footage games
• VHS/CRT UI overlays
• Stylized glitch effects
• Cinematic distortion

The shader is fully modular — every effect can be toggled on/off individually. No scripting required.

-------------------------------------------------------------------------------
FEATURES
-------------------------------------------------------------------------------
• Blackout / Tape Dropout  
• Fisheye Lens Distortion (Hybrid Projection)  
• DSLR‑Style Radial Blur (Edge‑Weighted)  
• Vignette & Border Darkening  
• Chromatic Aberration (Radial Flare)  
• Constant RGB Split  
• Color Bleeding / Tape Lag  
• Glitch Bands (Head Clogging)  
• RGB Burst Events (Random or Scrolling)  
• Static Grain (BW)  
• Chromatic Color Grain (Chunky RGB Noise)  
• Scanlines (Density, Speed, Rotation, Warp)  
• Scanline Warp Layer  
• Screen Flicker  
• Vertical Jump  
• Frame Jitter (Micro‑Shake)  
• Fully toggle‑based system  
• Clean inspector layout  
• URP‑native blit pipeline  

-------------------------------------------------------------------------------
WHAT’S INCLUDED
-------------------------------------------------------------------------------
• VHS Final Master Shader (URP)  
• Custom Inspector  
• Custom Renderer Feature (Injector)  
• Demo Scene (ready to run)  
• Documentation PDF  
• Example Material  
• Organized folder structure  

-------------------------------------------------------------------------------
EASY SETUP
-------------------------------------------------------------------------------
1. Add the included renderer feature to your URP Renderer.  
2. Assign the VHS material.  
3. Press Play — the effect is active immediately.  
4. Adjust settings in the material inspector.  

No scripting required.

-------------------------------------------------------------------------------
DEMO SCENE
-------------------------------------------------------------------------------
The included demo scene shows the effect immediately when entering Play mode.  
The camera is pre‑configured with the injector and material.

-------------------------------------------------------------------------------
PIPELINE & COMPATIBILITY
-------------------------------------------------------------------------------
• Render Pipeline: Universal Render Pipeline (URP)  
• Unity Versions: 2021 LTS, 2022 LTS, 2023 LTS, 2024+  
• Platform: Windows, Mac, Linux  
• Works in 2D and 3D projects  
• Works with UI and world‑space cameras  

-------------------------------------------------------------------------------
SUPPORT
-------------------------------------------------------------------------------
For support, updates, or inquiries:  
Email: your-email-here  
Portfolio: https://yourusername.github.io/

-------------------------------------------------------------------------------




===============================================================================
TECHINCAL DETAILS
===============================================================================

Render Pipeline:
• Universal Render Pipeline (URP)

Unity Versions:
• 2021 LTS
• 2022 LTS
• 2023 LTS
• 2024 and newer

Platforms:
• Windows
• Mac
• Linux
• WebGL (URP-supported features only)
• Mobile (performance varies by device)

Included Files:
• VHS_Final_Master.shader
• Custom Inspector (VHSInspector.cs)
• Custom Renderer Feature / Injector (VHSInjector.cs)
• Demo Scene (preconfigured camera + material)
• Example Material
• Documentation PDF
• Organized folder structure (Demo, Documentation, Shader, Scripts, Pipeline)

Dependencies:
• URP Renderer with Scriptable Renderer Feature support
• No external packages required

Features:
• Fisheye lens distortion
• Radial DSLR blur
• Chromatic aberration (flare + RGB split)
• Color bleeding / tape lag
• Glitch bands and RGB bursts
• Scanlines + warp
• Grain (BW + chromatic)
• Flicker, jitter, vertical jump
• Blackout / dropout events
• Fully toggle-based modular system

File Structure:
Assets/
    VHS/
        Demo/
        Documentation/
        Pipeline/
        Scripts/
        Shader/
        Materials/ (optional)
        Textures/ (optional)

Known Limitations:
• Built-in Render Pipeline is not supported
• HDRP is not supported
• Some effects may require tuning for mobile performance

Support:
• Email: your-email-here
• Portfolio: https://yourusername.github.io/
