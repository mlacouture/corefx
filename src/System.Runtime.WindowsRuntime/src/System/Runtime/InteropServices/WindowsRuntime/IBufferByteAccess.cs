// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Security;
using GUID = System.Runtime.InteropServices.GuidAttribute;

namespace System.Runtime.InteropServices.WindowsRuntime
{
    /// <summary>
    /// WinRT's <code>IBufferByteAccess</code> interface definition.
    /// </summary>
    [ComImport]
    [GUID("905a0fef-bc53-11df-8c49-001e4fc686da")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    interface IBufferByteAccess
    {
        // This needs to be a function - MCG doesn't support properties/events for [ComImport] interface yet
        [SecurityCritical]
        IntPtr GetBuffer();
    }  // interface IBufferByteAccess
}  // namespace

// IBufferByteAccess.cs
