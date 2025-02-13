﻿using Shouldly;
using Xunit;

namespace Marten.Schema.Testing
{
    public class configuring_schema_name_Tests
    {
        [Fact]
        public void use_the_default_pg_type_for_the_member_type_if_not_overridden()
        {
            DocumentMapping.For<Customer>().DatabaseSchemaName.ShouldBe("organization");
        }

        #region sample_using_DatabaseSchemaName_attribute

        [DatabaseSchemaName("organization")]
        public class Customer
        {
            [Identity]
            public string Name { get; set; }
        }

        #endregion
    }
}
