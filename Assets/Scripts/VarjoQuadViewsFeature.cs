using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.XR.OpenXR.Features;

#if UNITY_EDITOR
[UnityEditor.XR.OpenXR.Features.OpenXRFeature(UiName = "Varjo Quad Views",
    BuildTargetGroups = new[] { BuildTargetGroup.Standalone, BuildTargetGroup.WSA },
    Company = "Varjo Technologies Oy",
    Desc = "Eanbels quad view rendering",
    DocumentationLink = "https://docs.unity.cn/Packages/com.unity.xr.openxr@0.1/manual/index.html",
    OpenxrExtensionStrings = "XR_VARJO_quad_views XR_VARJO_foveated_rendering", // this extension doesn't exist, a log message will be printed that it couldn't be enabled
    Version = "0.0.1",
    FeatureId = featureId)]
#endif
public class VarjoQuadViewsFeature : OpenXRFeature
{
    /// <summary>
    /// The feature id string. This is used to give the feature a well known id for reference.
    /// </summary>
    public const string featureId = "com.varjo.openxr.feature.quad.views";

}

