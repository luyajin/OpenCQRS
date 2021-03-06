﻿using System;
using Newtonsoft.Json;

namespace OpenCqrs.Store.CosmosDB.Sql.Documents
{
    public class EventDocument
    {
        [JsonProperty(PropertyName = "id")]
        public Guid Id { get; set; }

        [JsonProperty(PropertyName = "aggregateId")]
        public Guid AggregateId { get; set; }

        [JsonProperty(PropertyName = "commandId")]
        public Guid CommandId { get; set; }

        [JsonProperty(PropertyName = "sequence")]
        public int Sequence { get; set; }

        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        [JsonProperty(PropertyName = "data")]
        public string Data { get; set; }

        [JsonProperty(PropertyName = "timeStamp")]
        public DateTime TimeStamp { get; set; }

        [JsonProperty(PropertyName = "userId")]
        public Guid? UserId { get; set; }

        [JsonProperty(PropertyName = "source")]
        public string Source { get; set; }
    }
}
