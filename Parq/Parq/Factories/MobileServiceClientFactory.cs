﻿#region Copyright
/*Copyright (c) 2016 Javus Software (Pty) Ltd

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
*/
#endregion
using System.Net.Http;
using Microsoft.WindowsAzure.MobileServices;
using Parq.Helpers;

// Source: http://thirteendaysaweek.com/2013/12/13/xamarin-ios-and-authentication-in-windows-azure-mobile-services-part-iii-custom-authentication/
namespace Parq.Factories
{
    public static class MobileServiceClientFactory
	{
		public static MobileServiceClient CreateClient()
		{
            return new MobileServiceClient (Keys.ApplicationURL);
		}

		public static MobileServiceClient CreateClient(params HttpMessageHandler[] handlers)
		{
			return new MobileServiceClient (Keys.ApplicationURL,handlers);
		}
	}
}