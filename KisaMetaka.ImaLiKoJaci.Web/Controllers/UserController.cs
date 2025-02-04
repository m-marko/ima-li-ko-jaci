﻿using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using KisaMetaka.ImaLiKoJaci.Infrastructure.Services;
using KisaMetaka.ImaLiKoJaci.Infrastructure.User;
using KisaMetaka.ImaLiKoJaci.Web.Models.User;

namespace KisaMetaka.ImaLiKoJaci.Web.Controllers
{
    public class UserController : ApiController
    {
        private readonly IUserRepository _userRepository;
        private readonly ILoginService _loginService;

        public UserController(
            IUserRepository userRepository,
            ILoginService loginService)
        {
            _userRepository = userRepository;
            _loginService = loginService;
        }

        [HttpPut, Authorize]
        public HttpStatusCode Update(UserUpdateModel model)
        {
            var currentUser = _loginService.TryGetSignedInUser();
            _userRepository.Update(currentUser.Id, model.DisplayName);
            
            return HttpStatusCode.OK;
        }

        public IEnumerable<LeaderboardModel> GetLeaderboard()
        {
            return _userRepository.GetForLeaderboard().Select(u => new LeaderboardModel(u.DisplayName, u.TotalScore));
        }
    }
}
