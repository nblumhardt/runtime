// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

/*****************************************************************************/

#include "jitpch.h"
#ifdef _MSC_VER
#pragma hdrstop
#endif

#if defined(TARGET_ARM64)

#include "target.h"

const char*            Target::g_tgtCPUName  = "arm64";
const Target::ArgOrder Target::g_tgtArgOrder = ARG_ORDER_R2L;

#endif // TARGET_ARM64
