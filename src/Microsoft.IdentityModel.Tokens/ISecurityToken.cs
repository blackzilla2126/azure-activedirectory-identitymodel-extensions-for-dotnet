﻿//------------------------------------------------------------------------------
//
// Copyright (c) Microsoft Corporation.
// All rights reserved.
//
// This code is licensed under the MIT License.
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files(the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and / or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions :
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
//
//------------------------------------------------------------------------------

using System;

namespace Microsoft.IdentityModel.Tokens
{
    /// <summary>
    /// Interface for a security token.
    /// </summary>
    public interface ISecurityToken
    {
        /// <summary>
        /// This must be implemented to get the Id of this <see cref="ISecurityToken"/>.
        /// </summary>
        string Id { get; }

        /// <summary>
        /// This must be implemented to get the issuer of this <see cref="ISecurityToken"/>.
        /// </summary>
        string Issuer { get; }

        /// <summary>
        /// This must be implemented to get the <see cref="SecurityKey"/>.
        /// </summary>
        SecurityKey SecurityKey { get; }

        /// <summary>
        /// This must be implemented to get or set the <see cref="SecurityKey"/> that signed this instance.
        /// </summary>
        /// <remarks><see cref="ISecurityTokenValidator"/>.ValidateToken(...) can set this value when a <see cref="SecurityKey"/> is used to successfully validate a signature.</remarks>
        SecurityKey SigningKey { get; set; }

        /// <summary>
        /// This must be implemented to get the time when this <see cref="ISecurityToken"/> starts to be valid.
        /// </summary>
        DateTime ValidFrom { get; }

        /// <summary>
        /// This must be implemented to get the time when this <see cref="ISecurityToken"/> is no longer valid.
        /// </summary>
        DateTime ValidTo { get; }
    }
}
