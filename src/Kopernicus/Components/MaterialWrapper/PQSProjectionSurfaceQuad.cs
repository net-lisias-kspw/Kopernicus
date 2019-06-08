// Material wrapper generated by shader translator tool

using System;
using System.Diagnostics.CodeAnalysis;
using UnityEngine;

namespace Kopernicus.Components.MaterialWrapper
{
    [SuppressMessage("ReSharper", "MemberCanBePrivate.Global")]
    [SuppressMessage("ReSharper", "AutoPropertyCanBeMadeGetOnly.Local")]
    [SuppressMessage("ReSharper", "MemberCanBeProtected.Global")]
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public class PQSProjectionSurfaceQuad : Material
    {
        // Internal property ID tracking object
        protected class Properties
        {
            // Return the shader for this wrapper
            private const String SHADER_NAME = "Terrain/PQS/Sphere Projection SURFACE QUAD";

            public static Shader Shader
            {
                get { return Shader.Find(SHADER_NAME); }
            }

            // Saturation, default = 1
            public const String SATURATION_KEY = "_saturation";
            public Int32 SaturationId { get; private set; }

            // Contrast, default = 1
            public const String CONTRAST_KEY = "_contrast";
            public Int32 ContrastId { get; private set; }

            // Colour Unsaturation (A = Factor), default = (1,1,1,0)
            public const String TINT_COLOR_KEY = "_tintColor";
            public Int32 TintColorId { get; private set; }

            // Near Tiling, default = 1000
            public const String TEX_TILING_KEY = "_texTiling";
            public Int32 TexTilingId { get; private set; }

            // Near Blend, default = 0.5
            public const String TEX_POWER_KEY = "_texPower";
            public Int32 TexPowerId { get; private set; }

            // Far Blend, default = 0.5
            public const String MULTI_POWER_KEY = "_multiPower";
            public Int32 MultiPowerId { get; private set; }

            // NearFar Start, default = 2000
            public const String GROUND_TEX_START_KEY = "_groundTexStart";
            public Int32 GroundTexStartId { get; private set; }

            // NearFar Start, default = 10000
            public const String GROUND_TEX_END_KEY = "_groundTexEnd";
            public Int32 GroundTexEndId { get; private set; }

            // Steep Tiling, default = 1
            public const String STEEP_TILING_KEY = "_steepTiling";
            public Int32 SteepTilingId { get; private set; }

            // Steep Blend, default = 1
            public const String STEEP_POWER_KEY = "_steepPower";
            public Int32 SteepPowerId { get; private set; }

            // Steep Fade Start, default = 20000
            public const String STEEP_TEX_START_KEY = "_steepTexStart";
            public Int32 SteepTexStartId { get; private set; }

            // Steep Fade End, default = 30000
            public const String STEEP_TEX_END_KEY = "_steepTexEnd";
            public Int32 SteepTexEndId { get; private set; }

            // Deep ground, default = "white" { }
            public const String DEEP_TEX_KEY = "_deepTex";
            public Int32 DeepTexId { get; private set; }

            // Deep MT, default = "white" { }
            public const String DEEP_MULTI_TEX_KEY = "_deepMultiTex";
            public Int32 DeepMultiTexId { get; private set; }

            // Deep MT Tiling, default = 1
            public const String DEEP_MULTI_FACTOR_KEY = "_deepMultiFactor";
            public Int32 DeepMultiFactorId { get; private set; }

            // Main Texture, default = "white" { }
            public const String MAIN_TEX_KEY = "_mainTex";
            public Int32 MainTexId { get; private set; }

            // Main MT, default = "white" { }
            public const String MAIN_MULTI_TEX_KEY = "_mainMultiTex";
            public Int32 MainMultiTexId { get; private set; }

            // Main MT Tiling, default = 1
            public const String MAIN_MULTI_FACTOR_KEY = "_mainMultiFactor";
            public Int32 MainMultiFactorId { get; private set; }

            // High Ground, default = "white" { }
            public const String HIGH_TEX_KEY = "_highTex";
            public Int32 HighTexId { get; private set; }

            // High MT, default = "white" { }
            public const String HIGH_MULTI_TEX_KEY = "_highMultiTex";
            public Int32 HighMultiTexId { get; private set; }

            // High MT Tiling, default = 1
            public const String HIGH_MULTI_FACTOR_KEY = "_highMultiFactor";
            public Int32 HighMultiFactorId { get; private set; }

            // Snow, default = "white" { }
            public const String SNOW_TEX_KEY = "_snowTex";
            public Int32 SnowTexId { get; private set; }

            // Snow MT, default = "white" { }
            public const String SNOW_MULTI_TEX_KEY = "_snowMultiTex";
            public Int32 SnowMultiTexId { get; private set; }

            // Snow MT Tiling, default = 1
            public const String SNOW_MULTI_FACTOR_KEY = "_snowMultiFactor";
            public Int32 SnowMultiFactorId { get; private set; }

            // Steep Texture, default = "white" { }
            public const String STEEP_TEX_KEY = "_steepTex";
            public Int32 SteepTexId { get; private set; }

            // Deep Start, default = 0
            public const String DEEP_START_KEY = "_deepStart";
            public Int32 DeepStartId { get; private set; }

            // Deep End, default = 0.3
            public const String DEEP_END_KEY = "_deepEnd";
            public Int32 DeepEndId { get; private set; }

            // Main lower boundary start, default = 0
            public const String MAIN_LO_START_KEY = "_mainLoStart";
            public Int32 MainLoStartId { get; private set; }

            // Main lower boundary end, default = 0.5
            public const String MAIN_LO_END_KEY = "_mainLoEnd";
            public Int32 MainLoEndId { get; private set; }

            // Main upper boundary start, default = 0.3
            public const String MAIN_HI_START_KEY = "_mainHiStart";
            public Int32 MainHiStartId { get; private set; }

            // Main upper boundary end, default = 0.5
            public const String MAIN_HI_END_KEY = "_mainHiEnd";
            public Int32 MainHiEndId { get; private set; }

            // High lower boundary start, default = 0.6
            public const String HI_LO_START_KEY = "_hiLoStart";
            public Int32 HiLoStartId { get; private set; }

            // High lower boundary end, default = 0.6
            public const String HI_LO_END_KEY = "_hiLoEnd";
            public Int32 HiLoEndId { get; private set; }

            // High upper boundary start, default = 0.6
            public const String HI_HI_START_KEY = "_hiHiStart";
            public Int32 HiHiStartId { get; private set; }

            // High upper boundary end, default = 0.9
            public const String HI_HI_END_KEY = "_hiHiEnd";
            public Int32 HiHiEndId { get; private set; }

            // Snow Start, default = 0.9
            public const String SNOW_START_KEY = "_snowStart";
            public Int32 SnowStartId { get; private set; }

            // Snow End, default = 1
            public const String SNOW_END_KEY = "_snowEnd";
            public Int32 SnowEndId { get; private set; }

            // PlanetOpacity, default = 1
            public const String PLANET_OPACITY_KEY = "_PlanetOpacity";
            public Int32 PlanetOpacityId { get; private set; }

            // Singleton instance
            private static Properties _singleton;

            public static Properties Instance
            {
                get
                {
                    // Construct the singleton if it does not exist
                    return _singleton ?? (_singleton = new Properties());
                }
            }

            private Properties()
            {
                SaturationId = Shader.PropertyToID(SATURATION_KEY);
                ContrastId = Shader.PropertyToID(CONTRAST_KEY);
                TintColorId = Shader.PropertyToID(TINT_COLOR_KEY);
                TexTilingId = Shader.PropertyToID(TEX_TILING_KEY);
                TexPowerId = Shader.PropertyToID(TEX_POWER_KEY);
                MultiPowerId = Shader.PropertyToID(MULTI_POWER_KEY);
                GroundTexStartId = Shader.PropertyToID(GROUND_TEX_START_KEY);
                GroundTexEndId = Shader.PropertyToID(GROUND_TEX_END_KEY);
                SteepTilingId = Shader.PropertyToID(STEEP_TILING_KEY);
                SteepPowerId = Shader.PropertyToID(STEEP_POWER_KEY);
                SteepTexStartId = Shader.PropertyToID(STEEP_TEX_START_KEY);
                SteepTexEndId = Shader.PropertyToID(STEEP_TEX_END_KEY);
                DeepTexId = Shader.PropertyToID(DEEP_TEX_KEY);
                DeepMultiTexId = Shader.PropertyToID(DEEP_MULTI_TEX_KEY);
                DeepMultiFactorId = Shader.PropertyToID(DEEP_MULTI_FACTOR_KEY);
                MainTexId = Shader.PropertyToID(MAIN_TEX_KEY);
                MainMultiTexId = Shader.PropertyToID(MAIN_MULTI_TEX_KEY);
                MainMultiFactorId = Shader.PropertyToID(MAIN_MULTI_FACTOR_KEY);
                HighTexId = Shader.PropertyToID(HIGH_TEX_KEY);
                HighMultiTexId = Shader.PropertyToID(HIGH_MULTI_TEX_KEY);
                HighMultiFactorId = Shader.PropertyToID(HIGH_MULTI_FACTOR_KEY);
                SnowTexId = Shader.PropertyToID(SNOW_TEX_KEY);
                SnowMultiTexId = Shader.PropertyToID(SNOW_MULTI_TEX_KEY);
                SnowMultiFactorId = Shader.PropertyToID(SNOW_MULTI_FACTOR_KEY);
                SteepTexId = Shader.PropertyToID(STEEP_TEX_KEY);
                DeepStartId = Shader.PropertyToID(DEEP_START_KEY);
                DeepEndId = Shader.PropertyToID(DEEP_END_KEY);
                MainLoStartId = Shader.PropertyToID(MAIN_LO_START_KEY);
                MainLoEndId = Shader.PropertyToID(MAIN_LO_END_KEY);
                MainHiStartId = Shader.PropertyToID(MAIN_HI_START_KEY);
                MainHiEndId = Shader.PropertyToID(MAIN_HI_END_KEY);
                HiLoStartId = Shader.PropertyToID(HI_LO_START_KEY);
                HiLoEndId = Shader.PropertyToID(HI_LO_END_KEY);
                HiHiStartId = Shader.PropertyToID(HI_HI_START_KEY);
                HiHiEndId = Shader.PropertyToID(HI_HI_END_KEY);
                SnowStartId = Shader.PropertyToID(SNOW_START_KEY);
                SnowEndId = Shader.PropertyToID(SNOW_END_KEY);
                PlanetOpacityId = Shader.PropertyToID(PLANET_OPACITY_KEY);
            }
        }

        // Is some random material this material 
        public static Boolean UsesSameShader(Material m)
        {
            return m.shader.name == Properties.Shader.name;
        }

        // Saturation, default = 1
        public Single Saturation
        {
            get { return GetFloat(Properties.Instance.SaturationId); }
            set { SetFloat(Properties.Instance.SaturationId, value); }
        }

        // Contrast, default = 1
        public Single Contrast
        {
            get { return GetFloat(Properties.Instance.ContrastId); }
            set { SetFloat(Properties.Instance.ContrastId, value); }
        }

        // Colour Unsaturation (A = Factor), default = (1,1,1,0)
        public Color TintColor
        {
            get { return GetColor(Properties.Instance.TintColorId); }
            set { SetColor(Properties.Instance.TintColorId, value); }
        }

        // Near Tiling, default = 1000
        public Single TexTiling
        {
            get { return GetFloat(Properties.Instance.TexTilingId); }
            set { SetFloat(Properties.Instance.TexTilingId, value); }
        }

        // Near Blend, default = 0.5
        public Single TexPower
        {
            get { return GetFloat(Properties.Instance.TexPowerId); }
            set { SetFloat(Properties.Instance.TexPowerId, value); }
        }

        // Far Blend, default = 0.5
        public Single MultiPower
        {
            get { return GetFloat(Properties.Instance.MultiPowerId); }
            set { SetFloat(Properties.Instance.MultiPowerId, value); }
        }

        // NearFar Start, default = 2000
        public Single GroundTexStart
        {
            get { return GetFloat(Properties.Instance.GroundTexStartId); }
            set { SetFloat(Properties.Instance.GroundTexStartId, value); }
        }

        // NearFar Start, default = 10000
        public Single GroundTexEnd
        {
            get { return GetFloat(Properties.Instance.GroundTexEndId); }
            set { SetFloat(Properties.Instance.GroundTexEndId, value); }
        }

        // Steep Tiling, default = 1
        public Single SteepTiling
        {
            get { return GetFloat(Properties.Instance.SteepTilingId); }
            set { SetFloat(Properties.Instance.SteepTilingId, value); }
        }

        // Steep Blend, default = 1
        public Single SteepPower
        {
            get { return GetFloat(Properties.Instance.SteepPowerId); }
            set { SetFloat(Properties.Instance.SteepPowerId, value); }
        }

        // Steep Fade Start, default = 20000
        public Single SteepTexStart
        {
            get { return GetFloat(Properties.Instance.SteepTexStartId); }
            set { SetFloat(Properties.Instance.SteepTexStartId, value); }
        }

        // Steep Fade End, default = 30000
        public Single SteepTexEnd
        {
            get { return GetFloat(Properties.Instance.SteepTexEndId); }
            set { SetFloat(Properties.Instance.SteepTexEndId, value); }
        }

        // Deep ground, default = "white" { }
        public Texture2D DeepTex
        {
            get { return GetTexture(Properties.Instance.DeepTexId) as Texture2D; }
            set { SetTexture(Properties.Instance.DeepTexId, value); }
        }

        [SuppressMessage("ReSharper", "Unity.PreferAddressByIdToGraphicsParams")]
        public Vector2 DeepTexScale
        {
            get { return GetTextureScale(Properties.DEEP_TEX_KEY); }
            set { SetTextureScale(Properties.DEEP_TEX_KEY, value); }
        }

        [SuppressMessage("ReSharper", "Unity.PreferAddressByIdToGraphicsParams")]
        public Vector2 DeepTexOffset
        {
            get { return GetTextureOffset(Properties.DEEP_TEX_KEY); }
            set { SetTextureOffset(Properties.DEEP_TEX_KEY, value); }
        }

        // Deep MT, default = "white" { }
        public Texture2D DeepMultiTex
        {
            get { return GetTexture(Properties.Instance.DeepMultiTexId) as Texture2D; }
            set { SetTexture(Properties.Instance.DeepMultiTexId, value); }
        }

        [SuppressMessage("ReSharper", "Unity.PreferAddressByIdToGraphicsParams")]
        public Vector2 DeepMultiTexScale
        {
            get { return GetTextureScale(Properties.DEEP_MULTI_TEX_KEY); }
            set { SetTextureScale(Properties.DEEP_MULTI_TEX_KEY, value); }
        }

        [SuppressMessage("ReSharper", "Unity.PreferAddressByIdToGraphicsParams")]
        public Vector2 DeepMultiTexOffset
        {
            get { return GetTextureOffset(Properties.DEEP_MULTI_TEX_KEY); }
            set { SetTextureOffset(Properties.DEEP_MULTI_TEX_KEY, value); }
        }

        // Deep MT Tiling, default = 1
        public Single DeepMultiFactor
        {
            get { return GetFloat(Properties.Instance.DeepMultiFactorId); }
            set { SetFloat(Properties.Instance.DeepMultiFactorId, value); }
        }

        // Main Texture, default = "white" { }
        public Texture2D MainTex
        {
            get { return GetTexture(Properties.Instance.MainTexId) as Texture2D; }
            set { SetTexture(Properties.Instance.MainTexId, value); }
        }

        [SuppressMessage("ReSharper", "Unity.PreferAddressByIdToGraphicsParams")]
        public Vector2 MainTexScale
        {
            get { return GetTextureScale(Properties.MAIN_TEX_KEY); }
            set { SetTextureScale(Properties.MAIN_TEX_KEY, value); }
        }

        [SuppressMessage("ReSharper", "Unity.PreferAddressByIdToGraphicsParams")]
        public Vector2 MainTexOffset
        {
            get { return GetTextureOffset(Properties.MAIN_TEX_KEY); }
            set { SetTextureOffset(Properties.MAIN_TEX_KEY, value); }
        }

        // Main MT, default = "white" { }
        public Texture2D MainMultiTex
        {
            get { return GetTexture(Properties.Instance.MainMultiTexId) as Texture2D; }
            set { SetTexture(Properties.Instance.MainMultiTexId, value); }
        }

        [SuppressMessage("ReSharper", "Unity.PreferAddressByIdToGraphicsParams")]
        public Vector2 MainMultiTexScale
        {
            get { return GetTextureScale(Properties.MAIN_MULTI_TEX_KEY); }
            set { SetTextureScale(Properties.MAIN_MULTI_TEX_KEY, value); }
        }

        [SuppressMessage("ReSharper", "Unity.PreferAddressByIdToGraphicsParams")]
        public Vector2 MainMultiTexOffset
        {
            get { return GetTextureOffset(Properties.MAIN_MULTI_TEX_KEY); }
            set { SetTextureOffset(Properties.MAIN_MULTI_TEX_KEY, value); }
        }

        // Main MT Tiling, default = 1
        public Single MainMultiFactor
        {
            get { return GetFloat(Properties.Instance.MainMultiFactorId); }
            set { SetFloat(Properties.Instance.MainMultiFactorId, value); }
        }

        // High Ground, default = "white" { }
        public Texture2D HighTex
        {
            get { return GetTexture(Properties.Instance.HighTexId) as Texture2D; }
            set { SetTexture(Properties.Instance.HighTexId, value); }
        }

        [SuppressMessage("ReSharper", "Unity.PreferAddressByIdToGraphicsParams")]
        public Vector2 HighTexScale
        {
            get { return GetTextureScale(Properties.HIGH_TEX_KEY); }
            set { SetTextureScale(Properties.HIGH_TEX_KEY, value); }
        }

        [SuppressMessage("ReSharper", "Unity.PreferAddressByIdToGraphicsParams")]
        public Vector2 HighTexOffset
        {
            get { return GetTextureOffset(Properties.HIGH_TEX_KEY); }
            set { SetTextureOffset(Properties.HIGH_TEX_KEY, value); }
        }

        // High MT, default = "white" { }
        public Texture2D HighMultiTex
        {
            get { return GetTexture(Properties.Instance.HighMultiTexId) as Texture2D; }
            set { SetTexture(Properties.Instance.HighMultiTexId, value); }
        }

        [SuppressMessage("ReSharper", "Unity.PreferAddressByIdToGraphicsParams")]
        public Vector2 HighMultiTexScale
        {
            get { return GetTextureScale(Properties.HIGH_MULTI_TEX_KEY); }
            set { SetTextureScale(Properties.HIGH_MULTI_TEX_KEY, value); }
        }

        [SuppressMessage("ReSharper", "Unity.PreferAddressByIdToGraphicsParams")]
        public Vector2 HighMultiTexOffset
        {
            get { return GetTextureOffset(Properties.HIGH_MULTI_TEX_KEY); }
            set { SetTextureOffset(Properties.HIGH_MULTI_TEX_KEY, value); }
        }

        // High MT Tiling, default = 1
        public Single HighMultiFactor
        {
            get { return GetFloat(Properties.Instance.HighMultiFactorId); }
            set { SetFloat(Properties.Instance.HighMultiFactorId, value); }
        }

        // Snow, default = "white" { }
        public Texture2D SnowTex
        {
            get { return GetTexture(Properties.Instance.SnowTexId) as Texture2D; }
            set { SetTexture(Properties.Instance.SnowTexId, value); }
        }

        [SuppressMessage("ReSharper", "Unity.PreferAddressByIdToGraphicsParams")]
        public Vector2 SnowTexScale
        {
            get { return GetTextureScale(Properties.SNOW_TEX_KEY); }
            set { SetTextureScale(Properties.SNOW_TEX_KEY, value); }
        }

        [SuppressMessage("ReSharper", "Unity.PreferAddressByIdToGraphicsParams")]
        public Vector2 SnowTexOffset
        {
            get { return GetTextureOffset(Properties.SNOW_TEX_KEY); }
            set { SetTextureOffset(Properties.SNOW_TEX_KEY, value); }
        }

        // Snow MT, default = "white" { }
        public Texture2D SnowMultiTex
        {
            get { return GetTexture(Properties.Instance.SnowMultiTexId) as Texture2D; }
            set { SetTexture(Properties.Instance.SnowMultiTexId, value); }
        }

        [SuppressMessage("ReSharper", "Unity.PreferAddressByIdToGraphicsParams")]
        public Vector2 SnowMultiTexScale
        {
            get { return GetTextureScale(Properties.SNOW_MULTI_TEX_KEY); }
            set { SetTextureScale(Properties.SNOW_MULTI_TEX_KEY, value); }
        }

        [SuppressMessage("ReSharper", "Unity.PreferAddressByIdToGraphicsParams")]
        public Vector2 SnowMultiTexOffset
        {
            get { return GetTextureOffset(Properties.SNOW_MULTI_TEX_KEY); }
            set { SetTextureOffset(Properties.SNOW_MULTI_TEX_KEY, value); }
        }

        // Snow MT Tiling, default = 1
        public Single SnowMultiFactor
        {
            get { return GetFloat(Properties.Instance.SnowMultiFactorId); }
            set { SetFloat(Properties.Instance.SnowMultiFactorId, value); }
        }

        // Steep Texture, default = "white" { }
        public Texture2D SteepTex
        {
            get { return GetTexture(Properties.Instance.SteepTexId) as Texture2D; }
            set { SetTexture(Properties.Instance.SteepTexId, value); }
        }

        [SuppressMessage("ReSharper", "Unity.PreferAddressByIdToGraphicsParams")]
        public Vector2 SteepTexScale
        {
            get { return GetTextureScale(Properties.STEEP_TEX_KEY); }
            set { SetTextureScale(Properties.STEEP_TEX_KEY, value); }
        }

        [SuppressMessage("ReSharper", "Unity.PreferAddressByIdToGraphicsParams")]
        public Vector2 SteepTexOffset
        {
            get { return GetTextureOffset(Properties.STEEP_TEX_KEY); }
            set { SetTextureOffset(Properties.STEEP_TEX_KEY, value); }
        }

        // Deep Start, default = 0
        public Single DeepStart
        {
            get { return GetFloat(Properties.Instance.DeepStartId); }
            set { SetFloat(Properties.Instance.DeepStartId, value); }
        }

        // Deep End, default = 0.3
        public Single DeepEnd
        {
            get { return GetFloat(Properties.Instance.DeepEndId); }
            set { SetFloat(Properties.Instance.DeepEndId, value); }
        }

        // Main lower boundary start, default = 0
        public Single MainLoStart
        {
            get { return GetFloat(Properties.Instance.MainLoStartId); }
            set { SetFloat(Properties.Instance.MainLoStartId, value); }
        }

        // Main lower boundary end, default = 0.5
        public Single MainLoEnd
        {
            get { return GetFloat(Properties.Instance.MainLoEndId); }
            set { SetFloat(Properties.Instance.MainLoEndId, value); }
        }

        // Main upper boundary start, default = 0.3
        public Single MainHiStart
        {
            get { return GetFloat(Properties.Instance.MainHiStartId); }
            set { SetFloat(Properties.Instance.MainHiStartId, value); }
        }

        // Main upper boundary end, default = 0.5
        public Single MainHiEnd
        {
            get { return GetFloat(Properties.Instance.MainHiEndId); }
            set { SetFloat(Properties.Instance.MainHiEndId, value); }
        }

        // High lower boundary start, default = 0.6
        public Single HiLoStart
        {
            get { return GetFloat(Properties.Instance.HiLoStartId); }
            set { SetFloat(Properties.Instance.HiLoStartId, value); }
        }

        // High lower boundary end, default = 0.6
        public Single HiLoEnd
        {
            get { return GetFloat(Properties.Instance.HiLoEndId); }
            set { SetFloat(Properties.Instance.HiLoEndId, value); }
        }

        // High upper boundary start, default = 0.6
        public Single HiHiStart
        {
            get { return GetFloat(Properties.Instance.HiHiStartId); }
            set { SetFloat(Properties.Instance.HiHiStartId, value); }
        }

        // High upper boundary end, default = 0.9
        public Single HiHiEnd
        {
            get { return GetFloat(Properties.Instance.HiHiEndId); }
            set { SetFloat(Properties.Instance.HiHiEndId, value); }
        }

        // Snow Start, default = 0.9
        public Single SnowStart
        {
            get { return GetFloat(Properties.Instance.SnowStartId); }
            set { SetFloat(Properties.Instance.SnowStartId, value); }
        }

        // Snow End, default = 1
        public Single SnowEnd
        {
            get { return GetFloat(Properties.Instance.SnowEndId); }
            set { SetFloat(Properties.Instance.SnowEndId, value); }
        }

        // PlanetOpacity, default = 1
        public Single PlanetOpacity
        {
            get { return GetFloat(Properties.Instance.PlanetOpacityId); }
            set { SetFloat(Properties.Instance.PlanetOpacityId, value); }
        }

        public PQSProjectionSurfaceQuad() : base(Properties.Shader)
        {
        }

        [Obsolete("Creating materials from shader source String is no longer supported. Use Shader assets instead.")]
        public PQSProjectionSurfaceQuad(String contents) : base(contents)
        {
            shader = Properties.Shader;
        }

        public PQSProjectionSurfaceQuad(Material material) : base(material)
        {
            // Throw exception if this material was not the proper material
            if (material.shader.name != Properties.Shader.name)
            {
                throw new InvalidOperationException(
                    "Type Mismatch: Terrain/PQS/Sphere Projection SURFACE QUAD shader required");
            }
        }

    }
}