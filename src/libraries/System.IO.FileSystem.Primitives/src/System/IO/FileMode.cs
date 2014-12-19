// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace System.IO
{
    /// <devdoc>
    ///   <para>Contains constants for specifying how the OS should open a file.
    ///   These will control whether you overwrite a file, open an existing
    ///   file, or some combination thereof.
    ///   
    /// To append to a file, use Append (which maps to OpenOrCreate then we seek
    /// to the end of the file).  To truncate a file or create it if it doesn't
    /// exist, use Create.</para>
    /// <devdoc>
    [System.Runtime.InteropServices.ComVisible(true)]
    public enum FileMode
    {
        /// <devdoc>
        ///   <para>Creates a new file.  An exception is raised if the file already exists.<para>
        /// </devdoc>
        CreateNew = 1,

        /// <devdoc>
        ///   <para>Creates a new file.  If the file already exists, it is overwritten.<para>
        /// </devdoc>
        Create = 2,

        /// <devdoc>
        ///   <para>Opens an existing file.  An exception is raised if the file does not exist.<para>
        /// </devdoc>
        Open = 3,

        /// <devdoc>
        ///   <para>Opens the file if it exists.  Otherwise, creates a new file.<para>
        /// </devdoc>
        OpenOrCreate = 4,

        /// <devdoc>
        ///   <para>Opens an existing file.  Once opened, the file is truncated so that its
        ///   size is zero bytes.  The calling process must open the file with at least
        ///   WRITE access.  An exception is raised if the file does not exist.<para>
        /// </devdoc>
        Truncate = 5,

        /// <devdoc>
        ///   <para>Opens the file if it exists and seeks to the end.  Otherwise,
        ///   creates a new file.<para>
        /// </devdoc>
        Append = 6
    }
}