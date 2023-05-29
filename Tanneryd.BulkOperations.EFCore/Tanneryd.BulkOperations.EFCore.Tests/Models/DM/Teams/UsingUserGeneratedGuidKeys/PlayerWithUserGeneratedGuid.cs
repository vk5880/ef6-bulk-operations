// <auto-generated>
// ReSharper disable All

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Tanneryd.BulkOperations.EFCore.Tests
{
    // PlayerWithUserGeneratedGuid
    public class PlayerWithUserGeneratedGuid
    {
        public Guid Id { get; set; } // Id (Primary key)
        public string Firstname { get; set; } // Firstname
        public string Lastname { get; set; } // Lastname
        public Guid TeamId { get; set; } // TeamId

        // Foreign keys

        /// <summary>
        /// Parent TeamWithUserGeneratedGuid pointed by [PlayerWithUserGeneratedGuid].([TeamId]) (FK_dbo.PlayerWithUserGeneratedGuid_dbo.TeamWithUserGeneratedGuid_TeamId)
        /// </summary>
        public TeamWithUserGeneratedGuid TeamWithUserGeneratedGuid { get; set; } // FK_dbo.PlayerWithUserGeneratedGuid_dbo.TeamWithUserGeneratedGuid_TeamId
    }

}
// </auto-generated>