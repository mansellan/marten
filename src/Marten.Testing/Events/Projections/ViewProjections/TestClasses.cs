﻿using System;
using System.Collections.Generic;

namespace Marten.Testing.Events.Projections.ViewProjections
{
    #region sample_view-projection-test-classes
    // License events
    public class LicenseCreated
    {
        public Guid LicenseId { get; }

        public string Name { get; }

        public LicenseCreated(Guid licenseId, string name)
        {
            LicenseId = licenseId;
            Name = name;
        }
    }

    public class LicenseFeatureToggled
    {
        public Guid LicenseId { get; }

        public string FeatureToggleName { get; }

        public LicenseFeatureToggled(Guid licenseId, string featureToggleName)
        {
            LicenseId = licenseId;
            FeatureToggleName = featureToggleName;
        }
    }

    public class LicenseFeatureToggledOff
    {
        public Guid LicenseId { get; }

        public string FeatureToggleName { get; }

        public LicenseFeatureToggledOff(Guid licenseId, string featureToggleName)
        {
            LicenseId = licenseId;
            FeatureToggleName = featureToggleName;
        }
    }

    // User Groups events

    public class UserGroupCreated
    {
        public Guid GroupId { get; }

        public string Name { get; }

        public UserGroupCreated(Guid groupId, string name)
        {
            GroupId = groupId;
            Name = name;
        }
    }

    public class SingleUserAssignedToGroup
    {
        public Guid GroupId { get; }

        public Guid UserId { get; }

        public SingleUserAssignedToGroup(Guid groupId, Guid userId)
        {
            GroupId = groupId;
            UserId = userId;
        }
    }

    public class MultipleUsersAssignedToGroup
    {
        public Guid GroupId { get; }

        public List<Guid> UserIds { get; }

        public MultipleUsersAssignedToGroup(Guid groupId, List<Guid> userIds)
        {
            GroupId = groupId;
            UserIds = userIds;
        }
    }

    // User Events
    public class UserRegistered
    {
        public Guid UserId { get; }

        public string Email { get; }

        public UserRegistered(Guid userId, string email)
        {
            UserId = userId;
            Email = email;
        }
    }

    public class UserLicenseAssigned
    {
        public Guid UserId { get; }

        public Guid LicenseId { get; }

        public UserLicenseAssigned(Guid userId, Guid licenseId)
        {
            UserId = userId;
            LicenseId = licenseId;
        }
    }

    public class UserFeatureToggles
    {
        public Guid Id { get; set; }

        public Guid LicenseId { get; set; }

        public List<string> FeatureToggles { get; set; } = new();
    }


    public class UserGroupsAssignment
    {
        public Guid Id { get; set; }

        public List<Guid> Groups { get; set; } = new();
    }

    #endregion
}
