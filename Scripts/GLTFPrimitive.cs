﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Siccity.GLTFUtility {
    [Serializable]
    public class GLTFPrimitive {
        public enum RenderingMode { Points = 1, Lines = 2, Triangles = 3 }
        /// <summary> Rendering mode</summary>
        public RenderingMode mode;
        public int indices = -1;
        public GLTFAttributes attributes;
        public int material = -1;
        /// <summary> Morph targets </summary>
        public List<GLTFAttributes> targets;

        [Serializable]
        public class GLTFAttributes {
            public int POSITION = -1;
            public int NORMAL = -1;
            public int TANGENT = -1;
            public int TEXCOORD_0 = -1;
            public int TEXCOORD_1 = -1;
            public int TEXCOORD_2 = -1;
            public int TEXCOORD_3 = -1;
            public int WEIGHTS_0 = -1;
            public int WEIGHTS_1 = -1;
        }
    }
}