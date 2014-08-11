// ------------------------------------------------------------------------------
// Copyright (c) 2014 Microsoft Corporation
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
//  all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
//  THE SOFTWARE.
// ------------------------------------------------------------------------------

namespace Microsoft.Live
{
    using System;

    public enum BackgroundTransferPreferences
    {
        /// <summary>
        /// Allow transfers only when the device is using external power and has a Wi-Fi connection.
        /// This is the default setting.
        /// </summary>
        None,

        /// <summary>
        /// Allow transfers when the device is connected to external power and has a Wi-Fi or cellular connection.
        /// </summary>
        AllowCellular,

        /// <summary>
        /// Allow transfers when there is a Wi-Fi connection and the device is using battery or external power.
        /// </summary>
        AllowBattery,

        /// <summary>
        /// Allow transfers when the device is using battery or external power and has a Wi-Fi or cellular connection.
        /// </summary>
        AllowCellularAndBattery
    }
}