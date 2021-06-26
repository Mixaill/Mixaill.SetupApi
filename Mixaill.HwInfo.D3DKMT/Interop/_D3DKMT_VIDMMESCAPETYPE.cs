﻿// Copyright 2021, Mikhail Paulyshka
// SPDX-License-Identifier: MIT

namespace Mixaill.HwInfo.D3DKMT.Interop
{
    public enum _D3DKMT_VIDMMESCAPETYPE : uint
    {
        //WDDM 1.0
        D3DKMT_VIDMMESCAPETYPE_SETFAULT = 0,
        D3DKMT_VIDMMESCAPETYPE_RUN_COHERENCY_TEST = 1,
        D3DKMT_VIDMMESCAPETYPE_RUN_UNMAP_TO_DUMMY_PAGE_TEST = 2,
        D3DKMT_VIDMMESCAPETYPE_APERTURE_CORRUPTION_CHECK = 3,
        D3DKMT_VIDMMESCAPETYPE_SUSPEND_CPU_ACCESS_TEST = 4,
        D3DKMT_VIDMMESCAPETYPE_EVICT = 5,
        D3DKMT_VIDMMESCAPETYPE_EVICT_BY_NT_HANDLE = 6,
        D3DKMT_VIDMMESCAPETYPE_GET_VAD_INFO = 7,
        D3DKMT_VIDMMESCAPETYPE_SET_BUDGET = 8,
        D3DKMT_VIDMMESCAPETYPE_SUSPEND_PROCESS = 9,
        D3DKMT_VIDMMESCAPETYPE_RESUME_PROCESS = 10,
        D3DKMT_VIDMMESCAPETYPE_GET_BUDGET = 11,
        D3DKMT_VIDMMESCAPETYPE_SET_TRIM_INTERVALS = 12,
        D3DKMT_VIDMMESCAPETYPE_EVICT_BY_CRITERIA = 13,
        D3DKMT_VIDMMESCAPETYPE_WAKE = 14,
        D3DKMT_VIDMMESCAPETYPE_DEFRAG = 15,
        D3DKMT_VIDMMESCAPETYPE_DELAYEXECUTION = 16,

        //WDDM 2.7
        D3DKMT_VIDMMESCAPETYPE_VALIDATE_INTEGRITY = 17,
    }
}
