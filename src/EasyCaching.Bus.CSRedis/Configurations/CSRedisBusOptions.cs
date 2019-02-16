﻿namespace EasyCaching.Bus.CSRedis
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Redis bus options.
    /// </summary>
    public class CSRedisBusOptions 
    {
        /// <summary>
        /// Gets or sets the node rule.
        /// </summary>
        /// <value>The node rule.</value>
        public Func<string, string> NodeRule { get; set; } = null;

        /// <summary>
        /// Gets or sets the connection strings.
        /// </summary>
        /// <value>The connection strings.</value>
        public List<string> ConnectionStrings { get; set; }
    }
}
