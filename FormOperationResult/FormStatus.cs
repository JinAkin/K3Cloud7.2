﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Middleware.Target.Core.Models.K3Cloud7_2.FormOperationResult
{
    [JsonObject]
    public class FormStatus
    {
        [JsonProperty]
        public string ErrorCode { get; internal set; }//end property
        
        [JsonProperty]
        public string Message { get; internal set; }//end property

        [JsonProperty]
        public bool IsSuccess { get; internal set; }//end property

        [JsonProperty]
        public List<ValidationError> Errors { get; internal set; }//end property

        [JsonProperty]
        public List<SuccessEntity> SuccessEntitys { get; internal set; }//end property

        [JsonProperty]
        public List<SuccessMessage> SuccessMessages { get; internal set; }//end property
    }//end class
}//end namespace
