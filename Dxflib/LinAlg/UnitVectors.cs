﻿// Dxflib
// UnitVectors.cs
// 
// ============================================================
// 
// Created: 2018-08-11
// Last Updated: 2018-09-01-1:09 PM
// By: Adam Renaud
// 
// ============================================================

namespace Dxflib.LinAlg
{
    /// <summary>
    ///     A Struct for basic unit vectors
    /// </summary>
    public struct UnitVectors
    {
        /// <summary>
        ///     The X unit vector
        /// </summary>
        public static readonly Vector XUnitVector = new Vector(1, 0);

        /// <summary>
        ///     The Y unit vector
        /// </summary>
        public static readonly Vector YUnitVector = new Vector(0, 1);

        /// <summary>
        ///     The Z unit vector
        /// </summary>
        public static readonly Vector ZUnitVector = new Vector(0, 0, 1);
    }
}