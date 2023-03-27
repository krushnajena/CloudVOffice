using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CloudVOffice.Core.Domain.User
{
    public partial class UserRoleMapping : BaseEntity
    {
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets the customer role identifier
        /// </summary>
        public int RoleId { get; set; }

        [JsonIgnore]
        public User User { get; set; }

        [JsonIgnore]
        public Role Role { get; set; }

    }
}
