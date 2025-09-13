using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatacomTest.Pages
{
    
    public class RegisterPage
    {
        private IPage _page;

        public RegisterPage(IPage page) => _page = page;

        private ILocator _btnRegister => _page.GetByRole(AriaRole.Button, new() { Name = "Register" });
        private ILocator _txtFirstName => _page.Locator("#firstName");

        private ILocator _txtLastName => _page.Locator("#lastName");

        private ILocator _txtPhone => _page.Locator("#phone");

        private ILocator _slctCountry => _page.Locator("#countries_dropdown_menu");

        private ILocator _txtEmailAddress => _page.Locator("#emailAddress");

        private ILocator _txtPassword => _page.Locator("#password");

        private ILocator _cbxAgree => _page.Locator("#exampleCheck1");

        private ILocator _message => _page.Locator("#message");

        private ILocator _rstFirstName => _page.Locator("#resultFn");

        private ILocator _rstLastName => _page.Locator("#resultLn");

        private ILocator _rstPhoneNumber => _page.Locator("#resultPhone");

        private ILocator _rstCountry => _page.Locator("#country");

        private ILocator _rstEmailAddress => _page.Locator("#resultEmail");

        public async Task ClickRegister()
        {
            await _btnRegister.ClickAsync();
        }

        public async Task FillinValues(string firstName, string lastName, string phoneNumber, string country, string emailAddress, string password, bool agree)
        {
            await _txtFirstName.FillAsync(firstName);
            await _txtLastName.FillAsync(lastName);
            await _txtPhone.FillAsync(phoneNumber);
            await _slctCountry.SelectOptionAsync(country);
            await _txtEmailAddress.FillAsync(emailAddress);
            await _txtPassword.FillAsync(password);
            
            //TODO: blocked by a defect
            //if (agree)
            //    await _cbxAgree.CheckAsync();
        }

        public async Task Register(string firstName, string lastName, string phoneNumber, string country, string emailAddress, string password, bool agree)
        {
            await FillinValues(firstName, lastName, phoneNumber, country, emailAddress, password, agree);
            await ClickRegister();
        }

        public async Task<string> GetMessage() => await _message.TextContentAsync();

        public async Task<string> GetFirstName() => await _rstFirstName.TextContentAsync();


    }
}
