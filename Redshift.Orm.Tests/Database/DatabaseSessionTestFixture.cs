﻿#region Copyright
// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DatabaseSessionTestFixture.cs" company="RHEA System S.A.">
//    Copyright (c) 2018 RHEA System S.A.
//
//    Author: Alex Vorobiev
//
//    This file is part of Redshift.Orm.Tests.
//
//    Redshift.Orm.Tests is free software: you can redistribute it and/or modify
//    it under the terms of the GNU Lesser General Public License as published by
//    the Free Software Foundation, either version 3 of the License, or
//    (at your option) any later version.
//
//    Redshift.Orm.Tests is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//    GNU Lesser General Public License for more details.
//
//    You should have received a copy of the GNU General Public License
//    along with Redshift.Orm.Tests.  If not, see <http://www.gnu.org/licenses/>.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
#endregion

namespace Redshift.Orm.Tests.Database
{
    using NUnit.Framework;
    using Redshift.Orm.Database;

    [TestFixture]
    public class DatabaseSessionTestFixture
    {
        [Test]
        public void VerifyCreateDisposeWorks()
        {
            var connector = new PostgresDatabaseConnector();
            DatabaseSession.Instance.CreateConnector(connector);

            Assert.AreEqual(connector, DatabaseSession.Instance.Connector);

            DatabaseSession.Instance.Dispose();
            Assert.IsNull(DatabaseSession.Instance.Connector);
        }
    }
}
