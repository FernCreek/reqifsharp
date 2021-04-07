﻿// -------------------------------------------------------------------------------------------------
// <copyright file="AttributeValueXHTMLTestFixture.cs" company="RHEA System S.A.">
//
//   Copyright 2017 RHEA System S.A.
//
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//
//       http://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.
//
// </copyright>
// ------------------------------------------------------------------------------------------------

namespace ReqIFLib.Tests
{
    using NUnit.Framework;

    using ReqIFSharp;
    
    /// <summary>
    /// Suite of tests for the <see cref="EmbeddedValue"/>
    /// </summary>
    [TestFixture]
    public class EmbeddedValueTestFixture
    {
        [Test]
        public void VerifyThatGetSchemaReturnsNull()
        {
            var embeddedValue = new EmbeddedValue();
            Assert.IsNull(embeddedValue.GetSchema());
        }

        [Test]
        public void Verify_that_GetSchema_returns_null()
        {
            var embeddedValue = new EmbeddedValue();
            Assert.That(embeddedValue.GetSchema(), Is.Null);
        }
    }
}
