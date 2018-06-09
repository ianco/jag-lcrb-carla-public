﻿using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

using System.Text;
using Newtonsoft.Json;
using System.Net;
using Gov.Lclb.Cllb.Interfaces.Microsoft.Dynamics.CRM;
using Gov.Lclb.Cllb.Public.Models;

namespace Gov.Lclb.Cllb.Public.Test
{
	public class CurrentUserTests : ApiIntegrationTestBaseWithLogin
    {
        public CurrentUserTests(CustomWebApplicationFactory<Startup> factory)
          : base(factory)
        { }

        [Fact]
        public async System.Threading.Tasks.Task DefaultDevelopmentUserIsValid()
        {
			await LoginAsDefault();

            var request = new HttpRequestMessage(HttpMethod.Get, "/api/user/current");
            var response = await _client.SendAsync(request);
            string jsonString = await response.Content.ReadAsStringAsync();
			response.EnsureSuccessStatusCode();

            ViewModels.User user = JsonConvert.DeserializeObject<ViewModels.User>(jsonString);

            // The Default development user should not be a new user.
            Assert.False(user.isNewUser);
			Assert.NotNull(user.accountid);
			Assert.NotEmpty(user.accountid);

			ViewModels.Account account = await GetAccountForCurrentUser();
			Assert.NotNull(account);

			await Logout();
        }
        
		[Fact]
        public async System.Threading.Tasks.Task NewRegistrationUserIsValid()
        {
			var loginUser = randomNewUserName("TestUser", 6);
            var strId = await LoginAndRegisterAsNewUser(loginUser);

            var request = new HttpRequestMessage(HttpMethod.Get, "/api/user/current");
            var response = await _client.SendAsync(request);
			string jsonString = await response.Content.ReadAsStringAsync();
            response.EnsureSuccessStatusCode();
            ViewModels.User user = JsonConvert.DeserializeObject<ViewModels.User>(jsonString);

            // The Default development user should not be a new user.
            Assert.False(user.isNewUser);
			Assert.NotNull(user.accountid);
            Assert.NotEmpty(user.accountid);

            ViewModels.Account account = await GetAccountForCurrentUser();
            Assert.NotNull(account);
			var prevId = account.id;

            // logout and then login again, and verify we can still get our account
			await Logout();
			await Login(loginUser);

			request = new HttpRequestMessage(HttpMethod.Get, "/api/user/current");
            response = await _client.SendAsync(request);
            jsonString = await response.Content.ReadAsStringAsync();
            response.EnsureSuccessStatusCode();
            user = JsonConvert.DeserializeObject<ViewModels.User>(jsonString);

            // The Default development user should not be a new user.
            Assert.False(user.isNewUser);
            Assert.NotNull(user.accountid);
            Assert.NotEmpty(user.accountid);

			account = await GetAccountForCurrentUser();
            Assert.NotNull(account);

			Assert.Equal(account.id, prevId);

			await LogoutAndCleanupTestUser(strId);
        }
    }
}
