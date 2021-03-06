/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.rtc.Model.V20180111;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.rtc.Transform.V20180111
{
    public class GetAllTemplateResponseUnmarshaller
    {
        public static GetAllTemplateResponse Unmarshall(UnmarshallerContext context)
        {
			GetAllTemplateResponse getAllTemplateResponse = new GetAllTemplateResponse();

			getAllTemplateResponse.HttpResponse = context.HttpResponse;
			getAllTemplateResponse.RequestId = context.StringValue("GetAllTemplate.RequestId");

			List<string> getAllTemplateResponse_templateIds = new List<string>();
			for (int i = 0; i < context.Length("GetAllTemplate.TemplateIds.Length"); i++) {
				getAllTemplateResponse_templateIds.Add(context.StringValue("GetAllTemplate.TemplateIds["+ i +"]"));
			}
			getAllTemplateResponse.TemplateIds = getAllTemplateResponse_templateIds;
        
			return getAllTemplateResponse;
        }
    }
}