﻿namespace Raven.Database.Bundles.ElasticsearchReplication
{
    public class DeleteByQueryCommand
    {
        public string IndexName { get; set; }
        public string Command { get; set; }
    }
}