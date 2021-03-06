﻿using System;
using System.Web;
using System.Web.UI;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Owin;
using QRCodePrint.Models;

namespace QRCodePrint.Account
{
    public partial class Login : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Request.Browser.Browser.Contains("Firefox"))
            {
                Response.Redirect("~/Tools/error.html");
            }
            else
            {
                RegisterHyperLink.NavigateUrl = "Register";
                // 在为密码重置功能启用帐户确认后，启用此项
                //ForgotPasswordHyperLink.NavigateUrl = "Forgot";
                OpenAuthLogin.ReturnUrl = Request.QueryString["ReturnUrl"];
                var returnUrl = HttpUtility.UrlEncode(Request.QueryString["ReturnUrl"]);
                if (!String.IsNullOrEmpty(returnUrl))
                {
                    RegisterHyperLink.NavigateUrl += "?ReturnUrl=" + returnUrl;
                }
            }


           
        }

        protected void LogIn(object sender, EventArgs e)
        {
            if (IsValid)
            {
                // 验证用户密码
                var manager = Context.GetOwinContext().GetUserManager<ApplicationUserManager>();
                var signinManager = Context.GetOwinContext().GetUserManager<ApplicationSignInManager>();
             var user  =    manager.Find(Email.Text, Password.Text);
                
                if ( user !=null && user.EmailConfirmed ==true)
                {
                    var result = signinManager.PasswordSignIn(Email.Text, Password.Text, RememberMe.Checked, shouldLockout: false);

                    switch (result)
                    {
                        case SignInStatus.Success:
                            IdentityHelper.RedirectToReturnUrl(Request.QueryString["ReturnUrl"], Response);
                            break;
                        case SignInStatus.LockedOut:
                            Response.Redirect("/Account/Lockout");
                            break;
                        case SignInStatus.RequiresVerification:
                            Response.Redirect(String.Format("/Account/TwoFactorAuthenticationSignIn?ReturnUrl={0}&RememberMe={1}",
                                                            Request.QueryString["ReturnUrl"],
                                                            RememberMe.Checked),
                                              true);
                            break;
                        case SignInStatus.Failure:
                        default:
                            FailureText.Text = "无效的登录尝试";
                            ErrorMessage.Visible = true;
                            break;
                    }
                }
                else if (user ==null)
                {
                      FailureText.Text = "无效的登录尝试";
                            ErrorMessage.Visible = true;
                }
                else
                {
                    FailureText.Text = "您的账号，管理员未审核，请与管理员联系,谢谢";
                    ErrorMessage.Visible = true;

                }
            }
                // 这不会计入到为执行帐户锁定而统计的登录失败次数中
                // 若要在多次输入错误密码的情况下触发锁定，请更改为 shouldLockout: true
               
        }
    }
}