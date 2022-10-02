﻿// Copyright 2022, Mikhail Paulyshka
// SPDX-License-Identifier: MIT

using System.Runtime.InteropServices;

namespace Mixaill.HwInfo.D3D.Interop
{
    /// <summary>
    /// Reference: d3dkmthk.h::_D3DKMT_QUERYSTATISTICS_MEMORY
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct _D3DKMT_QUERYSTATISTICS_QUERY_SEGMENT
    {
        /// <summary>
        /// in: id of node to get statistics for
        /// </summary>
        public uint SegmentId;
    }
}
