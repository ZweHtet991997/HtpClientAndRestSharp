using ApiProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiProject.Controllers.ApiServiceController
{
    public class UserController : Controller
    {
        //return only listing data
        [HttpGet]
        [Route("api/userlist_v1")]
        public async Task<ObjectResult> GetUserList_1()
        {
            try
            {
                List<UserModel> lstUser = new List<UserModel>();
                lstUser.Add(new UserModel { UserID = 1, UserName = "User-1", Address = "Yangon", Email = "user1@gmail.com", PhoneNo = "09403333020", BankAccountNo = "0100000303030", CardType = "Visa" });
                lstUser.Add(new UserModel { UserID = 2, UserName = "User-2", Address = "Yangon", Email = "user2@gmail.com", PhoneNo = "09403333020", BankAccountNo = "0100000303031", CardType = "Master" });
                lstUser.Add(new UserModel { UserID = 3, UserName = "User-3", Address = "Yangon", Email = "user3@gmail.com", PhoneNo = "09403333020", BankAccountNo = "0100000303032", CardType = "MPU" });
                lstUser.Add(new UserModel { UserID = 4, UserName = "User-4", Address = "Yangon", Email = "user4@gmail.com", PhoneNo = "09403333020", BankAccountNo = "0100000303033", CardType = "UPI" });
                lstUser.Add(new UserModel { UserID = 5, UserName = "User-5", Address = "Yangon", Email = "user5@gmail.com", PhoneNo = "09403333020", BankAccountNo = "0100000303034", CardType = "Master" });

                return StatusCode(StatusCodes.Status200OK, JsonConvert.SerializeObject(lstUser));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.ToString());
            }
        }

        //return listing data inside model
        [HttpGet]
        [Route("api/userlist_v2")]
        public async Task<ObjectResult> GetUserList_2()
        {
            try
            {
                UserResponseModel responseModel = new UserResponseModel();
                List<UserModel> lstUser = new List<UserModel>();
                lstUser.Add(new UserModel { UserID = 1, UserName = "User-1", Address = "Yangon", Email = "user1@gmail.com", PhoneNo = "09403333020", BankAccountNo = "0100000303030", CardType = "Visa" });
                lstUser.Add(new UserModel { UserID = 2, UserName = "User-2", Address = "Yangon", Email = "user2@gmail.com", PhoneNo = "09403333020", BankAccountNo = "0100000303031", CardType = "Master" });
                lstUser.Add(new UserModel { UserID = 3, UserName = "User-3", Address = "Yangon", Email = "user3@gmail.com", PhoneNo = "09403333020", BankAccountNo = "0100000303032", CardType = "MPU" });
                lstUser.Add(new UserModel { UserID = 4, UserName = "User-4", Address = "Yangon", Email = "user4@gmail.com", PhoneNo = "09403333020", BankAccountNo = "0100000303033", CardType = "UPI" });
                lstUser.Add(new UserModel { UserID = 5, UserName = "User-5", Address = "Yangon", Email = "user5@gmail.com", PhoneNo = "09403333020", BankAccountNo = "0100000303034", CardType = "Master" });

                responseModel.userList = lstUser;
                return StatusCode(StatusCodes.Status200OK, JsonConvert.SerializeObject(lstUser));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.ToString());
            }
        }

        [HttpPost]
        [Route("api/user/create")]
        public async Task<ObjectResult> CreateUserPostMethod(UserModel reqModel)
        {
            try
            {
                if (reqModel != null)
                {
                    return StatusCode(StatusCodes.Status200OK, "Success");
                }
                return StatusCode(StatusCodes.Status304NotModified, "Create Failed");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.ToString());
            }
        }

        [HttpPost]
        [Route("api/user/userdetail")]
        public async Task<ObjectResult> UserDetail(int UserId)
        {
            try
            {
                UserModel model = new UserModel();

                if (UserId != 0)
                {
                    model.UserID = 1;
                    model.UserName = "User-1";
                    model.Address = "Yangon";
                    model.Email = "user1@gmail.com";
                    model.PhoneNo = "09403333020";
                    model.BankAccountNo = "0100000303030";
                    model.CardType = "Visa";
                }
                return StatusCode(StatusCodes.Status200OK, JsonConvert.SerializeObject(model));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.ToString());
            }
        }

        [HttpPut]
        [Route("api/user/update")]
        public async Task<ObjectResult> UpdateUserPostMethod(UserModel reqModel)
        {
            try
            {
                if (reqModel != null)
                {
                    return StatusCode(StatusCodes.Status200OK, "Success");
                }
                return StatusCode(StatusCodes.Status304NotModified, "Update Failed");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.ToString());
            }
        }
    }
}
