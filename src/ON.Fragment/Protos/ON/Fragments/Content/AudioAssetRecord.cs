﻿using ON.Fragments.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pb = global::Google.Protobuf;

namespace ON.Fragments.Content
{
    public sealed partial class AudioAssetPublicRecord : pb::IMessage<AudioAssetPublicRecord>
    {
        public Guid AssetIDGuid
        {
            get => AssetID.ToGuid();
            set => AssetID = value.ToString();
        }
    }
}