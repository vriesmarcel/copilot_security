using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using frontend.Models;
using frontend.Models.View;
using frontend.Repositories;

namespace frontend.Controllers
{
   

    public class UserController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;

        public UserController(IMapper mapper, IUserRepository userRepository)
        {
            _mapper = mapper;
            _userRepository = userRepository;
        }

        public async Task<IActionResult> Index()
        {
            var user = await _userRepository.GetUserByIdAsync(1);
            if (user == null)
            {
                return NotFound();
            }

            var userViewModel = _mapper.Map<UserUpdateViewModel>(user);
            return View(userViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateUser([FromForm] UserUpdateViewModel userUpdateViewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var user = await _userRepository.GetUserByEmail(userUpdateViewModel.Email);
            if (user == null)
            {
                return NotFound();
            }

            _mapper.Map(userUpdateViewModel, user);
            await _userRepository.UpdateUserAsync(user);

            return View(user);
        }

    }
}
