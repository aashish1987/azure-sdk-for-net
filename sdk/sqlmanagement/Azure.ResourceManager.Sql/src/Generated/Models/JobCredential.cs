// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> A stored credential that can be used by a job to connect to target databases. </summary>
    public partial class JobCredential : Resource
    {
        /// <summary> Initializes a new instance of JobCredential. </summary>
        public JobCredential()
        {
        }

        /// <summary> Initializes a new instance of JobCredential. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="username"> The credential user name. </param>
        /// <param name="password"> The credential password. </param>
        internal JobCredential(string id, string name, string type, string username, string password) : base(id, name, type)
        {
            Username = username;
            Password = password;
        }

        /// <summary> The credential user name. </summary>
        public string Username { get; set; }
        /// <summary> The credential password. </summary>
        public string Password { get; set; }
    }
}