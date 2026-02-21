# VHS_SHADER
This repository contains a modular, production-ready aesthetic suite for First-Person and Horror projects.

this suite provides a modular, production-ready fullscreen VHS post-processing shader built in HLSL and integrated into Unity using the Universal Render Pipeline (URP) using the modern Render Graph API. Along with a custom ScriptableRendererFeature injection system.
- [New 16 Bit GPU Architecture to be implemented with said injector]

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
