﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Kopernicus.Components.MaterialWrapper;
using UnityEngine;
namespace Kopernicus.Components
{
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public class PQSMod_BiomeSampler : PQSMod
    {
        internal static IDictionary<Vector2, string> biomeCoordCacheDictionary = new Dictionary<Vector2, string>();
        public override void OnVertexBuildHeight(PQS.VertexBuildData data)
        {
            CelestialBody currentBody = null;
            base.OnVertexBuildHeight(data);
            if (FlightGlobals.currentMainBody)
            {
                if (FlightGlobals.currentMainBody != currentBody)
                {
                    currentBody = FlightGlobals.currentMainBody;
                    biomeCoordCacheDictionary.Clear();
                }
                Vector2 coordVector = new Vector2((float)Math.Round(data.latitude,3),(float)Math.Round(data.longitude,3));
                if (biomeCoordCacheDictionary.ContainsKey(coordVector))
                {
                    return;
                }
                else
                {
                    biomeCoordCacheDictionary.Add(coordVector, ResourceUtilities.GetBiome(coordVector.x, coordVector.y, FlightGlobals.currentMainBody).name);
                }
            }
        }
        public static string GetCachedBiome(double lat, double lon, CelestialBody cb)
        {
            string result;
            Vector2 coordVector = new Vector2((float)Math.Round(lat,3),(float)Math.Round(lon,3));
            if (biomeCoordCacheDictionary.ContainsKey(coordVector))
            {
                biomeCoordCacheDictionary.TryGetValue(coordVector, out result);
                return result;
            }
            else
            {
                result = ResourceUtilities.GetBiome(coordVector.x, coordVector.y, cb).name;
                biomeCoordCacheDictionary.Add(coordVector, result);
                return result;
            }
        }
        public static string GetPreciseBiome(double lat, double lon, CelestialBody cb)
        {
            return ResourceUtilities.GetBiome(lat, lon, cb).name;
        }
    }
}